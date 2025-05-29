using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreCars : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "CategoryId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "CategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "CategoryId",
                value: 1);

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CategoryId", "Description", "Engine", "Horsepower", "ImageUrl", "InStock", "Make", "Mileage", "Model", "Price", "Year" },
                values: new object[,]
                {
                    { 7, 3, "Black color, Automatic transmission, Leather Seats, Captain's Chairs, Wireless Charging", "5.3L V8", 355, "https://i.infocar.ua/i/12/6229/1200x630.jpg", true, "Chevrolet", 25000, "Tahoe", 55000.0, 2020 },
                    { 8, 2, "Silver color, Automatic transmission, Leather Seats, Panoramic Roof, Power Liftgate", "3.5L V6", 295, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ37JJrfO9luseU6bzVX5qjWfk5hvyF1QaaKROr4zfrBA&s", true, "Lexus", 20000, "RX 350", 42000.0, 2020 },
                    { 9, 3, "Blue color, Automatic transmission, Towing Package, Tailgate Step, Pro Trailer Backup Assist", "3.5L V6", 375, "https://i.infocar.ua/i/2/6467/122061/1920x.jpg", true, "Ford", 15000, "F-150", 45000.0, 2021 },
                    { 10, 1, "Black color, Automatic transmission, Heads-Up Display, Gesture Control, Wireless Charging", "3.0L 6-cylinder", 335, "https://img.automoto.ua/overview/bmw-x5-2021-e98-huge-1897.jpg", true, "BMW", 10000, "X5", 60000.0, 2021 },
                    { 11, 3, "Blue color, Automatic transmission, Toyota Safety Sense, Apple CarPlay, Android Auto", "2.5L 4-cylinder", 203, "https://hips.hearstapps.com/hmg-prod/images/2020-toyota-rav4-mmp-1-1570472132.jpg", true, "Toyota", 18000, "RAV4", 32000.0, 2020 },
                    { 12, 4, "White color, Automatic transmission, Autopilot, Full Self-Driving Capability, Panoramic Glass Roof", "Electric Motor", 384, "https://wah.ua/static/content/thumbs/744*496/4/20/dsxi56-8cff2f0dc3ae189e43186c5bcca08204.jpeg", true, "Tesla", 6000, "Model Y", 55000.0, 2022 },
                    { 13, 3, "Red color, Automatic transmission, Trailer Sway Control, Apple CarPlay, Android Auto", "5.3L V8", 355, "https://cdn.motor1.com/images/mgl/EBx7o/s1/2019-chevrolet-silverado-trail-boss.jpg", true, "Chevrolet", 25000, "Silverado", 38000.0, 2020 },
                    { 14, 3, "Gray color, CVT transmission, Ford Co-Pilot360, Wireless Charging Pad, Hands-Free Liftgate", "2.5L 4-cylinder Hybrid", 200, "https://hips.hearstapps.com/hmg-prod/images/2021-ford-escape-phev-108-1651779562.jpg?crop=0.843xw:0.631xh;0.0753xw,0.336xh&resize=1200:*", true, "Ford", 12000, "Escape", 30000.0, 2021 },
                    { 15, 1, "Black color, Automatic transmission, MBUX Infotainment, Panoramic Sunroof, Heated Seats", "2.0L 4-cylinder", 255, "https://lh6.googleusercontent.com/proxy/IqRMJz8oK5fas4AlZXL8mGS_JsFgrKlHHASXVHuwjhEzpYDjkZOjiBP9OEeMoXAEm8VhkWBgcLWfrc27H6ma08Q8UfYD-QQyR9WGiocdTlJ4rD629pY3-rQW3v2404pCY2YM6vLP42cH9I7-xw", true, "Mercedes-Benz", 10000, "GLC", 48000.0, 2021 },
                    { 16, 1, "Blue color, Quattro all-wheel drive, Virtual Cockpit, Bang & Olufsen 3D Premium Sound System", "4.0L V8 Twin-Turbo", 591, "https://www.topgear.com/sites/default/files/2023/09/33156-RS7PERFORMANCEASCARIBLUEJORDANBUTTERS132.jpg", true, "Audi", 8000, "RS 7", 110000.0, 2023 },
                    { 17, 3, "Silver color, Automatic transmission, Honda Sensing Suite, Apple CarPlay, Android Auto", "1.5L 4-cylinder", 192, "https://www.ixbt.com/img/n1/news/2023/1/2/2022-honda-accord-sport-2-0t-15_large.png", true, "Honda", 8000, "Accord", 32000.0, 2022 },
                    { 18, 2, "White color, Automatic transmission, Uconnect Infotainment, Apple CarPlay, Android Auto", "3.6L V6", 295, "https://media.ed.edmunds-media.com/jeep/grand-cherokee/2021/oem/2021_jeep_grand-cherokee_4dr-suv_80th_fq_oem_1_1600.jpg", true, "Jeep", 12000, "Grand Cherokee", 45000.0, 2021 },
                    { 19, 2, "Black color, Automatic transmission, Lexus Enform, Power Liftgate, Heated Front Seats", "2.0L 4-cylinder", 235, "https://i.infocar.ua/i/12/6078/1400x936.jpg", true, "Lexus", 15000, "NX", 38000.0, 2020 },
                    { 20, 1, "Silver color, PDK transmission, Sport Chrono Package, Adaptive Sport Seats", "3.0L Flat-6 Turbo", 450, "https://car-images.bauersecure.com/wp-images/12872/1porschecarrera4scarreview.jpg", true, "Porsche ", 1000, "911 Carrera 4S PDK", 202586.0, 2023 },
                    { 21, 3, "Yellow color, Manual transmission, Performance Exhaust, Magnetic Ride Control, Launch Control", "6.2L V8", 455, "https://hips.hearstapps.com/hmg-prod/images/2021-chevrolet-camaro-mmp-1-1585333717.jpg?crop=0.466xw:0.451xh;0.186xw,0.272xh&resize=1200:*", true, "Chevrolet", 8000, "Camaro", 45000.0, 2021 },
                    { 22, 1, "Gray color, Automatic transmission, Virtual Cockpit, Bang & Olufsen Sound System, Heated Front Seats", "3.0L V6", 335, "https://audi.autoua.net/media/catalog/9/3/p1763493-1582023386.jpg", true, "Audi", 12000, "A6", 55000.0, 2022 },
                    { 23, 3, "Green color, CVT transmission, EyeSight Driver Assist, Symmetrical All-Wheel Drive, X-Mode for Off-Road", "2.5L 4-cylinder", 182, "https://www.autocentre.ua/wp-content/uploads/2021/06/2022-subaru-forester-jdm-2.jpg", true, "Subaru", 10000, "Forester", 35000.0, 2022 },
                    { 24, 3, "White color, Automatic transmission, Blind-Spot Collision-Avoidance Assist, Rear Occupant Alert, Android Auto", "2.5L 4-cylinder", 191, "https://i.infocar.ua/img/news-/148028/foto_003.jpg", true, "Hyundai", 8000, "Santa Fe", 32000.0, 2021 },
                    { 25, 2, "Black color, Automatic transmission, Blind Spot View Monitor, Apple CarPlay, Android Auto", "3.8L V6", 291, "https://media.ed.edmunds-media.com/kia/telluride/2020/oem/2020_kia_telluride_4dr-suv_sx_fq_oem_1_1600.jpg", true, "Kia", 10000, "Telluride", 42000.0, 2020 },
                    { 26, 3, "", "fgsd", 6456, "assets/images/car.jpg", true, "sdfg", 456456, "sdg", 456456.0, 454 },
                    { 27, 3, "Gray color, CVT transmission, Ford Co-Pilot360, Wireless Charging Pad, Hands-Free Liftgate", "2.5L 4-cylinder Hybrid", 200, "https://hips.hearstapps.com/hmg-prod/images/2021-ford-escape-phev-108-1651779562.jpg?crop=0.843xw:0.631xh;0.0753xw,0.336xh&resize=1200:*", true, "Ford", 12000, "Escape", 30000.0, 2021 },
                    { 28, 1, "White color, AMG Line Exterior, Magic Body Control, MBUX Interior Assistant", "W222 • 550 Long G-tronic", 455, "https://www.jonathanmotorcars.com/imagetag/1318/main/l/Used-2016-Mercedes-Benz-S-Class-S-550-4MATIC-1623103884.jpg", true, "Mercedes-Benz", 100500, "S-Class", 48000.0, 2016 },
                    { 29, 1, "Blue color, Automatic transmission, Apple CarPlay, Android Auto, Wireless Charging", "2.0L 4-cylinder", 255, "https://www.cnet.com/a/img/resize/9250bb4d5b5023aaa610d205b47680689cb3835a/hub/2020/06/01/91c0b3b4-0010-4b21-bc33-0b1e2d1edf86/2021-bmw-4-series-038.jpg?auto=webp&width=1920", true, "BMW", 15000, "4 Series", 50000.0, 2021 },
                    { 30, 3, "Silver color, Automatic transmission, Honda Sensing Suite, Apple CarPlay, Android Auto", "1.5L 4-cylinder", 192, "https://www.ixbt.com/img/n1/news/2023/1/2/2022-honda-accord-sport-2-0t-15_large.png", true, "Honda", 8000, "Accord", 32000.0, 2022 },
                    { 31, 4, "Blue color, Automatic transmission, All-wheel drive, Leather interior, Bowers & Wilkins Premium Sound", "2.0L Inline-4 Turbo", 407, "https://resource.digitaldealer.com.au/image/2223556155f445be8e0656267031590_770_0-c.jpg", true, "Volvo", 15000, "XC90", 55000.0, 2020 },
                    { 32, 2, "Black color, Automatic transmission, Lexus Enform, Power Liftgate, Heated Front Seats", "2.0L 4-cylinder", 235, "https://i.infocar.ua/i/12/6078/1400x936.jpg", true, "Lexus", 15000, "NX", 38000.0, 2020 },
                    { 33, 3, "Red color, Automatic transmission, Ford Co-Pilot360, Sync 4 Infotainment, Tri-Zone Climate Control", "2.3L 4-cylinder", 300, "https://fordmaster.com/upload/iblock/1e8/1e8262201ccfa5f479bef3a7b4020218.jpg", true, "Ford", 10000, "Explorer", 45000.0, 2022 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "CategoryId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "CategoryId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "CategoryId",
                value: 3);
        }
    }
}
