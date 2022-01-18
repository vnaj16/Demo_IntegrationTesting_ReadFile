using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo_IntegrationTesting_Database.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Debt = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Debt", "FirstName", "LastName" },
                values: new object[] { 1, 500, "Arthur", "Valladares" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Debt", "FirstName", "LastName" },
                values: new object[] { 2, 600, "Javier", "Nole" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
