using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace facebook.Migrations
{
    public partial class lvmigrations1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Post_groups_PostId",
                table: "Post");

            migrationBuilder.DropForeignKey(
                name: "FK_Story_groups_StoryId",
                table: "Story");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropIndex(
                name: "IX_Story_StoryId",
                table: "Story");

            migrationBuilder.DropIndex(
                name: "IX_Post_PostId",
                table: "Post");

            migrationBuilder.DropColumn(
                name: "ConfirmPassword",
                table: "users");

            migrationBuilder.DropColumn(
                name: "Isplay",
                table: "Story");

            migrationBuilder.DropColumn(
                name: "StoryOwner",
                table: "Story");

            migrationBuilder.DropColumn(
                name: "StoryReply",
                table: "Story");

            migrationBuilder.DropColumn(
                name: "PostId",
                table: "Post");

            migrationBuilder.AddColumn<int>(
                name: "GroupsId",
                table: "users",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "Story",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Story",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "Post",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Post",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ProfileSetting",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    ProfileSettingsId = table.Column<int>(nullable: true)
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
                name: "IX_users_GroupsId",
                table: "users",
                column: "GroupsId");

            migrationBuilder.CreateIndex(
                name: "IX_Story_GroupId",
                table: "Story",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Story_UserId",
                table: "Story",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Post_GroupId",
                table: "Post",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Post_UserId",
                table: "Post",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfileSetting_ProfileSettingsId",
                table: "ProfileSetting",
                column: "ProfileSettingsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Post_groups_GroupId",
                table: "Post",
                column: "GroupId",
                principalTable: "groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Post_users_UserId",
                table: "Post",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Story_groups_GroupId",
                table: "Story",
                column: "GroupId",
                principalTable: "groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Story_users_UserId",
                table: "Story",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_users_groups_GroupsId",
                table: "users",
                column: "GroupsId",
                principalTable: "groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Post_groups_GroupId",
                table: "Post");

            migrationBuilder.DropForeignKey(
                name: "FK_Post_users_UserId",
                table: "Post");

            migrationBuilder.DropForeignKey(
                name: "FK_Story_groups_GroupId",
                table: "Story");

            migrationBuilder.DropForeignKey(
                name: "FK_Story_users_UserId",
                table: "Story");

            migrationBuilder.DropForeignKey(
                name: "FK_users_groups_GroupsId",
                table: "users");

            migrationBuilder.DropTable(
                name: "ProfileSetting");

            migrationBuilder.DropIndex(
                name: "IX_users_GroupsId",
                table: "users");

            migrationBuilder.DropIndex(
                name: "IX_Story_GroupId",
                table: "Story");

            migrationBuilder.DropIndex(
                name: "IX_Story_UserId",
                table: "Story");

            migrationBuilder.DropIndex(
                name: "IX_Post_GroupId",
                table: "Post");

            migrationBuilder.DropIndex(
                name: "IX_Post_UserId",
                table: "Post");

            migrationBuilder.DropColumn(
                name: "GroupsId",
                table: "users");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "Story");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Story");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "Post");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Post");

            migrationBuilder.AddColumn<string>(
                name: "ConfirmPassword",
                table: "users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Isplay",
                table: "Story",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StoryOwner",
                table: "Story",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StoryReply",
                table: "Story",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PostId",
                table: "Post",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MainOptionsId = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Settings_Settings_MainOptionsId",
                        column: x => x.MainOptionsId,
                        principalTable: "Settings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Story_StoryId",
                table: "Story",
                column: "StoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Post_PostId",
                table: "Post",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Settings_MainOptionsId",
                table: "Settings",
                column: "MainOptionsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Post_groups_PostId",
                table: "Post",
                column: "PostId",
                principalTable: "groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Story_groups_StoryId",
                table: "Story",
                column: "StoryId",
                principalTable: "groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
