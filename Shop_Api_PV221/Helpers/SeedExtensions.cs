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
                "An absolute beast! Smooth and flawless ride.",
                "Very satisfied with the purchase, excellent service.",
                "Perfect family car – safe and comfortable.",
                "The car looks even better in real life!",
                "Impressed by the quality and features.",
                "Fast delivery, professional staff.",
                "Everything’s great! Will definitely buy here again.",
                "Great performance, no complaints at all.",
                "Feels like brand new – highly recommended!",
                "Amazing value for the condition and mileage."
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
