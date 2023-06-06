using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Service.Migrations
{
    public partial class Log : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: new Guid("1e32826f-1716-41b5-a3d9-36745fcde93f"));

            migrationBuilder.AddColumn<string>(
                name: "ExpandContent",
                table: "IntegrationEventLog",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Failarmies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Failarmies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FailarmyItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ActicleId = table.Column<Guid>(type: "uuid", nullable: false),
                    FailarmyId = table.Column<Guid>(type: "uuid", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FailarmyItems", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Account", "Avatar", "CreationTime", "Creator", "Email", "IsDeleted", "ModificationTime", "Modifier", "Name", "Password", "Role" },
                values: new object[] { new Guid("e63f14e2-bb6c-4ef5-9ff7-068b2f1e2992"), "admin", "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/Avatar.jpg", new DateTime(2023, 6, 6, 16, 27, 43, 569, DateTimeKind.Utc).AddTicks(559), null, "239573049@qq.com", false, new DateTime(2023, 6, 6, 16, 27, 43, 569, DateTimeKind.Utc).AddTicks(560), null, "Token", "dd666666", "Admin" });

            migrationBuilder.CreateIndex(
                name: "IX_Failarmies_Id",
                table: "Failarmies",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Failarmies_Name",
                table: "Failarmies",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_FailarmyItems_ActicleId",
                table: "FailarmyItems",
                column: "ActicleId");

            migrationBuilder.CreateIndex(
                name: "IX_FailarmyItems_FailarmyId",
                table: "FailarmyItems",
                column: "FailarmyId");

            migrationBuilder.CreateIndex(
                name: "IX_FailarmyItems_Id",
                table: "FailarmyItems",
                column: "Id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Failarmies");

            migrationBuilder.DropTable(
                name: "FailarmyItems");

            migrationBuilder.DeleteData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: new Guid("e63f14e2-bb6c-4ef5-9ff7-068b2f1e2992"));

            migrationBuilder.DropColumn(
                name: "ExpandContent",
                table: "IntegrationEventLog");

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Account", "Avatar", "CreationTime", "Creator", "Email", "IsDeleted", "ModificationTime", "Modifier", "Name", "Password", "Role" },
                values: new object[] { new Guid("1e32826f-1716-41b5-a3d9-36745fcde93f"), "admin", "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/Avatar.jpg", new DateTime(2023, 5, 15, 15, 1, 29, 114, DateTimeKind.Utc).AddTicks(1689), null, "239573049@qq.com", false, new DateTime(2023, 5, 15, 15, 1, 29, 114, DateTimeKind.Utc).AddTicks(1690), null, "Token", "dd666666", "Admin" });
        }
    }
}
