using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Products",
                newName: "Model");

            migrationBuilder.RenameColumn(
                name: "Discount",
                table: "Products",
                newName: "Year");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 5,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 9);

            migrationBuilder.AddColumn<string>(
                name: "Engine",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Horsepower",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Make",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Mileage",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Gasoline");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Diesel");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Hybrid");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Electric");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "Description", "Engine", "Horsepower", "ImageUrl", "InStock", "Make", "Mileage", "Model", "Price", "Year" },
                values: new object[] { 3, "Silver color, Automatic transmission, Bluetooth, Backup Camera, Keyless Entry", "2.0L 4-cylinder", 169, "https://today.ua/wp-content/uploads/2021/12/Toyota-Corolla-1.jpg", true, "Toyota", 20000, "Corolla", 25000m, 2022 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "Description", "Engine", "Horsepower", "ImageUrl", "InStock", "Make", "Mileage", "Model", "Price", "Year" },
                values: new object[] { 3, "Red color, Manual transmission, Leather Seats, Navigation System, Heated Seats", "5.0L V8", 450, "https://img.automoto.ua/overview/ford-mustang-2020-3fd-huge-1564.jpg", true, "Ford", 15000, "Mustang", 35000m, 2020 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "Description", "Engine", "Horsepower", "ImageUrl", "Make", "Mileage", "Model", "Price", "Year" },
                values: new object[] { 1, "White color, Automatic transmission, Sunroof, Adaptive Cruise Control, Parking Assistance", "2.0L 4-cylinder", 255, "https://hips.hearstapps.com/hmg-prod/images/2021-bmw-3-series-mmp-1-1593549868.jpg", "BMW", 12000, "3 Series", 40000m, 2021 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "Description", "Engine", "Horsepower", "ImageUrl", "Make", "Mileage", "Model", "Price", "Year" },
                values: new object[] { 2, "Red color, Automatic transmission, Autopilot, Full Self-Driving Capability, Premium Audio System", "Electric Motor", 322, "https://cdn0.riastatic.com/photosnew/auto/photo/tesla_model-3__518635415f.jpg", "Tesla", 8000, "Model 3", 45000m, 2022 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "Description", "Engine", "Horsepower", "ImageUrl", "InStock", "Make", "Mileage", "Model", "Price", "Year" },
                values: new object[] { 3, "Gray color, Automatic transmission, Virtual Cockpit, Panoramic Sunroof, Apple CarPlay", "2.0L 4-cylinder", 248, "https://i.infocar.ua/i/12/6234/1400x936.jpg", true, "Audi", 15000, "Q5", 38000m, 2021 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "Description", "Engine", "Horsepower", "ImageUrl", "Make", "Mileage", "Model", "Price", "Year" },
                values: new object[] { 3, "Silver color, Automatic transmission, MBUX Infotainment, Heated Steering Wheel, Air Suspension", "2.0L 4-cylinder", 255, "https://i.infocar.ua/i/2/6241/118625/1024x.jpg", "Mercedes-Benz", 18000, "E-Class", 42000m, 2020 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Engine",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Horsepower",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Make",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Mileage",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "Year",
                table: "Products",
                newName: "Discount");

            migrationBuilder.RenameColumn(
                name: "Model",
                table: "Products",
                newName: "Name");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 9,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 5);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Electronics");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Sport");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Fashion");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Home & Garden");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 5, "Transport" },
                    { 6, "Toys & Hobbies" },
                    { 7, "Musical Instruments" },
                    { 8, "Art" },
                    { 9, "Other" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "Description", "Discount", "ImageUrl", "InStock", "Name", "Price" },
                values: new object[] { 1, null, 10, "https://applecity.com.ua/image/cache/catalog/0iphone/ipohnex/iphone-x-black-1000x1000.png", false, "iPhone X", 650m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "Description", "Discount", "ImageUrl", "InStock", "Name", "Price" },
                values: new object[] { 2, null, 0, "https://http2.mlstatic.com/D_NQ_NP_727192-CBT53879999753_022023-V.jpg", false, "PowerBall", 45.5m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "Description", "Discount", "ImageUrl", "Name", "Price" },
                values: new object[] { 3, null, 15, "https://www.seekpng.com/png/detail/316-3168852_nike-air-logo-t-shirt-nike-t-shirt.png", "Nike T-Shirt", 189m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "Description", "Discount", "ImageUrl", "Name", "Price" },
                values: new object[] { 1, null, 5, "https://sota.kh.ua/image/cache/data/Samsung-2/samsung-s23-s23plus-blk-01-700x700.webp", "Samsung S23", 1200m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "Description", "Discount", "ImageUrl", "InStock", "Name", "Price" },
                values: new object[] { 6, null, 0, "https://cdn.shopify.com/s/files/1/0046/1163/7320/products/69ee701e-e806-4c4d-b804-d53dc1f0e11a_grande.jpg", false, "Air Ball", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "Description", "Discount", "ImageUrl", "Name", "Price" },
                values: new object[] { 1, null, 10, "https://newtime.ua/image/import/catalog/mac/macbook_pro/MacBook-Pro-16-2019/MacBook-Pro-16-Space-Gray-2019/MacBook-Pro-16-Space-Gray-00.webp", "MacBook Pro 2019", 1200m });
        }
    }
}
