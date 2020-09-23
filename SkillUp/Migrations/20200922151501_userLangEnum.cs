using Microsoft.EntityFrameworkCore.Migrations;

namespace SkillUp.Migrations
{
    public partial class userLangEnum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LanguageEnum",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LanguageEnum",
                table: "AspNetUsers");
        }
    }
}
