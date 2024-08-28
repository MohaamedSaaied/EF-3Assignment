using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_3InhertanceExample.Migrations
{
    /// <inheritdoc />
    public partial class TPC : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "FullTimeEmps",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    salary = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FullTimeEmps", x => x.id);
                    table.ForeignKey(
                        name: "FK_FullTimeEmps_Employees_id",
                        column: x => x.id,
                        principalTable: "Employees",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PartTimeEmps",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    NumOfHour = table.Column<int>(type: "int", nullable: false),
                    HoureRate = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartTimeEmps", x => x.id);
                    table.ForeignKey(
                        name: "FK_PartTimeEmps_Employees_id",
                        column: x => x.id,
                        principalTable: "Employees",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FullTimeEmps");

            migrationBuilder.DropTable(
                name: "PartTimeEmps");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
