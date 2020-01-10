using Microsoft.EntityFrameworkCore.Migrations;

namespace EcommerceApp.Migrations
{
    public partial class pagemigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pages_Users_UsersPageUserId",
                table: "Pages");

            migrationBuilder.DropIndex(
                name: "IX_Pages_UsersPageUserId",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "UsersPageUserId",
                table: "Pages");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Pages",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pages_UserId",
                table: "Pages",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pages_Users_UserId",
                table: "Pages",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pages_Users_UserId",
                table: "Pages");

            migrationBuilder.DropIndex(
                name: "IX_Pages_UserId",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Pages");

            migrationBuilder.AddColumn<int>(
                name: "UsersPageUserId",
                table: "Pages",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pages_UsersPageUserId",
                table: "Pages",
                column: "UsersPageUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pages_Users_UsersPageUserId",
                table: "Pages",
                column: "UsersPageUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
