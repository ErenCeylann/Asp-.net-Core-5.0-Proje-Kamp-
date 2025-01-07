using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class add_portfolio_column : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image1",
                table: "Porfolios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image2",
                table: "Porfolios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image3",
                table: "Porfolios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image4",
                table: "Porfolios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Platform",
                table: "Porfolios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Price",
                table: "Porfolios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Porfolios",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Value",
                table: "Porfolios",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image1",
                table: "Porfolios");

            migrationBuilder.DropColumn(
                name: "Image2",
                table: "Porfolios");

            migrationBuilder.DropColumn(
                name: "Image3",
                table: "Porfolios");

            migrationBuilder.DropColumn(
                name: "Image4",
                table: "Porfolios");

            migrationBuilder.DropColumn(
                name: "Platform",
                table: "Porfolios");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Porfolios");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Porfolios");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "Porfolios");
        }
    }
}
