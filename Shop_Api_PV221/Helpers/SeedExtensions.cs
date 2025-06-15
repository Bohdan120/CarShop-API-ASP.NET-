using BusinessLogic.Entities;
using BusinessLogic.Helpers;
using DataAccess.Data.Entities;
using DataAccess.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Shop_Api_PV221.Helpers
{
    public static class Seeder
    {
        public static async Task SeedRoles(this IServiceProvider app)
        {
            var roleManager = app.GetRequiredService<RoleManager<IdentityRole>>();

            var roles = typeof(Roles).GetFields(
                BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)
                .Select(x => (string)x.GetValue(null)!);

            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
            }
        }

        public static async Task SeedAdmin(this IServiceProvider app)
        {
            var userManager = app.GetRequiredService<UserManager<User>>();

            const string USERNAME = "myadmin@myadmin.com";
            const string PASSWORD = "Admin1@";

            var existingUser = await userManager.FindByNameAsync(USERNAME);

            if (existingUser == null)
            {
                var user = new User
                {
                    UserName = USERNAME,
                    Email = USERNAME
                };

                var result = await userManager.CreateAsync(user, PASSWORD);

                if (result.Succeeded)
                    await userManager.AddToRoleAsync(user, Roles.ADMIN);
            }
        }

        public static async Task SeedReviews(this IServiceProvider app)
        {
            using var scope = app.CreateScope();

            var reviewRepo = scope.ServiceProvider.GetRequiredService<IRepository<Review>>();
            var carRepo = scope.ServiceProvider.GetRequiredService<IRepository<Car>>();
            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<User>>();

            if (reviewRepo.GetAll().Any()) return;

            var user = await userManager.Users.FirstOrDefaultAsync();
            var cars = carRepo.GetAll().Take(5).ToList();

            if (user == null || cars.Count == 0) return;

            var goodComments = new[]
            {
                "Справжній звір! Плавна та бездоганна поїздка.",
                "Дуже задоволений покупкою, відмінний сервіс.",
                "Ідеальний сімейний автомобіль – безпечний та комфортний.",
                "Автомобіль виглядає ще краще в реальному житті!",
                "Вражений якістю та функціями.",
                "Швидка доставка, професійний персонал.",
                "Все чудово! Однозначно купуватиму тут знову.",
                "Відмінна продуктивність, жодних нарікань.",
                "Відчувається як абсолютно новий – настійно рекомендую!",
                "Дивовижна цінність за такий стан та пробіг."
            };

            var rnd = new Random();
            var reviews = new List<Review>();

            for (int i = 0; i < 10; i++)
            {
                var car = cars[i % cars.Count];
                var rating = rnd.Next(4, 6); 
                var comment = goodComments[i % goodComments.Length];

                reviews.Add(new Review
                {
                    CarId = car.Id,
                    UserId = user.Id,
                    Rating = rating,
                    Comment = comment,
                    ReviewDate = DateTime.UtcNow.AddDays(-rnd.Next(1, 15))
                });
            }

            foreach (var review in reviews)
                reviewRepo.Insert(review);

            reviewRepo.Save();
        }

    }
}
