using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Service.Migrations
{
    public partial class Resource : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: new Guid("648ce51f-0881-4b9d-bd28-7904a0a89e62"));

            migrationBuilder.CreateTable(
                name: "Resources",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false, comment: "标题"),
                    Description = table.Column<string>(type: "text", nullable: false, comment: "描述"),
                    Url = table.Column<string>(type: "text", nullable: false),
                    DownloadCount = table.Column<int>(type: "integer", nullable: false, comment: "下载次数"),
                    Referee = table.Column<int>(type: "integer", nullable: false, comment: "推荐数量"),
                    UserName = table.Column<string>(type: "text", nullable: true),
                    Href = table.Column<string>(type: "text", nullable: true),
                    Creator = table.Column<Guid>(type: "uuid", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Modifier = table.Column<Guid>(type: "uuid", nullable: true),
                    ModificationTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resources", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Account", "Avatar", "CreationTime", "Creator", "Email", "IsDeleted", "ModificationTime", "Modifier", "Name", "Password", "Role" },
                values: new object[] { new Guid("1e32826f-1716-41b5-a3d9-36745fcde93f"), "admin", "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/Avatar.jpg", new DateTime(2023, 5, 15, 15, 1, 29, 114, DateTimeKind.Utc).AddTicks(1689), null, "239573049@qq.com", false, new DateTime(2023, 5, 15, 15, 1, 29, 114, DateTimeKind.Utc).AddTicks(1690), null, "Token", "dd666666", "Admin" });

            migrationBuilder.CreateIndex(
                name: "IX_Resources_Id",
                table: "Resources",
                column: "Id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Resources");

            migrationBuilder.DeleteData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: new Guid("1e32826f-1716-41b5-a3d9-36745fcde93f"));

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Account", "Avatar", "CreationTime", "Creator", "Email", "IsDeleted", "ModificationTime", "Modifier", "Name", "Password", "Role" },
                values: new object[] { new Guid("648ce51f-0881-4b9d-bd28-7904a0a89e62"), "admin", "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/Avatar.jpg", new DateTime(2023, 5, 9, 15, 54, 24, 333, DateTimeKind.Utc).AddTicks(6887), null, "239573049@qq.com", false, new DateTime(2023, 5, 9, 15, 54, 24, 333, DateTimeKind.Utc).AddTicks(6890), null, "Token", "dd666666", "Admin" });
        }
    }
}
