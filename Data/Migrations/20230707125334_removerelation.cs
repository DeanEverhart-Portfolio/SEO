using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEO.Data.Migrations
{
    public partial class removerelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactClient");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContactClient",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    Contact = table.Column<int>(type: "int", nullable: false),
                    ContactId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactClient", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContactClient_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContactClient_Contact_Contact",
                        column: x => x.Contact,
                        principalTable: "Contact",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContactClient_ClientId",
                table: "ContactClient",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactClient_Contact",
                table: "ContactClient",
                column: "Contact");
        }
    }
}
