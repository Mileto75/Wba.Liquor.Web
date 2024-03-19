using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Wba.Liquor.Web.Migrations
{
    public partial class addOneToManyBrand : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BrandId",
                table: "Boozes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Boozes_BrandId",
                table: "Boozes",
                column: "BrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_Boozes_Brands_BrandId",
                table: "Boozes",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Boozes_Brands_BrandId",
                table: "Boozes");

            migrationBuilder.DropIndex(
                name: "IX_Boozes_BrandId",
                table: "Boozes");

            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "Boozes");
        }
    }
}
