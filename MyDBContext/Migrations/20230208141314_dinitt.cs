using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyDBContext.Migrations
{
    /// <inheritdoc />
    public partial class dinitt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ParentIdNumber",
                table: "children",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParentIdNumber",
                table: "children");
        }
    }
}
