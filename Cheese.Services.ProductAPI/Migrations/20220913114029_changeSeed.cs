using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheese.Services.ProductAPI.Migrations
{
    public partial class changeSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Asperiores, recusandae suscipit. Eius porro vitae nihil? Velit quaerat architecto at labore voluptatum veritatis exercitationem quis itaque.", "https://chandraperdana.blob.core.windows.net/cheese/img1.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "Description",
                value: "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Asperiores, recusandae suscipit. Eius porro vitae nihil? Velit quaerat architecto at labore voluptatum veritatis exercitationem quis itaque.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "Description",
                value: "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Asperiores, recusandae suscipit. Eius porro vitae nihil? Velit quaerat architecto at labore voluptatum veritatis exercitationem quis itaque.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "Description",
                value: "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Asperiores, recusandae suscipit. Eius porro vitae nihil? Velit quaerat architecto at labore voluptatum veritatis exercitationem quis itaque.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Cauli cheese. Arguably one of the heroes of British food. Is it really a roast dinner if there’s no super cheesy, crispy-topped, piping hot cauliflower cheese on the table? <br/> Easy to make, you may argue, but follow these handy hints and tips to make it unreal.", "https://chandraperdana.blob.core.windows.net/cheese/img2.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "Description",
                value: "Stuffed with peppers, spices, potato, cheese and green chutney, chef Maunika Gowardhan's favourite cheese toastie is so very moreish.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "Description",
                value: "Three types of melted cheese, hot potatoes and little gherkins on sticks – what's not to love? This recipe has weekend written all over it.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "Description",
                value: "Ready-made puff pastry is used to make these easy cheese straws, ready on the table in just over half an hour.");
        }
    }
}
