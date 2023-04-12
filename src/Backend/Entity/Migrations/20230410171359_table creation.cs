using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entity.Migrations
{
    public partial class tablecreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drone",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(nullable: true),
                    SerialNumber = table.Column<string>(maxLength: 100, nullable: true),
                    WeightLimit = table.Column<decimal>(nullable: false),
                    Model = table.Column<int>(nullable: false),
                    BatteryCapacity = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    State = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drone", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DroneMedication",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(nullable: true),
                    DroneId = table.Column<int>(nullable: false),
                    MedicationId = table.Column<int>(nullable: false),
                    MedicationQty = table.Column<int>(nullable: false),
                    TotalWeight = table.Column<decimal>(nullable: false),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DroneMedication", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Medication",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Weight = table.Column<decimal>(nullable: false),
                    Code = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medication", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drone");

            migrationBuilder.DropTable(
                name: "DroneMedication");

            migrationBuilder.DropTable(
                name: "Medication");
        }
    }
}
