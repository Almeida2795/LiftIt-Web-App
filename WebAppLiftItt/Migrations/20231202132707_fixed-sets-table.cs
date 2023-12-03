using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppLiftItt.Migrations
{
    /// <inheritdoc />
    public partial class fixedsetstable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "setOrder",
                table: "Sets",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "setOrder",
                table: "Sets");
        }
    }
}
