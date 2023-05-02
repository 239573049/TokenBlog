using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Service.Migrations
{
    public partial class ContentMaxLength : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Articles",
                type: "character varying(50000)",
                maxLength: 50000,
                nullable: false,
                comment: "文章内容",
                oldClrType: typeof(string),
                oldType: "character varying(10000)",
                oldMaxLength: 10000,
                oldComment: "文章内容");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Articles",
                type: "character varying(10000)",
                maxLength: 10000,
                nullable: false,
                comment: "文章内容",
                oldClrType: typeof(string),
                oldType: "character varying(50000)",
                oldMaxLength: 50000,
                oldComment: "文章内容");
        }
    }
}
