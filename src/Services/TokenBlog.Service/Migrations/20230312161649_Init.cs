using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TokenBlog.Service.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bloggers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Flow = table.Column<int>(type: "int", nullable: false),
                    Creator = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modifier = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModificationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bloggers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TabItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TabId = table.Column<int>(type: "int", nullable: false),
                    BloggerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tabs",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "标签名称"),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tabs", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "UserInfos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Intro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Creator = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modifier = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModificationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OAuthUserInfos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    OAuthId = table.Column<int>(type: "int", nullable: false),
                    UserInfoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OAuthUserInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OAuthUserInfos_UserInfos_UserInfoId",
                        column: x => x.UserInfoId,
                        principalTable: "UserInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bloggers_Id",
                table: "Bloggers",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bloggers_Title",
                table: "Bloggers",
                column: "Title");

            migrationBuilder.CreateIndex(
                name: "IX_Bloggers_UserId",
                table: "Bloggers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OAuthUserInfos_UserInfoId",
                table: "OAuthUserInfos",
                column: "UserInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_TabItems_BloggerId",
                table: "TabItems",
                column: "BloggerId");

            migrationBuilder.CreateIndex(
                name: "IX_TabItems_Id",
                table: "TabItems",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_TabItems_TabId",
                table: "TabItems",
                column: "TabId");

            migrationBuilder.CreateIndex(
                name: "IX_Tabs_Id",
                table: "Tabs",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tabs_Name",
                table: "Tabs",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_UserInfos_Id",
                table: "UserInfos",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bloggers");

            migrationBuilder.DropTable(
                name: "OAuthUserInfos");

            migrationBuilder.DropTable(
                name: "TabItems");

            migrationBuilder.DropTable(
                name: "Tabs");

            migrationBuilder.DropTable(
                name: "UserInfos");
        }
    }
}
