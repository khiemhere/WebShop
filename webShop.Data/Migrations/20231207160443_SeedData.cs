using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webShopSolution.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SortOder",
                table: "Categories",
                newName: "SortOrder");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SortOrder",
                table: "Categories",
                newName: "SortOder");
        }
    }
}
