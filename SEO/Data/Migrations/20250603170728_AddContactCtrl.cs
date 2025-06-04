using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEO.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddContactCtrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    RecordDateInactive = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    IsClient = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ContactClient",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactId = table.Column<int>(type: "int", nullable: false),
                    Contact = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactClient", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContactClient_Contact_Contact",
                        column: x => x.Contact,
                        principalTable: "Contact",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Domain",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Protocol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subdomain = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Topleveldomain = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Domain", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Domain_Contact_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contact",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Ahref",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    domain = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    date = table.Column<DateTime>(type: "DateTime2", nullable: false),
                    value = table.Column<int>(type: "int", nullable: false),
                    stringValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DomainId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ahref", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ahref_Domain_DomainId",
                        column: x => x.DomainId,
                        principalTable: "Domain",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Hog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    run = table.Column<int>(type: "int", nullable: true),
                    stringRun = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rerun = table.Column<bool>(type: "bit", nullable: true),
                    stringRerun = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntField1 = table.Column<int>(type: "int", nullable: true),
                    StringField1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoolField1 = table.Column<bool>(type: "bit", nullable: true),
                    DateField1 = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    IntField2 = table.Column<int>(type: "int", nullable: true),
                    StringField2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoolField2 = table.Column<bool>(type: "bit", nullable: true),
                    DateField2 = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    IntField3 = table.Column<int>(type: "int", nullable: true),
                    StringField3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoolField3 = table.Column<bool>(type: "bit", nullable: true),
                    DateField3 = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    template = table.Column<int>(type: "int", nullable: true),
                    dateTemplate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    keyword = table.Column<bool>(type: "bit", nullable: true),
                    stringKeyword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    stringKeyword1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    content = table.Column<bool>(type: "bit", nullable: true),
                    content1 = table.Column<bool>(type: "bit", nullable: true),
                    content2 = table.Column<bool>(type: "bit", nullable: true),
                    dateContent = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    dateContent1 = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    dateContent2 = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    dateContent3 = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    stringContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    html = table.Column<bool>(type: "bit", nullable: true),
                    dateHtml = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    meta = table.Column<bool>(type: "bit", nullable: true),
                    stringMeta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dateMeta = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    seo = table.Column<bool>(type: "bit", nullable: true),
                    dateSeo = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    plugin = table.Column<bool>(type: "bit", nullable: true),
                    datePlugin = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    hero = table.Column<bool>(type: "bit", nullable: true),
                    hero1 = table.Column<bool>(type: "bit", nullable: true),
                    stringHero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dateHero = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    backup = table.Column<bool>(type: "bit", nullable: true),
                    stringBackup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dateBackup = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    buildExport = table.Column<bool>(type: "bit", nullable: true),
                    dateBuildExport = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    stringBuildExport = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hog1 = table.Column<bool>(type: "bit", nullable: true),
                    dateHog = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    stringHog = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    post = table.Column<bool>(type: "bit", nullable: true),
                    stringPost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    datePost = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    site = table.Column<bool>(type: "bit", nullable: true),
                    dateSite = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    stringSite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dev = table.Column<bool>(type: "bit", nullable: true),
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
                name: "IX_Ahref_DomainId",
                table: "Ahref",
                column: "DomainId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactClient_Contact",
                table: "ContactClient",
                column: "Contact");

            migrationBuilder.CreateIndex(
                name: "IX_Domain_ContactId",
                table: "Domain",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_Hog_DomainId",
                table: "Hog",
                column: "DomainId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ahref");

            migrationBuilder.DropTable(
                name: "ContactClient");

            migrationBuilder.DropTable(
                name: "Hog");

            migrationBuilder.DropTable(
                name: "Domain");

            migrationBuilder.DropTable(
                name: "Contact");
        }
    }
}
