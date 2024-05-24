using DataAccess.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public static class ModelBuilderExtensions
    {
        public static void SeedData(this ModelBuilder builder)
        {
            builder.Entity<Category>().HasData(new[]
            {
                new Category() { Id = (int)Categories.Diesel, Name = "Diesel" },
                new Category() { Id = (int)Categories.Electric, Name = "Electric" },
                new Category() { Id = (int)Categories.Gasoline, Name = "Gasoline" },
                new Category() { Id = (int)Categories.Hybrid, Name = "Hybrid" }
            });


            builder.Entity<Product>().HasData(new[]
          {
                new Product()
                {
                    Id = 1,
                    Make = "Toyota",
                    Model = "Corolla",
                    Year = 2022,
                    Price = 25000,
                    Mileage = 20000,                   
                    Engine = "2.0L 4-cylinder",
                    Horsepower = 169,
                    CategoryId = 3,
                    InStock = true,
                    ImageUrl = "https://today.ua/wp-content/uploads/2021/12/Toyota-Corolla-1.jpg",
                    Description = "Silver color, Automatic transmission, Bluetooth, Backup Camera, Keyless Entry"
                },
                new Product()
                {
                    Id = 2,
                    Make = "Ford",
                    Model = "Mustang",
                    Year = 2020,
                    Price = 35000,
                    Mileage = 15000,                   
                    Engine = "5.0L V8",
                    Horsepower = 450,
                    CategoryId = 3,
                    InStock = true,
                    ImageUrl = "https://img.automoto.ua/overview/ford-mustang-2020-3fd-huge-1564.jpg",
                    Description = "Red color, Manual transmission, Leather Seats, Navigation System, Heated Seats"
                },
                new Product()
                {
                    Id = 3,
                    Make = "BMW",
                    Model = "3 Series",
                    Year = 2021,
                    Price = 40000,
                    Mileage = 12000,                  
                    Engine = "2.0L 4-cylinder",
                    Horsepower = 255,
                    CategoryId = 1,
                    InStock = true,
                    ImageUrl = "https://hips.hearstapps.com/hmg-prod/images/2021-bmw-3-series-mmp-1-1593549868.jpg",
                    Description = "White color, Automatic transmission, Sunroof, Adaptive Cruise Control, Parking Assistance"
                },
                new Product()
                {
                    Id = 4,
                    Make = "Tesla",
                    Model = "Model 3",
                    Year = 2022,
                    Price = 45000,
                    Mileage = 8000,                   
                    Engine = "Electric Motor",
                    Horsepower = 322,
                    CategoryId = 2,
                    InStock = true,
                    ImageUrl = "https://cdn0.riastatic.com/photosnew/auto/photo/tesla_model-3__518635415f.jpg",
                    Description = "Red color, Automatic transmission, Autopilot, Full Self-Driving Capability, Premium Audio System"
                },
                new Product()
                {
                    Id = 5,
                    Make = "Audi",
                    Model = "Q5",
                    Year = 2021,
                    Price = 38000,
                    Mileage = 15000,                   
                    Engine = "2.0L 4-cylinder",
                    Horsepower = 248,
                    CategoryId = 3,
                    InStock = true,
                    ImageUrl = "https://i.infocar.ua/i/12/6234/1400x936.jpg",
                    Description = "Gray color, Automatic transmission, Virtual Cockpit, Panoramic Sunroof, Apple CarPlay"
                },
                new Product()
                {
                    Id = 6,
                    Make = "Mercedes-Benz",
                    Model = "E-Class",
                    Year = 2020,
                    Price = 42000,
                    Mileage = 18000,                 
                    Engine = "2.0L 4-cylinder",
                    Horsepower = 255,
                    CategoryId = 3,
                    InStock = true,
                    ImageUrl = "https://i.infocar.ua/i/2/6241/118625/1024x.jpg",
                    Description = "Silver color, Automatic transmission, MBUX Infotainment, Heated Steering Wheel, Air Suspension"
                }
            });
        }
    }
}
