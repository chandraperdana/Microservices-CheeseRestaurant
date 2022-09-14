using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheese.Services.ProductAPI.Migrations
{
    public partial class changeSeed2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "Name",
                value: "Potato and pickle dippers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "Name",
                value: "Baked fondue with potato and pickle dippers");
        }
    }
}
