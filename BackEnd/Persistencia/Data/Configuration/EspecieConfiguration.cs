using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class EspecieConfiguration : IEntityTypeConfiguration<Especie>
{
    public void Configure(EntityTypeBuilder<Especie> builder)
    {
        
        builder.ToTable("Especie");

        builder.Property(p => p.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("IdEspecie")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.Nombre)
            .HasColumnName("Nombre")
            .HasColumnType("varchar")
            .HasMaxLength(25)
            .IsRequired();





        builder.HasData(
            new {
                Id = 1,
                Nombre = "felina"
            },
            new {
                Id = 2,
                Nombre = "Perro"
            },
            new {
                Id = 3,
                Nombre = "Hamster"
            },
            new {
                Id = 4,
                Nombre = "Conejo"
            },
            new {
                Id = 5,
                Nombre = "Serpiente"
            }
        );

    }
}
