using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Service.Migrations
{
    public partial class MaxContent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: new Guid("4666a985-1808-45df-b661-c71daff0de6f"));

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Articles",
                type: "character varying(100000)",
                maxLength: 100000,
                nullable: false,
                comment: "文章内容",
                oldClrType: typeof(string),
                oldType: "character varying(50000)",
                oldMaxLength: 50000,
                oldComment: "文章内容");

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Account", "Avatar", "CreationTime", "Creator", "Email", "IsDeleted", "ModificationTime", "Modifier", "Name", "Password", "Role" },
                values: new object[] { new Guid("e3802769-0506-4058-8f64-44aabc83632b"), "admin", "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/Avatar.jpg", new DateTime(2023, 6, 7, 7, 13, 15, 380, DateTimeKind.Utc).AddTicks(7284), null, "239573049@qq.com", false, new DateTime(2023, 6, 7, 7, 13, 15, 380, DateTimeKind.Utc).AddTicks(7286), null, "Token", "dd666666", "Admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: new Guid("e3802769-0506-4058-8f64-44aabc83632b"));

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Articles",
                type: "character varying(50000)",
                maxLength: 50000,
                nullable: false,
                comment: "文章内容",
                oldClrType: typeof(string),
                oldType: "character varying(100000)",
                oldMaxLength: 100000,
                oldComment: "文章内容");

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Account", "Avatar", "CreationTime", "Creator", "Email", "IsDeleted", "ModificationTime", "Modifier", "Name", "Password", "Role" },
                values: new object[] { new Guid("4666a985-1808-45df-b661-c71daff0de6f"), "admin", "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/Avatar.jpg", new DateTime(2023, 6, 6, 17, 5, 48, 638, DateTimeKind.Utc).AddTicks(2687), null, "239573049@qq.com", false, new DateTime(2023, 6, 6, 17, 5, 48, 638, DateTimeKind.Utc).AddTicks(2690), null, "Token", "dd666666", "Admin" });
        }
    }
}
