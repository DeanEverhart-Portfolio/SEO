using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEO.Data.Migrations
{
    public partial class add_contactsclienttable2233 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContactClient_Contact_Contact",
                table: "ContactClient");

            migrationBuilder.AlterColumn<int>(
                name: "Contact",
                table: "ContactClient",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ContactClient_Contact_Contact",
                table: "ContactClient",
                column: "Contact",
                principalTable: "Contact",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContactClient_Contact_Contact",
                table: "ContactClient");

            migrationBuilder.AlterColumn<int>(
                name: "Contact",
                table: "ContactClient",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ContactClient_Contact_Contact",
                table: "ContactClient",
                column: "Contact",
                principalTable: "Contact",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
