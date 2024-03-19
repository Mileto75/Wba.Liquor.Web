using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Wba.Liquor.Web.Migrations
{
    public partial class addManyToManyPropertyBooze : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Boozes_Categories_CategoryId",
                table: "Boozes");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Boozes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "BoozeProperty",
                columns: table => new
                {
                    BoozesId = table.Column<int>(type: "int", nullable: false),
                    PropertiesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoozeProperty", x => new { x.BoozesId, x.PropertiesId });
                    table.ForeignKey(
                        name: "FK_BoozeProperty_Boozes_BoozesId",
                        column: x => x.BoozesId,
                        principalTable: "Boozes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BoozeProperty_Properties_PropertiesId",
                        column: x => x.PropertiesId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BoozeProperty_PropertiesId",
                table: "BoozeProperty",
                column: "PropertiesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Boozes_Categories_CategoryId",
                table: "Boozes",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Boozes_Categories_CategoryId",
                table: "Boozes");

            migrationBuilder.DropTable(
                name: "BoozeProperty");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Boozes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Boozes_Categories_CategoryId",
                table: "Boozes",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");
        }
    }
}
