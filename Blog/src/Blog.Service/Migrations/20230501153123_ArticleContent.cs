using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Service.Migrations
{
    public partial class ArticleContent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Articles",
                type: "character varying(10000)",
                maxLength: 10000,
                nullable: false,
                comment: "文章内容",
                oldClrType: typeof(string),
                oldType: "text",
                oldComment: "文章内容");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Articles",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "Creator",
                table: "Articles",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Articles",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModificationTime",
                table: "Articles",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "Modifier",
                table: "Articles",
                type: "uuid",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "Creator",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "ModificationTime",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "Modifier",
                table: "Articles");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Articles",
                type: "text",
                nullable: false,
                comment: "文章内容",
                oldClrType: typeof(string),
                oldType: "character varying(10000)",
                oldMaxLength: 10000,
                oldComment: "文章内容");
        }
    }
}
