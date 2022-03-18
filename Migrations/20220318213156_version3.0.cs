using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace facebook.Migrations
{
    public partial class version30 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProfileSetting");

            migrationBuilder.DropColumn(
                name: "StoryId",
                table: "Story");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Addresses");

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Story",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "Story",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Post",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "Post",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressIP",
                table: "Addresses",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Story");

            migrationBuilder.DropColumn(
                name: "Text",
                table: "Story");

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Post");

            migrationBuilder.DropColumn(
                name: "Text",
                table: "Post");

            migrationBuilder.DropColumn(
                name: "AddressIP",
                table: "Addresses");

            migrationBuilder.AddColumn<int>(
                name: "StoryId",
                table: "Story",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "AddressId",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProfileSetting",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfileSettingsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfileSetting", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProfileSetting_ProfileSetting_ProfileSettingsId",
                        column: x => x.ProfileSettingsId,
                        principalTable: "ProfileSetting",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProfileSetting_ProfileSettingsId",
                table: "ProfileSetting",
                column: "ProfileSettingsId");
        }
    }
}
