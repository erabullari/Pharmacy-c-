using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pharmacy.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Medicines",
                columns: table => new
                {
                    med_id = table.Column<int>(type: "int", nullable: false),
                    med_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    med_price = table.Column<int>(type: "int", nullable: false),
                    med_description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    med_expired_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    med_produced_by = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Medicines");
        }
    }
}
