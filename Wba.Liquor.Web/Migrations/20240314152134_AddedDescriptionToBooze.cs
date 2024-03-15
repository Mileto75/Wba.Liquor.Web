using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Wba.Liquor.Web.Migrations
{
    public partial class AddedDescriptionToBooze : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Boozes",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Boozes");
        }
    }
}
