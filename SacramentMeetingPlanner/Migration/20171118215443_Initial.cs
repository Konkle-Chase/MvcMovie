using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SacramentMeetingPlanner.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlannedMeeting",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Meeting = table.Column<DateTime>(nullable: false),
                    Conductor = table.Column<string>(nullable: false),
                    OpeningSong = table.Column<string>(nullable: false),
                    StartPrayer = table.Column<string>(nullable: false),
                    SacramentSong = table.Column<string>(nullable: false),
                    Sacrament = table.Column<string>(nullable: false),
                    SpeakerOne = table.Column<string>(nullable: true),
                    SpeakerTwo = table.Column<string>(nullable: true),
                    OptionalSong = table.Column<string>(nullable: true),
                    SpeakerThree = table.Column<string>(nullable: true),
                    ClosingSong = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlannedMeeting", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlannedMeeting");
        }
    }
}
