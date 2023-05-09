using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Service.Migrations
{
    public partial class DeletePath : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: new Guid("e18749db-5ff1-498b-93f0-05bbc8561a1e"));

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Account", "Avatar", "CreationTime", "Creator", "Email", "IsDeleted", "ModificationTime", "Modifier", "Name", "Password", "Role" },
                values: new object[] { new Guid("2ec31e22-89b4-4923-8750-263c57f928d7"), "admin", "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/Avatar.jpg", new DateTime(2023, 5, 9, 15, 49, 11, 360, DateTimeKind.Utc).AddTicks(9117), null, "239573049@qq.com", false, new DateTime(2023, 5, 9, 15, 49, 11, 360, DateTimeKind.Utc).AddTicks(9119), null, "Token", "dd666666", "Admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: new Guid("2ec31e22-89b4-4923-8750-263c57f928d7"));

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Account", "Avatar", "CreationTime", "Creator", "Email", "IsDeleted", "ModificationTime", "Modifier", "Name", "Password", "Role" },
                values: new object[] { new Guid("e18749db-5ff1-498b-93f0-05bbc8561a1e"), "admin", "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/Avatar.jpg", new DateTime(2023, 5, 9, 15, 15, 30, 845, DateTimeKind.Utc).AddTicks(8022), null, "239573049@qq.com", false, new DateTime(2023, 5, 9, 15, 15, 30, 845, DateTimeKind.Utc).AddTicks(8026), null, "Token", "dd666666", "Admin" });
        }
    }
}
