using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheese.Services.ShoppingCartAPI.Migrations
{
    public partial class changeColumnCartDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CarDetailsId",
                table: "CartDetails",
                newName: "CartDetailsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CartDetailsId",
                table: "CartDetails",
                newName: "CarDetailsId");
        }
    }
}
