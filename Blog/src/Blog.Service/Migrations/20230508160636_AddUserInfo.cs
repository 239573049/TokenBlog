using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Service.Migrations
{
    public partial class AddUserInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserInfos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Account = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Avatar = table.Column<string>(type: "text", nullable: true),
                    Role = table.Column<string>(type: "text", nullable: false),
                    Creator = table.Column<Guid>(type: "uuid", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Modifier = table.Column<Guid>(type: "uuid", nullable: true),
                    ModificationTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Account", "Avatar", "CreationTime", "Creator", "Email", "IsDeleted", "ModificationTime", "Modifier", "Password", "Role" },
                values: new object[] { new Guid("dfcb4d6e-5123-4dce-80b5-4be3b0d56432"), "admin", "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/Avatar.jpg", new DateTime(2023, 5, 8, 16, 6, 36, 818, DateTimeKind.Utc).AddTicks(2050), null, "239573049@qq.com", false, new DateTime(2023, 5, 8, 16, 6, 36, 818, DateTimeKind.Utc).AddTicks(2052), null, "dd666666", "Admin" });

            migrationBuilder.CreateIndex(
                name: "IX_UserInfos_Account",
                table: "UserInfos",
                column: "Account");

            migrationBuilder.CreateIndex(
                name: "IX_UserInfos_Id",
                table: "UserInfos",
                column: "Id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserInfos");
        }
    }
}
