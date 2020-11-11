using Microsoft.EntityFrameworkCore;
using TesteDev.Entidades;
using TesteDev.Repository.Config;

namespace TesteDev.Repository.Contexto
{
    public class TesteDevContexto : DbContext
    {


        public DbSet<Lanches> Lanches { get; set; }
        public DbSet<Ingredientes> Ingredientes { get; set; }
       

        public TesteDevContexto(DbContextOptions<TesteDevContexto> options) : base(options)
        {
            
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //classes de mapeamento aqui..
            //que sao as classes criadas na pasta Config...

            modelBuilder.ApplyConfiguration(new LancheConfigurations());
            modelBuilder.ApplyConfiguration(new IngredienteConfigurations());
            

            //aqui e gerado a carga inicial
            
            modelBuilder.Entity<Ingredientes>().HasData(
                new Ingredientes() {
                    id = 1,
                    ingrediente = "Alface",
                    quantidade = 0,
                    tipo = "1",
                    valor = 0.40m
                },
                new Ingredientes() {
                    id = 2,
                    ingrediente = "Bacon",
                    quantidade = 0,
                    tipo = "2",
                    valor = 2.00m
                },
                new Ingredientes() {
                    id = 3,
                    ingrediente = "Hambúrguer de carne",
                    quantidade = 0,
                    tipo = "3",
                    valor = 3.00m
                },
                new Ingredientes() {
                    id = 4,
                    ingrediente = "Ovo",
                    quantidade = 0,
                    tipo = "4",
                    valor = 0.80m
                },
                new Ingredientes()
                {
                    id = 5,
                    ingrediente = "Queijo",
                    quantidade = 0,
                    tipo = "5",
                    valor = 1.50m
                }
                );
            modelBuilder.Entity<Lanches>().HasData(
                new Lanches()
                {
                    id = 1,
                    lanche = "X-Burger",
                    ingrediente = "Hambúrguer de carne e queijo",
                    quantidade = 0,
                    valor = 4.50m
                },
                new Lanches()
                {
                    id = 2,
                    lanche = "X-Egg",
                    ingrediente = "Hambúrguer de carne , queijo e Ovo",
                    quantidade = 0,
                    valor = 5.30m
                },
                new Lanches()
                {
                    id = 3,
                    lanche = "X-Egg Bacon",
                    ingrediente = "Hambúrguer de carne , queijo ,Ovo e bacon",
                    quantidade = 0,
                    valor = 7.30m
                },
                new Lanches()
                {
                    id = 4,
                    lanche = "X-Bacon",
                    ingrediente = "Hambúrguer de carne , queijo e bacon",
                    quantidade = 0,
                    valor = 6.50m
                }
                );


        }

    }
}
