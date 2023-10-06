using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class LaboratorioConfiguration : IEntityTypeConfiguration<Laboratorio>
{
    public void Configure(EntityTypeBuilder<Laboratorio> builder)
    {
        
        builder.ToTable("Laboratorio");

        builder.Property(p => p.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("IdLaboratorio")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.Nombre)
            .HasColumnName("Nombre")
            .HasColumnType("varchar")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(p => p.Direccion)
            .HasColumnName("Direccion")
            .HasColumnType("varchar")
            .HasMaxLength(255)
            .IsRequired();

        builder.Property(p => p.Telefono)
            .HasColumnName("Telefono")
            .HasColumnType("VARCHAR")
            .HasMaxLength(25)
            .IsRequired();





        builder.HasData(
            new {
                Id = 1,
                Nombre = "Genfar",
                Direccion = "Cl 58 #8-41, Bucaramanga, Girón, Bucaramanga, Santander",
                Telefono = "3145674323"
            },
            new {
                Id = 2,
                Nombre = "Laboratorio clínico Higuera Escalante",
                Direccion = "Cl. 158, Floridablanca, Santander",
                Telefono = "3165374321"
            },
            new {
                Id = 3,
                Nombre = "Megalab Laboratorio",
                Direccion = "Cra. 24 #154 - 106, Floridablanca, Santander",
                Telefono = "3209894353"
            }
        );


    }
}
