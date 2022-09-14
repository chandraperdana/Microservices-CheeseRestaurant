using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheese.Services.ProductAPI.Migrations
{
    public partial class SeedProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Appetizer", "Cauli cheese. Arguably one of the heroes of British food. Is it really a roast dinner if there’s no super cheesy, crispy-topped, piping hot cauliflower cheese on the table? <br/> Easy to make, you may argue, but follow these handy hints and tips to make it unreal.", "https://chandraperdana.blob.core.windows.net/cheese/img2.jpg", "Cauliflower cheese", 150000.0 },
                    { 2, "Appetizer", "Stuffed with peppers, spices, potato, cheese and green chutney, chef Maunika Gowardhan's favourite cheese toastie is so very moreish.", "https://chandraperdana.blob.core.windows.net/cheese/img2.jpg", "Bombay chilli cheese toastie", 139900.0 },
                    { 3, "Dessert", "Three types of melted cheese, hot potatoes and little gherkins on sticks – what's not to love? This recipe has weekend written all over it.", "https://chandraperdana.blob.core.windows.net/cheese/img3.jpg", "Baked fondue with potato and pickle dippers", 109900.0 },
                    { 4, "Entree", "Ready-made puff pastry is used to make these easy cheese straws, ready on the table in just over half an hour.", "https://chandraperdana.blob.core.windows.net/cheese/img4.jpg", "Cheese straws", 150000.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);
        }
    }
}
