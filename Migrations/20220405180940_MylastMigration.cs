using Microsoft.EntityFrameworkCore.Migrations;

namespace facebook.Migrations
{
    public partial class MylastMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Warning",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Warning_UserId",
                table: "Warning",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Warning_users_UserId",
                table: "Warning",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Warning_users_UserId",
                table: "Warning");

            migrationBuilder.DropIndex(
                name: "IX_Warning_UserId",
                table: "Warning");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Warning");
        }
    }
}
