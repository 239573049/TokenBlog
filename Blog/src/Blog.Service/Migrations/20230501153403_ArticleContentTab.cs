using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Service.Migrations
{
    public partial class ArticleContentTab : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tabs",
                table: "Articles");

            migrationBuilder.RenameColumn(
                name: "tabs",
                table: "Articles",
                newName: "Tabs");

            migrationBuilder.AlterColumn<string>(
                name: "Tabs",
                table: "Articles",
                type: "text",
                nullable: false,
                comment: "标签id json数组格式",
                oldClrType: typeof(string),
                oldType: "text");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Tabs",
                table: "Articles",
                newName: "tabs");

            migrationBuilder.AlterColumn<string>(
                name: "tabs",
                table: "Articles",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldComment: "标签id json数组格式");

            migrationBuilder.AddColumn<string>(
                name: "Tabs",
                table: "Articles",
                type: "text",
                nullable: false,
                defaultValue: "",
                comment: "标签id json数组格式");
        }
    }
}
