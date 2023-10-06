using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class RazaConfiguration : IEntityTypeConfiguration<Raza>
{
    public void Configure(EntityTypeBuilder<Raza> builder)
    {

        builder.ToTable("Raza");

        builder.Property(p => p.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("IdRaza")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.Nombre)
            .HasColumnName("Nombre")
            .HasColumnType("varchar")
            .HasMaxLength(30)
            .IsRequired();

        builder.Property(p => p.EspecieId)
            .HasColumnName("Especie_Id")
            .HasColumnType("int")
            .IsRequired();







        builder.HasData(
            new {
                Id = 1,
                Nombre = "Mamiferos",
                EspecieId = 1,
            },
            new {
                Id = 2,
                Nombre = "Aves",
                EspecieId = 2, 
            },
            new {
                Id = 3,
                Nombre = "Reptiles",
                EspecieId = 3,
            }
        );



    }
}
