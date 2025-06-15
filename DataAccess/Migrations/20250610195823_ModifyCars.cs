using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ModifyCars : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                keyValue: 26,
                columns: new[] { "CategoryId", "Description", "Engine", "Horsepower", "ImageUrl", "Make", "Mileage", "Model", "Price", "Year" },
                values: new object[] { 1, "White color, AMG Line Exterior, Magic Body Control, MBUX Interior Assistant", "W222 • 550 Long G-tronic", 455, "https://www.jonathanmotorcars.com/imagetag/1318/main/l/Used-2016-Mercedes-Benz-S-Class-S-550-4MATIC-1623103884.jpg", "Mercedes-Benz", 100500, "S-Class", 48000.0, 2016 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CategoryId", "Description", "Engine", "Horsepower", "ImageUrl", "Make", "Mileage", "Model", "Price" },
                values: new object[] { 1, "Blue color, Automatic transmission, Apple CarPlay, Android Auto, Wireless Charging", "2.0L 4-cylinder", 255, "https://www.cnet.com/a/img/resize/9250bb4d5b5023aaa610d205b47680689cb3835a/hub/2020/06/01/91c0b3b4-0010-4b21-bc33-0b1e2d1edf86/2021-bmw-4-series-038.jpg?auto=webp&width=1920", "BMW", 15000, "4 Series", 50000.0 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CategoryId", "Description", "Engine", "Horsepower", "ImageUrl", "Make", "Mileage", "Model", "Price", "Year" },
                values: new object[] { 4, "Blue color, Automatic transmission, All-wheel drive, Leather interior, Bowers & Wilkins Premium Sound", "2.0L Inline-4 Turbo", 407, "https://resource.digitaldealer.com.au/image/2223556155f445be8e0656267031590_770_0-c.jpg", "Volvo", 15000, "XC90", 55000.0, 2020 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CategoryId", "Description", "Horsepower", "ImageUrl", "Make", "Model", "Price", "Year" },
                values: new object[] { 2, "Black color, Automatic transmission, Lexus Enform, Power Liftgate, Heated Front Seats", 235, "https://i.infocar.ua/i/12/6078/1400x936.jpg", "Lexus", "NX", 38000.0, 2020 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Description", "Engine", "Horsepower", "ImageUrl", "Make", "Mileage", "Model", "Price" },
                values: new object[] { "Red color, Automatic transmission, Ford Co-Pilot360, Sync 4 Infotainment, Tri-Zone Climate Control", "2.3L 4-cylinder", 300, "https://fordmaster.com/upload/iblock/1e8/1e8262201ccfa5f479bef3a7b4020218.jpg", "Ford", 10000, "Explorer", 45000.0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CategoryId", "Description", "Engine", "Horsepower", "ImageUrl", "Make", "Mileage", "Model", "Price", "Year" },
                values: new object[] { 3, "", "fgsd", 6456, "assets/images/car.jpg", "sdfg", 456456, "sdg", 456456.0, 454 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CategoryId", "Description", "Engine", "Horsepower", "ImageUrl", "Make", "Mileage", "Model", "Price" },
                values: new object[] { 3, "Gray color, CVT transmission, Ford Co-Pilot360, Wireless Charging Pad, Hands-Free Liftgate", "2.5L 4-cylinder Hybrid", 200, "https://hips.hearstapps.com/hmg-prod/images/2021-ford-escape-phev-108-1651779562.jpg?crop=0.843xw:0.631xh;0.0753xw,0.336xh&resize=1200:*", "Ford", 12000, "Escape", 30000.0 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CategoryId", "Description", "Engine", "Horsepower", "ImageUrl", "Make", "Mileage", "Model", "Price", "Year" },
                values: new object[] { 1, "White color, AMG Line Exterior, Magic Body Control, MBUX Interior Assistant", "W222 • 550 Long G-tronic", 455, "https://www.jonathanmotorcars.com/imagetag/1318/main/l/Used-2016-Mercedes-Benz-S-Class-S-550-4MATIC-1623103884.jpg", "Mercedes-Benz", 100500, "S-Class", 48000.0, 2016 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CategoryId", "Description", "Horsepower", "ImageUrl", "Make", "Model", "Price", "Year" },
                values: new object[] { 1, "Blue color, Automatic transmission, Apple CarPlay, Android Auto, Wireless Charging", 255, "https://www.cnet.com/a/img/resize/9250bb4d5b5023aaa610d205b47680689cb3835a/hub/2020/06/01/91c0b3b4-0010-4b21-bc33-0b1e2d1edf86/2021-bmw-4-series-038.jpg?auto=webp&width=1920", "BMW", "4 Series", 50000.0, 2021 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Description", "Engine", "Horsepower", "ImageUrl", "Make", "Mileage", "Model", "Price" },
                values: new object[] { "Silver color, Automatic transmission, Honda Sensing Suite, Apple CarPlay, Android Auto", "1.5L 4-cylinder", 192, "https://www.ixbt.com/img/n1/news/2023/1/2/2022-honda-accord-sport-2-0t-15_large.png", "Honda", 8000, "Accord", 32000.0 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CategoryId", "Description", "Engine", "Horsepower", "ImageUrl", "InStock", "Make", "Mileage", "Model", "Price", "Year" },
                values: new object[,]
                {
                    { 31, 4, "Blue color, Automatic transmission, All-wheel drive, Leather interior, Bowers & Wilkins Premium Sound", "2.0L Inline-4 Turbo", 407, "https://resource.digitaldealer.com.au/image/2223556155f445be8e0656267031590_770_0-c.jpg", true, "Volvo", 15000, "XC90", 55000.0, 2020 },
                    { 32, 2, "Black color, Automatic transmission, Lexus Enform, Power Liftgate, Heated Front Seats", "2.0L 4-cylinder", 235, "https://i.infocar.ua/i/12/6078/1400x936.jpg", true, "Lexus", 15000, "NX", 38000.0, 2020 },
                    { 33, 3, "Red color, Automatic transmission, Ford Co-Pilot360, Sync 4 Infotainment, Tri-Zone Climate Control", "2.3L 4-cylinder", 300, "https://fordmaster.com/upload/iblock/1e8/1e8262201ccfa5f479bef3a7b4020218.jpg", true, "Ford", 10000, "Explorer", 45000.0, 2022 }
                });
        }
    }
}
