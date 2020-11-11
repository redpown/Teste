using Microsoft.EntityFrameworkCore.Migrations;

namespace TesteDev.Repository.Migrations
{
    public partial class v002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Lanches",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "ingrediente", "valor" },
                values: new object[] { "Hambúrguer de carne , queijo e Ovo", 5.30m });

            migrationBuilder.UpdateData(
                table: "Lanches",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "ingrediente", "lanche", "valor" },
                values: new object[] { "Hambúrguer de carne , queijo ,Ovo e bacon", "X-Egg Bacon", 7.30m });

            migrationBuilder.UpdateData(
                table: "Lanches",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "lanche", "valor" },
                values: new object[] { "X-Bacon", 6.50m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Lanches",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "ingrediente", "valor" },
                values: new object[] { "Hambúrguer de carne , queijo e ovo", 5.35m });

            migrationBuilder.UpdateData(
                table: "Lanches",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "ingrediente", "lanche", "valor" },
                values: new object[] { "Hambúrguer de carne , queijo e bacon", "X-Bacon", 6.51m });

            migrationBuilder.UpdateData(
                table: "Lanches",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "lanche", "valor" },
                values: new object[] { "X-Egg Bacon", 7.33m });
        }
    }
}
