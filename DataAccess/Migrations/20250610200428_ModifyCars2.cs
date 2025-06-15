using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ModifyCars2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19,
                column: "ImageUrl",
                value: "https://carsguide-res.cloudinary.com/image/upload/c_fit,h_841,w_1490,f_auto,t_cg_base/v1/editorial/2020-Lexus-NX-300h-F-Sport-1001x565-(2).jpg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CategoryId", "Description", "Engine", "Horsepower", "ImageUrl", "Make", "Mileage", "Model", "Price", "Year" },
                values: new object[] { 3, "Red color, Automatic transmission, Ford Co-Pilot360, Sync 4 Infotainment, Tri-Zone Climate Control", "2.3L 4-cylinder", 300, "https://media.ed.edmunds-media.com/ford/explorer/2020/oem/2020_ford_explorer_4dr-suv_limited-hybrid_fq_oem_1_1600.jpg", "Ford", 10000, "Explorer", 45000.0, 2022 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19,
                column: "ImageUrl",
                value: "https://i.infocar.ua/i/12/6078/1400x936.jpg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CategoryId", "Description", "Engine", "Horsepower", "ImageUrl", "Make", "Mileage", "Model", "Price", "Year" },
                values: new object[] { 2, "Black color, Automatic transmission, Lexus Enform, Power Liftgate, Heated Front Seats", "2.0L 4-cylinder", 235, "https://i.infocar.ua/i/12/6078/1400x936.jpg", "Lexus", 15000, "NX", 38000.0, 2020 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CategoryId", "Description", "Engine", "Horsepower", "ImageUrl", "InStock", "Make", "Mileage", "Model", "Price", "Year" },
                values: new object[] { 30, 3, "Red color, Automatic transmission, Ford Co-Pilot360, Sync 4 Infotainment, Tri-Zone Climate Control", "2.3L 4-cylinder", 300, "https://fordmaster.com/upload/iblock/1e8/1e8262201ccfa5f479bef3a7b4020218.jpg", true, "Ford", 10000, "Explorer", 45000.0, 2022 });
        }
    }
}
