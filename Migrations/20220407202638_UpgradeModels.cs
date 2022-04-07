using Microsoft.EntityFrameworkCore.Migrations;

namespace LeapYears.Migrations
{
    public partial class UpgradeModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "YearUserId",
                table: "History",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_History_YearUserId",
                table: "History",
                column: "YearUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_History_User_YearUserId",
                table: "History",
                column: "YearUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_History_User_YearUserId",
                table: "History");

            migrationBuilder.DropIndex(
                name: "IX_History_YearUserId",
                table: "History");

            migrationBuilder.DropColumn(
                name: "YearUserId",
                table: "History");
        }
    }
}
