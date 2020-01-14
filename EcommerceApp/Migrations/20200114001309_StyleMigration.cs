using Microsoft.EntityFrameworkCore.Migrations;

namespace EcommerceApp.Migrations
{
    public partial class StyleMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StyleId",
                table: "SubStyles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SubStyles_StyleId",
                table: "SubStyles",
                column: "StyleId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubStyles_Styles_StyleId",
                table: "SubStyles",
                column: "StyleId",
                principalTable: "Styles",
                principalColumn: "StyleId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubStyles_Styles_StyleId",
                table: "SubStyles");

            migrationBuilder.DropIndex(
                name: "IX_SubStyles_StyleId",
                table: "SubStyles");

            migrationBuilder.DropColumn(
                name: "StyleId",
                table: "SubStyles");
        }
    }
}
