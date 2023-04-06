using Microsoft.EntityFrameworkCore.Migrations;

namespace Entity.Migrations
{
    public partial class add_weightLevel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "WeightLimit",
                table: "Drone",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WeightLimit",
                table: "Drone");
        }
    }
}
