using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment4Games.Migrations
{
    public partial class addedPaymentToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    prestono = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<int>(nullable: false),
                    Pass = table.Column<int>(nullable: false),
                    name = table.Column<string>(nullable: false),
                    email = table.Column<string>(nullable: false),
                    mobile = table.Column<string>(nullable: false),
                    Card = table.Column<int>(nullable: false),
                    CVV = table.Column<int>(nullable: false),
                    Date = table.Column<int>(nullable: false),
                    age = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.prestono);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payment");
        }
    }
}
