using Microsoft.EntityFrameworkCore.Migrations;

namespace Entity.Migrations
{
    public partial class initialdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [dbo].[Drone] ([CreatedDate] ,[SerialNumber] ,[Model] ,[BatteryCapacity] ,[State] ,[WeightLimit]) VALUES (GETDATE(), 'ff8821d1-16a0-4845-a103-0496350163e7', 0, 0.90, 0, 250), (GETDATE(), 'e6fe4271-7cb9-4559-b748-f6fb74de52a6', 0, 0.95, 0, 275), (GETDATE(), '54650dfd-f37a-4633-94b3-761ec083c35a', 1, 0.65, 1, 375), (GETDATE(), '7ba89b77-8b15-49b3-9ad7-12b802efc44d', 1, 0.75, 1, 355), (GETDATE(), 'e33cfcb0-b7a0-4d39-b23c-fc510f7a91eb', 2, 0.65, 2, 435), (GETDATE(), '68607e95-0d6a-4e4b-8cb0-1617ee6b3112', 2, 0.60, 2, 455), (GETDATE(), '697ad6ae-1aa0-4463-a530-287cdd539f90', 2, 0.70, 2, 425), (GETDATE(), 'a01ad2cc-40ec-4d33-8dc4-37496fa7924d', 2, 0.40, 3, 490), (GETDATE(), 'b5699fcb-0e73-4513-82bf-c395817b4f7f', 2, 0.45, 3, 475), (GETDATE(), '1aa670af-bf65-45f8-aff0-501be2527af2', 2, 0.35, 4, 485)");
            migrationBuilder.Sql("INSERT INTO [dbo].[Medication] ([CreatedDate] ,[Name] ,[Weight] ,[Code] ,[Image]) VALUES (GETDATE(), ')Aspirin', 0.081, 'Asp_081', 'https://medmate.com.au/wp-content/uploads/2022/05/Blogs.png' ), (GETDATE(), 'Liraglutide', 0.060, 'Lir_060', 'https://medmate.com.au/wp-content/uploads/2022/05/Blogs.png' ), (GETDATE(), 'Tirzepatide', 0.007, 'Tir_007', 'https://medmate.com.au/wp-content/uploads/2022/05/Blogs.png' ), (GETDATE(), 'Naltrexone', 0.080, 'Nal_080', 'https://medmate.com.au/wp-content/uploads/2022/05/Blogs.png' ), (GETDATE(), 'Orlistat', 0.081, 'Orl_081', 'https://medmate.com.au/wp-content/uploads/2022/05/Blogs.png' ) ");
            migrationBuilder.Sql("INSERT INTO [dbo].[DroneMedication]([CreatedDate] ,[DroneId] ,[MedicationId] ,[MedicationQty] ,[TotalWeight] ,[Active]) VALUES (GETDATE(), 5, 2, 4000, 240, 1), (GETDATE(), 6, 5, 3500, 280, 1), (GETDATE(), 7, 1, 4500, 360, 1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
