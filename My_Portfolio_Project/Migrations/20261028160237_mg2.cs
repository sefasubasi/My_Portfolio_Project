using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace My_Portfolio_Project.Migrations
{
    /// <inheritdoc />
    public partial class mg2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SebderEmail",
                table: "Messages",
                newName: "SenderEmail");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SenderEmail",
                table: "Messages",
                newName: "SebderEmail");
        }
    }
}
