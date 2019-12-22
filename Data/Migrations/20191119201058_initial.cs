using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CinemaNetworkEntity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    WebSite = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CinemaNetworkEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FilmEntity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AgeRate = table.Column<int>(nullable: false),
                    Caption = table.Column<string>(nullable: false),
                    Duration = table.Column<int>(nullable: false),
                    PremiereDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonEntity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    RegistrationDate = table.Column<DateTime>(nullable: false),
                    Surname = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CinemaEntity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: false),
                    Caption = table.Column<string>(nullable: false),
                    CinemaNetworkId = table.Column<int>(nullable: false),
                    City = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CinemaEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CinemaEntity_CinemaNetworkEntity_CinemaNetworkId",
                        column: x => x.CinemaNetworkId,
                        principalTable: "CinemaNetworkEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FilmInCinemaEntity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CinemaId = table.Column<int>(nullable: false),
                    DateOfStart = table.Column<DateTime>(nullable: false),
                    DateOfEnd = table.Column<DateTime>(nullable: false),
                    FilmId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmInCinemaEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FilmInCinemaEntity_CinemaEntity_CinemaId",
                        column: x => x.CinemaId,
                        principalTable: "CinemaEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FilmInCinemaEntity_FilmEntity_FilmId",
                        column: x => x.FilmId,
                        principalTable: "FilmEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HallEntity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Caption = table.Column<string>(nullable: false),
                    CinemaId = table.Column<int>(nullable: false),
                    ScreenType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HallEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HallEntity_CinemaEntity_CinemaId",
                        column: x => x.CinemaId,
                        principalTable: "CinemaEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PlaceEntity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Class = table.Column<int>(nullable: false),
                    HallId = table.Column<int>(nullable: false),
                    PlaceLine = table.Column<int>(nullable: false),
                    PlaceNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaceEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlaceEntity_HallEntity_HallId",
                        column: x => x.HallId,
                        principalTable: "HallEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SessionEntity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BaseTicketPrice = table.Column<double>(nullable: false),
                    DateAndTime = table.Column<DateTime>(nullable: false),
                    FilmInCinemaId = table.Column<int>(nullable: false),
                    HallId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SessionEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SessionEntity_FilmInCinemaEntity_FilmInCinemaId",
                        column: x => x.FilmInCinemaId,
                        principalTable: "FilmInCinemaEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SessionEntity_HallEntity_HallId",
                        column: x => x.HallId,
                        principalTable: "HallEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TicketEntity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsActive = table.Column<bool>(nullable: false),
                    PersonId = table.Column<int>(nullable: false),
                    PlaceId = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    PurchasedDate = table.Column<DateTime>(nullable: false),
                    RevertedDate = table.Column<DateTime>(nullable: true),
                    SessionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TicketEntity_PersonEntity_PersonId",
                        column: x => x.PersonId,
                        principalTable: "PersonEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TicketEntity_PlaceEntity_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "PlaceEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TicketEntity_SessionEntity_SessionId",
                        column: x => x.SessionId,
                        principalTable: "SessionEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "PersonEntity",
                columns: new[] { "Id", "BirthDate", "Email", "Name", "Password", "RegistrationDate", "Surname" },
                values: new object[] { 1, new DateTime(1999, 11, 19, 22, 10, 58, 531, DateTimeKind.Local).AddTicks(1441), "smithbob@gmail.com", "Bob", "00000", new DateTime(2019, 11, 19, 22, 10, 58, 532, DateTimeKind.Local).AddTicks(7651), "Smith" });

            migrationBuilder.CreateIndex(
                name: "IX_CinemaEntity_CinemaNetworkId",
                table: "CinemaEntity",
                column: "CinemaNetworkId");

            migrationBuilder.CreateIndex(
                name: "IX_CinemaNetworkEntity_WebSite",
                table: "CinemaNetworkEntity",
                column: "WebSite",
                unique: true,
                filter: "[WebSite] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_FilmInCinemaEntity_CinemaId",
                table: "FilmInCinemaEntity",
                column: "CinemaId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmInCinemaEntity_FilmId",
                table: "FilmInCinemaEntity",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_HallEntity_CinemaId",
                table: "HallEntity",
                column: "CinemaId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonEntity_Email",
                table: "PersonEntity",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PlaceEntity_HallId",
                table: "PlaceEntity",
                column: "HallId");

            migrationBuilder.CreateIndex(
                name: "IX_SessionEntity_FilmInCinemaId",
                table: "SessionEntity",
                column: "FilmInCinemaId");

            migrationBuilder.CreateIndex(
                name: "IX_SessionEntity_HallId",
                table: "SessionEntity",
                column: "HallId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketEntity_PersonId",
                table: "TicketEntity",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketEntity_PlaceId",
                table: "TicketEntity",
                column: "PlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketEntity_SessionId",
                table: "TicketEntity",
                column: "SessionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TicketEntity");

            migrationBuilder.DropTable(
                name: "PersonEntity");

            migrationBuilder.DropTable(
                name: "PlaceEntity");

            migrationBuilder.DropTable(
                name: "SessionEntity");

            migrationBuilder.DropTable(
                name: "FilmInCinemaEntity");

            migrationBuilder.DropTable(
                name: "HallEntity");

            migrationBuilder.DropTable(
                name: "FilmEntity");

            migrationBuilder.DropTable(
                name: "CinemaEntity");

            migrationBuilder.DropTable(
                name: "CinemaNetworkEntity");
        }
    }
}
