using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheese.Services.CouponAPI.Migrations
{
    public partial class updateSeedCoupon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "CouponId",
                keyValue: 1,
                column: "DiscountAmount",
                value: 10000.0);

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "CouponId",
                keyValue: 2,
                column: "DiscountAmount",
                value: 20000.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "CouponId",
                keyValue: 1,
                column: "DiscountAmount",
                value: 10.0);

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "CouponId",
                keyValue: 2,
                column: "DiscountAmount",
                value: 20.0);
        }
    }
}
