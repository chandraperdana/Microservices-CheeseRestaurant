using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheese.Services.CouponAPI.Migrations
{
    public partial class changeColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CouponName",
                table: "Coupons",
                newName: "CouponCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CouponCode",
                table: "Coupons",
                newName: "CouponName");
        }
    }
}
