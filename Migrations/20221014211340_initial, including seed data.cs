using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myspace.Migrations
{
    public partial class initialincludingseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ContactTemplates",
                columns: table => new
                {
                    ContactTemplateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Greeting = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BodyText = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactTemplates", x => x.ContactTemplateId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.PersonId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    TagId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Text = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.TagId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ContactEvents",
                columns: table => new
                {
                    ContactEventId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Medium = table.Column<int>(type: "int", nullable: false),
                    DateTimeOccurred = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Impression = table.Column<int>(type: "int", nullable: false),
                    NeedsFollowUp = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ContactTemplateID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactEvents", x => x.ContactEventId);
                    table.ForeignKey(
                        name: "FK_ContactEvents_ContactTemplates_ContactTemplateID",
                        column: x => x.ContactTemplateID,
                        principalTable: "ContactTemplates",
                        principalColumn: "ContactTemplateId");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PersonTag",
                columns: table => new
                {
                    PeoplePersonId = table.Column<int>(type: "int", nullable: false),
                    TagsTagId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonTag", x => new { x.PeoplePersonId, x.TagsTagId });
                    table.ForeignKey(
                        name: "FK_PersonTag_People_PeoplePersonId",
                        column: x => x.PeoplePersonId,
                        principalTable: "People",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonTag_Tags_TagsTagId",
                        column: x => x.TagsTagId,
                        principalTable: "Tags",
                        principalColumn: "TagId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ContactEventPerson",
                columns: table => new
                {
                    ContactEventsContactEventId = table.Column<int>(type: "int", nullable: false),
                    PeoplePersonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactEventPerson", x => new { x.ContactEventsContactEventId, x.PeoplePersonId });
                    table.ForeignKey(
                        name: "FK_ContactEventPerson_ContactEvents_ContactEventsContactEventId",
                        column: x => x.ContactEventsContactEventId,
                        principalTable: "ContactEvents",
                        principalColumn: "ContactEventId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContactEventPerson_People_PeoplePersonId",
                        column: x => x.PeoplePersonId,
                        principalTable: "People",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ContactEventTag",
                columns: table => new
                {
                    ContactEventsContactEventId = table.Column<int>(type: "int", nullable: false),
                    TagsTagId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactEventTag", x => new { x.ContactEventsContactEventId, x.TagsTagId });
                    table.ForeignKey(
                        name: "FK_ContactEventTag_ContactEvents_ContactEventsContactEventId",
                        column: x => x.ContactEventsContactEventId,
                        principalTable: "ContactEvents",
                        principalColumn: "ContactEventId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContactEventTag_Tags_TagsTagId",
                        column: x => x.TagsTagId,
                        principalTable: "Tags",
                        principalColumn: "TagId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    NoteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Text = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: true),
                    ContactEventID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.NoteId);
                    table.ForeignKey(
                        name: "FK_Notes_ContactEvents_ContactEventID",
                        column: x => x.ContactEventID,
                        principalTable: "ContactEvents",
                        principalColumn: "ContactEventId");
                    table.ForeignKey(
                        name: "FK_Notes_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "PersonId");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "ContactEvents",
                columns: new[] { "ContactEventId", "ContactTemplateID", "DateTimeOccurred", "Impression", "Medium", "NeedsFollowUp", "Title" },
                values: new object[] { 1, null, new DateTime(2022, 10, 13, 15, 13, 40, 121, DateTimeKind.Local).AddTicks(2320), 0, 4, false, "Work social" });

            migrationBuilder.InsertData(
                table: "ContactTemplates",
                columns: new[] { "ContactTemplateId", "BodyText", "Greeting" },
                values: new object[] { 1, "It's been too long. How are things for you? I would love to hear an update about your family, too. \n\nBest, {1}", "Hey {0}!" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "PersonId", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, null, "John", "Test", "8773012998" },
                    { 2, null, "Charles", "Test", "8783022999" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagId", "Text" },
                values: new object[,]
                {
                    { 1, "School" },
                    { 2, "Work" }
                });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "NoteId", "ContactEventID", "CreatedDate", "PersonId", "Text" },
                values: new object[] { 1, null, new DateTime(2022, 10, 14, 15, 13, 40, 121, DateTimeKind.Local).AddTicks(2220), 1, "John is awesome!" });

            migrationBuilder.CreateIndex(
                name: "IX_ContactEventPerson_PeoplePersonId",
                table: "ContactEventPerson",
                column: "PeoplePersonId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactEvents_ContactTemplateID",
                table: "ContactEvents",
                column: "ContactTemplateID");

            migrationBuilder.CreateIndex(
                name: "IX_ContactEventTag_TagsTagId",
                table: "ContactEventTag",
                column: "TagsTagId");

            migrationBuilder.CreateIndex(
                name: "IX_Notes_ContactEventID",
                table: "Notes",
                column: "ContactEventID");

            migrationBuilder.CreateIndex(
                name: "IX_Notes_PersonId",
                table: "Notes",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonTag_TagsTagId",
                table: "PersonTag",
                column: "TagsTagId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactEventPerson");

            migrationBuilder.DropTable(
                name: "ContactEventTag");

            migrationBuilder.DropTable(
                name: "Notes");

            migrationBuilder.DropTable(
                name: "PersonTag");

            migrationBuilder.DropTable(
                name: "ContactEvents");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "ContactTemplates");
        }
    }
}
