using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EcommerceApp.Migrations
{
    public partial class addingdesign : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubStyles");

            migrationBuilder.AddColumn<int>(
                name: "DesignId",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Designs",
                columns: table => new
                {
                    DesignId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Image = table.Column<string>(nullable: true),
                    PromoTime = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Designs", x => x.DesignId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_DesignId",
                table: "Products",
                column: "DesignId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Designs_DesignId",
                table: "Products",
                column: "DesignId",
                principalTable: "Designs",
                principalColumn: "DesignId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Designs_DesignId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Designs");

            migrationBuilder.DropIndex(
                name: "IX_Products_DesignId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DesignId",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "SubStyles",
                columns: table => new
                {
                    SubStyleyId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    StyleId = table.Column<int>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubStyles", x => x.SubStyleyId);
                    table.ForeignKey(
                        name: "FK_SubStyles_Styles_StyleId",
                        column: x => x.StyleId,
                        principalTable: "Styles",
                        principalColumn: "StyleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubStyles_StyleId",
                table: "SubStyles",
                column: "StyleId");
        }
    }
}
