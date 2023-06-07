using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Service.Migrations
{
    public partial class UpdateFailarmyIdType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: new Guid("e3802769-0506-4058-8f64-44aabc83632b"));

            migrationBuilder.AlterColumn<int>(
                name: "ActicleId",
                table: "FailarmyItems",
                type: "integer",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Account", "Avatar", "CreationTime", "Creator", "Email", "IsDeleted", "ModificationTime", "Modifier", "Name", "Password", "Role" },
                values: new object[] { new Guid("cf5a6c25-369d-46d9-85c4-af11c9aa8e8f"), "admin", "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/Avatar.jpg", new DateTime(2023, 6, 7, 11, 17, 13, 600, DateTimeKind.Utc).AddTicks(4118), null, "239573049@qq.com", false, new DateTime(2023, 6, 7, 11, 17, 13, 600, DateTimeKind.Utc).AddTicks(4119), null, "Token", "dd666666", "Admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: new Guid("cf5a6c25-369d-46d9-85c4-af11c9aa8e8f"));

            migrationBuilder.AlterColumn<Guid>(
                name: "ActicleId",
                table: "FailarmyItems",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Account", "Avatar", "CreationTime", "Creator", "Email", "IsDeleted", "ModificationTime", "Modifier", "Name", "Password", "Role" },
                values: new object[] { new Guid("e3802769-0506-4058-8f64-44aabc83632b"), "admin", "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/Avatar.jpg", new DateTime(2023, 6, 7, 7, 13, 15, 380, DateTimeKind.Utc).AddTicks(7284), null, "239573049@qq.com", false, new DateTime(2023, 6, 7, 7, 13, 15, 380, DateTimeKind.Utc).AddTicks(7286), null, "Token", "dd666666", "Admin" });
        }
    }
}
