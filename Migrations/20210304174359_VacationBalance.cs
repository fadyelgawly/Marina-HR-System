using Microsoft.EntityFrameworkCore.Migrations;

namespace MarinaHR.Migrations
{
    public partial class VacationBalance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VacationBalance",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57784dee-54ff-4115-9835-da06239d6117",
                column: "ConcurrencyStamp",
                value: "9a437ee4-eba8-422c-bd89-90e1f5e5bcd5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93c4a412-3af5-49f8-9b27-cecc7b6f6e79",
                column: "ConcurrencyStamp",
                value: "91a556df-fbd9-44c8-a1a1-d2f784d5e33b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6510262c-bbcb-4629-b1e7-20de05ef7ae6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "VacationBalance" },
                values: new object[] { "7da02bea-d416-4e74-bb6f-5acd64cdf8c3", "AQAAAAEAACcQAAAAENymmDDnba8rTcd5zkgbUqIvEZ0k42eQEkyGiuRLyTt27Lyvv9SuqgXiPqTsIQabVg==", "7ca30a7a-b729-4ba6-ac1b-fd354d2b8cd1", 21 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VacationBalance",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57784dee-54ff-4115-9835-da06239d6117",
                column: "ConcurrencyStamp",
                value: "58285488-f4d5-4e4a-aa31-a6045894b585");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93c4a412-3af5-49f8-9b27-cecc7b6f6e79",
                column: "ConcurrencyStamp",
                value: "3609de7b-40ba-4c9c-b076-f06792125699");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6510262c-bbcb-4629-b1e7-20de05ef7ae6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b13ec6c-881e-4ab5-b268-b625ff931592", "AQAAAAEAACcQAAAAEK+gCKE1QBAvCVk3dd9zu0Auz2b5VmMPrs2xve5z7IAQJe1jOsbfirwiKtrX0aKY+Q==", "07c4d295-5ed4-4c9c-80eb-de7d9bd040dc" });
        }
    }
}
