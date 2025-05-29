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


            builder.Entity<Car>().HasData(new[]
          {
                new Car()
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
                new Car()
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
                new Car()
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
               new Car()
                {
                    Id = 4,
                    Make = "Tesla",
                    Model = "Model 3",
                    Year = 2022,
                    Price = 45000,
                    Mileage = 8000,
                    Engine = "Electric Motor",
                    Horsepower = 322,
                    CategoryId = 4,
                    InStock = true,
                    ImageUrl = "https://cdn0.riastatic.com/photosnew/auto/photo/tesla_model-3__518635415f.jpg",
                    Description = "Red color, Automatic transmission, Autopilot, Full Self-Driving Capability, Premium Audio System"
                },
                new Car()
                {
                    Id = 5,
                    Make = "Audi",
                    Model = "Q5",
                    Year = 2021,
                    Price = 38000,
                    Mileage = 15000,
                    Engine = "2.0L 4-cylinder",
                    Horsepower = 248,
                    CategoryId = 1,
                    InStock = true,
                    ImageUrl = "https://i.infocar.ua/i/12/6234/1400x936.jpg",
                    Description = "Gray color, Automatic transmission, Virtual Cockpit, Panoramic Sunroof, Apple CarPlay"
                },
                new Car()
                {
                    Id = 6,
                    Make = "Mercedes-Benz",
                    Model = "E-Class",
                    Year = 2020,
                    Price = 42000,
                    Mileage = 18000,
                    Engine = "2.0L 4-cylinder",
                    Horsepower = 255,
                    CategoryId = 1,
                    InStock = true,
                    ImageUrl = "https://i.infocar.ua/i/2/6241/118625/1024x.jpg",
                    Description = "Silver color, Automatic transmission, MBUX Infotainment, Heated Steering Wheel, Air Suspension"
                },
                new Car()
                {
                    Id = 7,
                    Make = "Chevrolet",
                    Model = "Tahoe",
                    Year = 2020,
                    Price = 55000,
                    Mileage = 25000,
                    Engine = "5.3L V8",
                    Horsepower = 355,
                    CategoryId = 3,
                    InStock = true,
                    ImageUrl = "https://i.infocar.ua/i/12/6229/1200x630.jpg",
                    Description = "Black color, Automatic transmission, Leather Seats, Captain's Chairs, Wireless Charging"
                },
                new Car()
                {
                    Id = 8,
                    Make = "Lexus",
                    Model = "RX 350",
                    Year = 2020,
                    Price = 42000,
                    Mileage = 20000,
                    Engine = "3.5L V6",
                    Horsepower = 295,
                    CategoryId = 2,
                    InStock = true,
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ37JJrfO9luseU6bzVX5qjWfk5hvyF1QaaKROr4zfrBA&s",
                    Description = "Silver color, Automatic transmission, Leather Seats, Panoramic Roof, Power Liftgate"
                },
                new Car()
                {
                    Id = 9,
                    Make = "Ford",
                    Model = "F-150",
                    Year = 2021,
                    Price = 45000,
                    Mileage = 15000,
                    Engine = "3.5L V6",
                    Horsepower = 375,
                    CategoryId = 3,
                    InStock = true,
                    ImageUrl = "https://i.infocar.ua/i/2/6467/122061/1920x.jpg",
                    Description = "Blue color, Automatic transmission, Towing Package, Tailgate Step, Pro Trailer Backup Assist"
                },
                new Car()
                {
                    Id = 10,
                    Make = "BMW",
                    Model = "X5",
                    Year = 2021,
                    Price = 60000,
                    Mileage = 10000,
                    Engine = "3.0L 6-cylinder",
                    Horsepower = 335,
                    CategoryId = 1,
                    InStock = true,
                    ImageUrl = "https://img.automoto.ua/overview/bmw-x5-2021-e98-huge-1897.jpg",
                    Description = "Black color, Automatic transmission, Heads-Up Display, Gesture Control, Wireless Charging"
                },
                new Car()
                {
                    Id = 11,
                    Make = "Toyota",
                    Model = "RAV4",
                    Year = 2020,
                    Price = 32000,
                    Mileage = 18000,
                    Engine = "2.5L 4-cylinder",
                    Horsepower = 203,
                    CategoryId = 3,
                    InStock = true,
                    ImageUrl = "https://hips.hearstapps.com/hmg-prod/images/2020-toyota-rav4-mmp-1-1570472132.jpg",
                    Description = "Blue color, Automatic transmission, Toyota Safety Sense, Apple CarPlay, Android Auto"
                },
                new Car()
                {
                    Id = 12,
                    Make = "Tesla",
                    Model = "Model Y",
                    Year = 2022,
                    Price = 55000,
                    Mileage = 6000,
                    Engine = "Electric Motor",
                    Horsepower = 384,
                    CategoryId = 4,
                    InStock = true,
                    ImageUrl = "https://wah.ua/static/content/thumbs/744*496/4/20/dsxi56-8cff2f0dc3ae189e43186c5bcca08204.jpeg",
                    Description = "White color, Automatic transmission, Autopilot, Full Self-Driving Capability, Panoramic Glass Roof"
                },
                new Car()
                {
                    Id = 13,
                    Make = "Chevrolet",
                    Model = "Silverado",
                    Year = 2020,
                    Price = 38000,
                    Mileage = 25000,
                    Engine = "5.3L V8",
                    Horsepower = 355,
                    CategoryId = 3,
                    InStock = true,
                    ImageUrl = "https://cdn.motor1.com/images/mgl/EBx7o/s1/2019-chevrolet-silverado-trail-boss.jpg",
                    Description = "Red color, Automatic transmission, Trailer Sway Control, Apple CarPlay, Android Auto"
                },
                new Car()
                {
                    Id = 14,
                    Make = "Ford",
                    Model = "Escape",
                    Year = 2021,
                    Price = 30000,
                    Mileage = 12000,
                    Engine = "2.5L 4-cylinder Hybrid",
                    Horsepower = 200,
                    CategoryId = 3,
                    InStock = true,
                    ImageUrl = "https://hips.hearstapps.com/hmg-prod/images/2021-ford-escape-phev-108-1651779562.jpg?crop=0.843xw:0.631xh;0.0753xw,0.336xh&resize=1200:*",
                    Description = "Gray color, CVT transmission, Ford Co-Pilot360, Wireless Charging Pad, Hands-Free Liftgate"
                },
                new Car()
                {
                    Id =15,
                    Make = "Mercedes-Benz",
                    Model = "GLC",
                    Year = 2021,
                    Price = 48000,
                    Mileage = 10000,
                    Engine = "2.0L 4-cylinder",
                    Horsepower = 255,
                    CategoryId = 1,
                    InStock = true,
                    ImageUrl = "https://lh6.googleusercontent.com/proxy/IqRMJz8oK5fas4AlZXL8mGS_JsFgrKlHHASXVHuwjhEzpYDjkZOjiBP9OEeMoXAEm8VhkWBgcLWfrc27H6ma08Q8UfYD-QQyR9WGiocdTlJ4rD629pY3-rQW3v2404pCY2YM6vLP42cH9I7-xw",
                    Description = "Black color, Automatic transmission, MBUX Infotainment, Panoramic Sunroof, Heated Seats"
                },
                new Car()
                {
                    Id = 16,
                    Make = "Audi",
                    Model = "RS 7",
                    Year = 2023,
                    Price = 110000,
                    Mileage = 8000,
                    Engine = "4.0L V8 Twin-Turbo",
                    Horsepower = 591,
                    CategoryId = 1,
                    InStock = true,
                    ImageUrl = "https://www.topgear.com/sites/default/files/2023/09/33156-RS7PERFORMANCEASCARIBLUEJORDANBUTTERS132.jpg",
                    Description = "Blue color, Quattro all-wheel drive, Virtual Cockpit, Bang & Olufsen 3D Premium Sound System"
                },
                new Car()
                {
                    Id = 17,
                    Make = "Honda",
                    Model = "Accord",
                    Year = 2022,
                    Price = 32000,
                    Mileage = 8000,
                    Engine = "1.5L 4-cylinder",
                    Horsepower = 192,
                    CategoryId = 3,
                    InStock = true,
                    ImageUrl = "https://www.ixbt.com/img/n1/news/2023/1/2/2022-honda-accord-sport-2-0t-15_large.png",
                    Description = "Silver color, Automatic transmission, Honda Sensing Suite, Apple CarPlay, Android Auto"
                },
                new Car()
                {
                    Id = 18,
                    Make = "Jeep",
                    Model = "Grand Cherokee",
                    Year = 2021,
                    Price = 45000,
                    Mileage = 12000,
                    Engine = "3.6L V6",
                    Horsepower = 295,
                    CategoryId = 2,
                    InStock = true,
                    ImageUrl = "https://media.ed.edmunds-media.com/jeep/grand-cherokee/2021/oem/2021_jeep_grand-cherokee_4dr-suv_80th_fq_oem_1_1600.jpg",
                    Description = "White color, Automatic transmission, Uconnect Infotainment, Apple CarPlay, Android Auto"
                },
                new Car()
                {
                    Id = 19,
                    Make = "Lexus",
                    Model = "NX",
                    Year = 2020,
                    Price = 38000,
                    Mileage = 15000,
                    Engine = "2.0L 4-cylinder",
                    Horsepower = 235,
                    CategoryId = 2,
                    InStock = true,
                    ImageUrl = "https://i.infocar.ua/i/12/6078/1400x936.jpg",
                    Description = "Black color, Automatic transmission, Lexus Enform, Power Liftgate, Heated Front Seats"
                },
                new Car()
                {
                    Id = 20,
                    Make = "Porsche ",
                    Model = "911 Carrera 4S PDK",
                    Year = 2023,
                    Price = 202586,
                    Mileage = 1000,
                    Engine = "3.0L Flat-6 Turbo",
                    Horsepower = 450,
                    CategoryId = 1,
                    InStock = true,
                    ImageUrl = "https://car-images.bauersecure.com/wp-images/12872/1porschecarrera4scarreview.jpg",
                    Description = "Silver color, PDK transmission, Sport Chrono Package, Adaptive Sport Seats"
                },
                new Car()
                {
                    Id = 21,
                    Make = "Chevrolet",
                    Model = "Camaro",
                    Year = 2021,
                    Price = 45000,
                    Mileage = 8000,
                    Engine = "6.2L V8",
                    Horsepower = 455,
                    CategoryId = 3,
                    InStock = true,
                    ImageUrl = "https://hips.hearstapps.com/hmg-prod/images/2021-chevrolet-camaro-mmp-1-1585333717.jpg?crop=0.466xw:0.451xh;0.186xw,0.272xh&resize=1200:*",
                    Description = "Yellow color, Manual transmission, Performance Exhaust, Magnetic Ride Control, Launch Control"
                },
                new Car()
                {
                    Id = 22,
                    Make = "Audi",
                    Model = "A6",
                    Year = 2022,
                    Price = 55000,
                    Mileage = 12000,
                    Engine = "3.0L V6",
                    Horsepower = 335,
                    CategoryId = 1,
                    InStock = true,
                    ImageUrl = "https://audi.autoua.net/media/catalog/9/3/p1763493-1582023386.jpg",
                    Description = "Gray color, Automatic transmission, Virtual Cockpit, Bang & Olufsen Sound System, Heated Front Seats"
                },
                new Car()
                {
                    Id = 23,
                    Make = "Subaru",
                    Model = "Forester",
                    Year = 2022,
                    Price = 35000,
                    Mileage = 10000,
                    Engine = "2.5L 4-cylinder",
                    Horsepower = 182,
                    CategoryId = 3,
                    InStock = true,
                    ImageUrl = "https://www.autocentre.ua/wp-content/uploads/2021/06/2022-subaru-forester-jdm-2.jpg",
                    Description = "Green color, CVT transmission, EyeSight Driver Assist, Symmetrical All-Wheel Drive, X-Mode for Off-Road"
                },
                new Car()
                {
                    Id = 24,
                    Make = "Hyundai",
                    Model = "Santa Fe",
                    Year = 2021,
                    Price = 32000,
                    Mileage = 8000,
                    Engine = "2.5L 4-cylinder",
                    Horsepower = 191,
                    CategoryId = 3,
                    InStock = true,
                    ImageUrl = "https://i.infocar.ua/img/news-/148028/foto_003.jpg",
                    Description = "White color, Automatic transmission, Blind-Spot Collision-Avoidance Assist, Rear Occupant Alert, Android Auto"
                },
                new Car()
                {
                    Id = 25,
                    Make = "Kia",
                    Model = "Telluride",
                    Year = 2020,
                    Price = 42000,
                    Mileage = 10000,
                    Engine = "3.8L V6",
                    Horsepower = 291,
                    CategoryId = 2,
                    InStock = true,
                    ImageUrl = "https://media.ed.edmunds-media.com/kia/telluride/2020/oem/2020_kia_telluride_4dr-suv_sx_fq_oem_1_1600.jpg",
                    Description = "Black color, Automatic transmission, Blind Spot View Monitor, Apple CarPlay, Android Auto"
                },
                new Car()
                {
                    Id = 26,
                    Make = "sdfg",
                    Model = "sdg",
                    Year = 454,
                    Price = 456456,
                    Mileage = 456456,
                    Engine = "fgsd",
                    Horsepower = 6456,
                    CategoryId = 3,
                    InStock = true,
                    ImageUrl = "assets/images/car.jpg",
                    Description = ""
                },
                new Car()
                {
                    Id = 27,
                    Make = "Ford",
                    Model = "Escape",
                    Year = 2021,
                    Price = 30000,
                    Mileage = 12000,
                    Engine = "2.5L 4-cylinder Hybrid",
                    Horsepower = 200,
                    CategoryId = 3,
                    InStock = true,
                    ImageUrl = "https://hips.hearstapps.com/hmg-prod/images/2021-ford-escape-phev-108-1651779562.jpg?crop=0.843xw:0.631xh;0.0753xw,0.336xh&resize=1200:*",
                    Description = "Gray color, CVT transmission, Ford Co-Pilot360, Wireless Charging Pad, Hands-Free Liftgate"
                },
                new Car()
                {
                    Id = 28,
                    Make = "Mercedes-Benz",
                    Model = "S-Class",
                    Year = 2016,
                    Price = 48000,
                    Mileage = 100500,
                    Engine = "W222 • 550 Long G-tronic",
                    Horsepower = 455,
                    CategoryId = 1,
                    InStock = true,
                    ImageUrl = "https://www.jonathanmotorcars.com/imagetag/1318/main/l/Used-2016-Mercedes-Benz-S-Class-S-550-4MATIC-1623103884.jpg",
                    Description = "White color, AMG Line Exterior, Magic Body Control, MBUX Interior Assistant"
                },
                new Car()
                {
                    Id = 29,
                    Make = "BMW",
                    Model = "4 Series",
                    Year = 2021,
                    Price = 50000,
                    Mileage = 15000,
                    Engine = "2.0L 4-cylinder",
                    Horsepower = 255,
                    CategoryId = 1,
                    InStock = true,
                    ImageUrl = "https://www.cnet.com/a/img/resize/9250bb4d5b5023aaa610d205b47680689cb3835a/hub/2020/06/01/91c0b3b4-0010-4b21-bc33-0b1e2d1edf86/2021-bmw-4-series-038.jpg?auto=webp&width=1920",
                    Description = "Blue color, Automatic transmission, Apple CarPlay, Android Auto, Wireless Charging"
                },
                new Car()
                {
                    Id = 30,
                    Make = "Honda",
                    Model = "Accord",
                    Year = 2022,
                    Price = 32000,
                    Mileage = 8000,
                    Engine = "1.5L 4-cylinder",
                    Horsepower = 192,
                    CategoryId = 3,
                    InStock = true,
                    ImageUrl = "https://www.ixbt.com/img/n1/news/2023/1/2/2022-honda-accord-sport-2-0t-15_large.png",
                    Description = "Silver color, Automatic transmission, Honda Sensing Suite, Apple CarPlay, Android Auto"
                },
                new Car()
                {
                    Id = 31,
                    Make = "Volvo",
                    Model = "XC90",
                    Year = 2020,
                    Price = 55000,
                    Mileage = 15000,
                    Engine = "2.0L Inline-4 Turbo",
                    Horsepower = 407,
                    CategoryId = 4,
                    InStock = true,
                    ImageUrl = "https://resource.digitaldealer.com.au/image/2223556155f445be8e0656267031590_770_0-c.jpg",
                    Description = "Blue color, Automatic transmission, All-wheel drive, Leather interior, Bowers & Wilkins Premium Sound"
                },
                new Car()
                {
                    Id = 32,
                    Make = "Lexus",
                    Model = "NX",
                    Year = 2020,
                    Price = 38000,
                    Mileage = 15000,
                    Engine = "2.0L 4-cylinder",
                    Horsepower = 235,
                    CategoryId = 2,
                    InStock = true,
                    ImageUrl = "https://i.infocar.ua/i/12/6078/1400x936.jpg",
                    Description = "Black color, Automatic transmission, Lexus Enform, Power Liftgate, Heated Front Seats"
                },
                new Car()
                {
                    Id = 33,
                    Make = "Ford",
                    Model = "Explorer",
                    Year = 2022,
                    Price = 45000,
                    Mileage = 10000,
                    Engine = "2.3L 4-cylinder",
                    Horsepower = 300,
                    CategoryId = 3,
                    InStock = true,
                    ImageUrl = "https://fordmaster.com/upload/iblock/1e8/1e8262201ccfa5f479bef3a7b4020218.jpg",
                    Description = "Red color, Automatic transmission, Ford Co-Pilot360, Sync 4 Infotainment, Tri-Zone Climate Control"
                },
            });
        }
    }
}
