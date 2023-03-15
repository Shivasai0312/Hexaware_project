using Microsoft.EntityFrameworkCore.Migrations;

namespace cafe_try_two.Migrations
{
    public partial class Secondtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ItemsId",
                table: "Customers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Category = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_ItemsId",
                table: "Customers",
                column: "ItemsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Items_ItemsId",
                table: "Customers",
                column: "ItemsId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Items_ItemsId",
                table: "Customers");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Customers_ItemsId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ItemsId",
                table: "Customers");
        }
    }
}
