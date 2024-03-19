using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Wba.Liquor.Web.Migrations
{
    public partial class addOneToManyCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Boozes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Boozes_CategoryId",
                table: "Boozes",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Boozes_Categories_CategoryId",
                table: "Boozes",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Boozes_Categories_CategoryId",
                table: "Boozes");

            migrationBuilder.DropIndex(
                name: "IX_Boozes_CategoryId",
                table: "Boozes");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Boozes");
        }
    }
}
