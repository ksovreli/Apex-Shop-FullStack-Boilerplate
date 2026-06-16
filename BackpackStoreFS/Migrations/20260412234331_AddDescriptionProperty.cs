using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackpackStoreFS.Migrations
{
    /// <inheritdoc />
    public partial class AddDescriptionProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "Backpacks",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Backpacks",
                keyColumn: "id",
                keyValue: 1,
                column: "description",
                value: "Engineered for the modern explorer, the APEX COMMUTER combines minimalist design with maximum durability.");

            migrationBuilder.UpdateData(
                table: "Backpacks",
                keyColumn: "id",
                keyValue: 2,
                column: "description",
                value: "Engineered for the modern explorer, the APEX HERITAGE combines minimalist design with maximum durability.");

            migrationBuilder.UpdateData(
                table: "Backpacks",
                keyColumn: "id",
                keyValue: 3,
                column: "description",
                value: "Engineered for the modern explorer, the APEX PULSE combines minimalist design with maximum durability.");

            migrationBuilder.UpdateData(
                table: "Backpacks",
                keyColumn: "id",
                keyValue: 4,
                column: "description",
                value: "Engineered for the modern explorer, the APEX STEALTH combines minimalist design with maximum durability.");

            migrationBuilder.UpdateData(
                table: "Backpacks",
                keyColumn: "id",
                keyValue: 5,
                column: "description",
                value: "Engineered for the modern explorer, the APEX SKYLINE combines minimalist design with maximum durability.");

            migrationBuilder.UpdateData(
                table: "Backpacks",
                keyColumn: "id",
                keyValue: 6,
                column: "description",
                value: "Engineered for the modern explorer, the APEX GLOBAL combines minimalist design with maximum durability.");

            migrationBuilder.UpdateData(
                table: "Backpacks",
                keyColumn: "id",
                keyValue: 7,
                column: "description",
                value: "Engineered for the modern explorer, the APEX CROSSOVER combines minimalist design with maximum durability.");

            migrationBuilder.UpdateData(
                table: "Backpacks",
                keyColumn: "id",
                keyValue: 8,
                column: "description",
                value: "Engineered for the modern explorer, the APEX EXECUTIVE combines minimalist design with maximum durability.");

            migrationBuilder.UpdateData(
                table: "Backpacks",
                keyColumn: "id",
                keyValue: 9,
                column: "description",
                value: "Engineered for the modern explorer, the APEX IGNITE combines minimalist design with maximum durability.");

            migrationBuilder.UpdateData(
                table: "Backpacks",
                keyColumn: "id",
                keyValue: 10,
                column: "description",
                value: "Engineered for the modern explorer, the APEX TRANSFORMER combines minimalist design with maximum durability.");

            migrationBuilder.UpdateData(
                table: "Backpacks",
                keyColumn: "id",
                keyValue: 11,
                column: "description",
                value: "Engineered for the modern explorer, the APEX LEGACY combines minimalist design with maximum durability.");

            migrationBuilder.UpdateData(
                table: "Backpacks",
                keyColumn: "id",
                keyValue: 12,
                column: "description",
                value: "Engineered for the modern explorer, the APEX ODYSSEY combines minimalist design with maximum durability.");

            migrationBuilder.UpdateData(
                table: "Backpacks",
                keyColumn: "id",
                keyValue: 13,
                column: "description",
                value: "Engineered for the modern explorer, the APEX VOYAGER combines minimalist design with maximum durability.");

            migrationBuilder.UpdateData(
                table: "Backpacks",
                keyColumn: "id",
                keyValue: 14,
                column: "description",
                value: "Engineered for the modern explorer, the APEX SUMMIT combines minimalist design with maximum durability.");

            migrationBuilder.UpdateData(
                table: "Backpacks",
                keyColumn: "id",
                keyValue: 15,
                column: "description",
                value: "Engineered for the modern explorer, the APEX CYBER combines minimalist design with maximum durability.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "description",
                table: "Backpacks");
        }
    }
}
