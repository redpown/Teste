using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesteDev.Entidades;

namespace TesteDev.Repository.Config
{

    public class IngredienteConfigurations : IEntityTypeConfiguration<Ingredientes>
    {
        public void Configure(EntityTypeBuilder<Ingredientes> builder)
        {
            builder
                .HasKey(tabelaLanches => tabelaLanches.id);
            builder.Property(tabelaLanches => tabelaLanches.ingrediente)
                .IsRequired()
                .HasColumnType("varchar(256)");
                
            builder.Property(tabelaLanches => tabelaLanches.valor)
                .IsRequired()
                .HasColumnType("decimal(18,2)");
            builder.Property(tabelaLanches => tabelaLanches.quantidade)
                .IsRequired()
                .HasColumnType("int");
            builder.Property(tabelaLanches => tabelaLanches.tipo)
                .IsRequired()
                .HasColumnType("varchar(256)");
                
                
        }
    }
}
