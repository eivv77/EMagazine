using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EMagazine.Infrastructure.Persistence.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SellersCustomers",
                columns: table => new
                {
                    SellerId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SellersCustomers", x => new { x.SellerId, x.CustomerId });
                    table.ForeignKey(
                        name: "FK_SellersCustomers_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SellersCustomers_Sellers_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Sellers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "SellersCustomers",
                columns: new[] { "CustomerId", "SellerId" },
                values: new object[] { 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_SellersCustomers_CustomerId",
                table: "SellersCustomers",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SellersCustomers");
        }
    }
}
