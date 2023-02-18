using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Migrations
{
    /// <inheritdoc />
    public partial class UpdateGitHubToGitee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GitHubUrl",
                table: "UserInfos",
                newName: "GiteeUrl");

            migrationBuilder.RenameColumn(
                name: "GitHubId",
                table: "UserInfos",
                newName: "GiteeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GiteeUrl",
                table: "UserInfos",
                newName: "GitHubUrl");

            migrationBuilder.RenameColumn(
                name: "GiteeId",
                table: "UserInfos",
                newName: "GitHubId");
        }
    }
}
