using Microsoft.EntityFrameworkCore.Migrations;

namespace TesteDev.Repository.Migrations
{
    public partial class v003 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Lanches",
                keyColumn: "id",
                keyValue: 4,
                column: "ingrediente",
                value: "Hambúrguer de carne , queijo e bacon");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Lanches",
                keyColumn: "id",
                keyValue: 4,
                column: "ingrediente",
                value: "Hambúrguer de carne , queijo , bacon");
        }
    }
}
