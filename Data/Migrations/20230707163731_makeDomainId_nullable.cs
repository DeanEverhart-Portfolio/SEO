using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEO.Data.Migrations
{
    public partial class makeDomainId_nullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ahref_Domain_DomainId",
                table: "Ahref");

            migrationBuilder.AlterColumn<int>(
                name: "DomainId",
                table: "Ahref",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Ahref_Domain_DomainId",
                table: "Ahref",
                column: "DomainId",
                principalTable: "Domain",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ahref_Domain_DomainId",
                table: "Ahref");

            migrationBuilder.AlterColumn<int>(
                name: "DomainId",
                table: "Ahref",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Ahref_Domain_DomainId",
                table: "Ahref",
                column: "DomainId",
                principalTable: "Domain",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
