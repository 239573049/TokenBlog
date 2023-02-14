using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Migrations
{
    /// <inheritdoc />
    public partial class deleteTagRelevanceArticle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TagRelevanceArticles");

            migrationBuilder.AddColumn<Guid>(
                name: "TagId",
                table: "Articles",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TagId",
                table: "Articles");

            migrationBuilder.CreateTable(
                name: "TagRelevanceArticles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArticleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TagId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagRelevanceArticles", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TagRelevanceArticles_ArticleId",
                table: "TagRelevanceArticles",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_TagRelevanceArticles_TagId",
                table: "TagRelevanceArticles",
                column: "TagId");
        }
    }
}
