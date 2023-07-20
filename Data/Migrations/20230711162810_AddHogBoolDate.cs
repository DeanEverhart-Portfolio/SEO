using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEO.Data.Migrations
{
    public partial class AddHogBoolDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BoolField1",
                table: "Hog",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BoolField2",
                table: "Hog",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BoolField3",
                table: "Hog",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateField1",
                table: "Hog",
                type: "DateTime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateField2",
                table: "Hog",
                type: "DateTime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateField3",
                table: "Hog",
                type: "DateTime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BoolField1",
                table: "Hog");

            migrationBuilder.DropColumn(
                name: "BoolField2",
                table: "Hog");

            migrationBuilder.DropColumn(
                name: "BoolField3",
                table: "Hog");

            migrationBuilder.DropColumn(
                name: "DateField1",
                table: "Hog");

            migrationBuilder.DropColumn(
                name: "DateField2",
                table: "Hog");

            migrationBuilder.DropColumn(
                name: "DateField3",
                table: "Hog");
        }
    }
}
