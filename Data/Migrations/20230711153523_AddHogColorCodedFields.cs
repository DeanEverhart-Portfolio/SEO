using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEO.Data.Migrations
{
    public partial class AddHogColorCodedFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IntField1",
                table: "Hog",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IntField2",
                table: "Hog",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IntField3",
                table: "Hog",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StringField1",
                table: "Hog",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StringField2",
                table: "Hog",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StringField3",
                table: "Hog",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IntField1",
                table: "Hog");

            migrationBuilder.DropColumn(
                name: "IntField2",
                table: "Hog");

            migrationBuilder.DropColumn(
                name: "IntField3",
                table: "Hog");

            migrationBuilder.DropColumn(
                name: "StringField1",
                table: "Hog");

            migrationBuilder.DropColumn(
                name: "StringField2",
                table: "Hog");

            migrationBuilder.DropColumn(
                name: "StringField3",
                table: "Hog");
        }
    }
}
