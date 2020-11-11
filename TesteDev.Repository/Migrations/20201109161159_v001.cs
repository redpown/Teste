using Microsoft.EntityFrameworkCore.Migrations;

namespace TesteDev.Repository.Migrations
{
    public partial class v001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ingredientes",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ingrediente = table.Column<string>(type: "varchar(256)", nullable: false),
                    tipo = table.Column<string>(type: "varchar(256)", nullable: false),
                    quantidade = table.Column<int>(type: "int", nullable: false),
                    valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredientes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Lanches",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lanche = table.Column<string>(type: "varchar(256)", nullable: false),
                    ingrediente = table.Column<string>(type: "varchar(256)", nullable: false),
                    quantidade = table.Column<int>(type: "int", nullable: false),
                    valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lanches", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Ingredientes",
                columns: new[] { "id", "ingrediente", "quantidade", "tipo", "valor" },
                values: new object[,]
                {
                    { 1, "Alface", 0, "1", 0.40m },
                    { 2, "Bacon", 0, "2", 2.00m },
                    { 3, "Hambúrguer de carne", 0, "3", 3.00m },
                    { 4, "Ovo", 0, "4", 0.80m },
                    { 5, "Queijo", 0, "5", 1.50m }
                });

            migrationBuilder.InsertData(
                table: "Lanches",
                columns: new[] { "id", "ingrediente", "lanche", "quantidade", "valor" },
                values: new object[,]
                {
                    { 1, "Hambúrguer de carne e queijo", "X-Burger", 0, 4.50m },
                    { 2, "Hambúrguer de carne , queijo e ovo", "X-Egg", 0, 5.35m },
                    { 3, "Hambúrguer de carne , queijo e bacon", "X-Bacon", 0, 6.51m },
                    { 4, "Hambúrguer de carne , queijo , bacon", "X-Egg Bacon", 0, 7.33m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ingredientes");

            migrationBuilder.DropTable(
                name: "Lanches");
        }
    }
}
