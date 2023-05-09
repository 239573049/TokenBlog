using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Service.Migrations
{
    public partial class AddName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: new Guid("dfcb4d6e-5123-4dce-80b5-4be3b0d56432"));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "UserInfos",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Account", "Avatar", "CreationTime", "Creator", "Email", "IsDeleted", "ModificationTime", "Modifier", "Name", "Password", "Role" },
                values: new object[] { new Guid("e18749db-5ff1-498b-93f0-05bbc8561a1e"), "admin", "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/Avatar.jpg", new DateTime(2023, 5, 9, 15, 15, 30, 845, DateTimeKind.Utc).AddTicks(8022), null, "239573049@qq.com", false, new DateTime(2023, 5, 9, 15, 15, 30, 845, DateTimeKind.Utc).AddTicks(8026), null, "Token", "dd666666", "Admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: new Guid("e18749db-5ff1-498b-93f0-05bbc8561a1e"));

            migrationBuilder.DropColumn(
                name: "Name",
                table: "UserInfos");

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Account", "Avatar", "CreationTime", "Creator", "Email", "IsDeleted", "ModificationTime", "Modifier", "Password", "Role" },
                values: new object[] { new Guid("dfcb4d6e-5123-4dce-80b5-4be3b0d56432"), "admin", "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/Avatar.jpg", new DateTime(2023, 5, 8, 16, 6, 36, 818, DateTimeKind.Utc).AddTicks(2050), null, "239573049@qq.com", false, new DateTime(2023, 5, 8, 16, 6, 36, 818, DateTimeKind.Utc).AddTicks(2052), null, "dd666666", "Admin" });
        }
    }
}
