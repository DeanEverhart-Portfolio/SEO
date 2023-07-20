using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEO.Data.Migrations
{
    public partial class CreateHogAhrefs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContactClient_Contact_ContactId",
                table: "ContactClient");

            migrationBuilder.DropIndex(
                name: "IX_ContactClient_ContactId",
                table: "ContactClient");

            migrationBuilder.AddColumn<int>(
                name: "Contact",
                table: "ContactClient",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Ahref",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    domain = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    date = table.Column<DateTime>(type: "DateTime2", nullable: false),
                    value = table.Column<int>(type: "int", nullable: false),
                    stringValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DomainId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ahref", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ahref_Domain_DomainId",
                        column: x => x.DomainId,
                        principalTable: "Domain",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    run = table.Column<int>(type: "int", nullable: false),
                    stringRun = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    rerun = table.Column<bool>(type: "bit", nullable: false),
                    stringRerun = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    template = table.Column<int>(type: "int", nullable: false),
                    dateTemplate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    keyword = table.Column<bool>(type: "bit", nullable: false),
                    stringKeyword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    stringKeyword1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    content = table.Column<bool>(type: "bit", nullable: false),
                    content1 = table.Column<bool>(type: "bit", nullable: false),
                    content2 = table.Column<bool>(type: "bit", nullable: false),
                    dateContent = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    dateContent1 = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    dateContent2 = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    dateContent3 = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    stringContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    html = table.Column<bool>(type: "bit", nullable: false),
                    dateHtml = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    meta = table.Column<bool>(type: "bit", nullable: false),
                    stringMeta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateMeta = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    seo = table.Column<bool>(type: "bit", nullable: false),
                    dateSeo = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    plugin = table.Column<bool>(type: "bit", nullable: false),
                    datePlugin = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    hero = table.Column<bool>(type: "bit", nullable: false),
                    hero1 = table.Column<bool>(type: "bit", nullable: false),
                    stringHero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateHero = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    backup = table.Column<bool>(type: "bit", nullable: false),
                    stringBackup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateBackup = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    buildExport = table.Column<bool>(type: "bit", nullable: false),
                    dateBuildExport = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    stringBuildExport = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hog1 = table.Column<bool>(type: "bit", nullable: false),
                    dateHog = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    stringHog = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    post = table.Column<bool>(type: "bit", nullable: false),
                    stringPost = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    datePost = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    site = table.Column<bool>(type: "bit", nullable: false),
                    dateSite = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    stringSite = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dev = table.Column<bool>(type: "bit", nullable: false),
                    hogOld = table.Column<int>(type: "int", nullable: true),
                    DomainId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hog_Domain_DomainId",
                        column: x => x.DomainId,
                        principalTable: "Domain",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContactClient_Contact",
                table: "ContactClient",
                column: "Contact");

            migrationBuilder.CreateIndex(
                name: "IX_Ahref_DomainId",
                table: "Ahref",
                column: "DomainId");

            migrationBuilder.CreateIndex(
                name: "IX_Hog_DomainId",
                table: "Hog",
                column: "DomainId");

            migrationBuilder.AddForeignKey(
                name: "FK_ContactClient_Contact_Contact",
                table: "ContactClient",
                column: "Contact",
                principalTable: "Contact",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContactClient_Contact_Contact",
                table: "ContactClient");

            migrationBuilder.DropTable(
                name: "Ahref");

            migrationBuilder.DropTable(
                name: "Hog");

            migrationBuilder.DropIndex(
                name: "IX_ContactClient_Contact",
                table: "ContactClient");

            migrationBuilder.DropColumn(
                name: "Contact",
                table: "ContactClient");

            migrationBuilder.CreateIndex(
                name: "IX_ContactClient_ContactId",
                table: "ContactClient",
                column: "ContactId");

            migrationBuilder.AddForeignKey(
                name: "FK_ContactClient_Contact_ContactId",
                table: "ContactClient",
                column: "ContactId",
                principalTable: "Contact",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
