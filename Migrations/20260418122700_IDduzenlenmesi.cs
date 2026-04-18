using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EdirneGeziAPI.Migrations
{
    /// <inheritdoc />
    public partial class IDduzenlenmesi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 70,
                column: "CategoryId",
                value: 2);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 70,
                column: "CategoryId",
                value: 3);
        }
    }
}
