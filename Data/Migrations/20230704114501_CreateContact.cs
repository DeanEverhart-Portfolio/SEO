using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEO.Data.Migrations
{
    public partial class CreateContact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientDesignator = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Company2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Company3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstNamePreference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pronouns = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AreaCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prefix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Line = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Extension = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneLabel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gatekeeper = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GatekeeperNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneSort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AreaCode2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prefix2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Line2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Extension2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone2Label = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gatekeeper2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gatekeeper2Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone2Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone2Sort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AreaCode3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prefix3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Line3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Extension3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone3Label = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gatekeeper3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gatekeeper3Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone3Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone3Sort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailLabel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailSort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email21Label = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email2Sort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email2Label = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email3Sort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Domain = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Domain1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WebsiteLabel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Website2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Website2Label = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Website3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Website3Label = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StreetNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StreetName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StreetDesignator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TownCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Map = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Doh = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    Hold = table.Column<bool>(type: "bit", nullable: true),
                    DateHold = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    Dos = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    Tier1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rank1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecordFlag = table.Column<bool>(type: "bit", nullable: true),
                    RecordFlagString = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecordFlag1 = table.Column<bool>(type: "bit", nullable: true),
                    RecordFlag1String = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecordNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecordNote1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecordSelect = table.Column<bool>(type: "bit", nullable: true),
                    RecordSelect1 = table.Column<bool>(type: "bit", nullable: true),
                    RecordCreated = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    RecordInactive = table.Column<bool>(type: "bit", nullable: true),
                    RecordDateInactive = table.Column<DateTime>(type: "DateTime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Domain",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Domain", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Domain_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientContact",
                columns: table => new
                {
                    ClientsId = table.Column<int>(type: "int", nullable: false),
                    ContactsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientContact", x => new { x.ClientsId, x.ContactsID });
                    table.ForeignKey(
                        name: "FK_ClientContact_Client_ClientsId",
                        column: x => x.ClientsId,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientContact_Contact_ContactsID",
                        column: x => x.ContactsID,
                        principalTable: "Contact",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContactClient",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactId = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false)
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
                        name: "FK_ContactClient_Contact_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contact",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClientContact_ContactsID",
                table: "ClientContact",
                column: "ContactsID");

            migrationBuilder.CreateIndex(
                name: "IX_ContactClient_ClientId",
                table: "ContactClient",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactClient_ContactId",
                table: "ContactClient",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_Domain_ClientId",
                table: "Domain",
                column: "ClientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientContact");

            migrationBuilder.DropTable(
                name: "ContactClient");

            migrationBuilder.DropTable(
                name: "Domain");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "Client");
        }
    }
}
