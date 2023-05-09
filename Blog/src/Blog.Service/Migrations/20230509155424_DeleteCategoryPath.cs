using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Service.Migrations
{
    public partial class DeleteCategoryPath : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: new Guid("2ec31e22-89b4-4923-8750-263c57f928d7"));

            migrationBuilder.DropColumn(
                name: "Path",
                table: "Categories");

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Account", "Avatar", "CreationTime", "Creator", "Email", "IsDeleted", "ModificationTime", "Modifier", "Name", "Password", "Role" },
                values: new object[] { new Guid("648ce51f-0881-4b9d-bd28-7904a0a89e62"), "admin", "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/Avatar.jpg", new DateTime(2023, 5, 9, 15, 54, 24, 333, DateTimeKind.Utc).AddTicks(6887), null, "239573049@qq.com", false, new DateTime(2023, 5, 9, 15, 54, 24, 333, DateTimeKind.Utc).AddTicks(6890), null, "Token", "dd666666", "Admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: new Guid("648ce51f-0881-4b9d-bd28-7904a0a89e62"));

            migrationBuilder.AddColumn<string>(
                name: "Path",
                table: "Categories",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Account", "Avatar", "CreationTime", "Creator", "Email", "IsDeleted", "ModificationTime", "Modifier", "Name", "Password", "Role" },
                values: new object[] { new Guid("2ec31e22-89b4-4923-8750-263c57f928d7"), "admin", "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/Avatar.jpg", new DateTime(2023, 5, 9, 15, 49, 11, 360, DateTimeKind.Utc).AddTicks(9117), null, "239573049@qq.com", false, new DateTime(2023, 5, 9, 15, 49, 11, 360, DateTimeKind.Utc).AddTicks(9119), null, "Token", "dd666666", "Admin" });
        }
    }
}
