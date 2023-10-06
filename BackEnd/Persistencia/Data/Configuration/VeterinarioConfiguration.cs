using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class VeterinarioConfiguration : IEntityTypeConfiguration<Veterinario>
{
    public void Configure(EntityTypeBuilder<Veterinario> builder)
    {
                
        builder.ToTable("Veterinario");

        builder.Property(p => p.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("IdVeterinario")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.NombreCompleto)
            .HasColumnName("NombreCompleto")
            .HasColumnType("varchar")
            .HasMaxLength(255)
            .IsRequired();

        builder.Property(p => p.Email)
            .HasColumnName("Email")
            .HasColumnType("varchar")
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(p => p.Telefono)
            .HasColumnName("Telefono")
            .HasColumnType("VARCHAR")
            .HasMaxLength(25)
            .IsRequired();

        builder.Property(p => p.Especialidad)
            .HasColumnName("Especialidad")
            .HasColumnType("varchar")
            .HasMaxLength(30)
            .IsRequired();






        builder.HasData(
            new {
                Id = 1,
                NombreCompleto = "Juan Eduardo Carrasquilla",
                Email = "EduardoCarrasquilla@gmail.com",
                Telefono = "3203453432",
                Especialidad = "Cirujano",
            },
            new {
                Id = 2,
                NombreCompleto = "Juan Jesus Gutierrez Ariza",
                Email = "JuanAriza@gmail.com",
                Telefono = "3167194381",
                Especialidad = "Rehabilitacion",
            },
            new {
                Id = 3,
                NombreCompleto = "Maria Angrelica Morales Silva",
                Email = "angelicamorales@gmail.com",
                Telefono = "3013238789",
                Especialidad = "Fisioterapia",
            },
            new {
                Id = 4,
                NombreCompleto = "Pepito Pelas Giral",
                Email = "PepitoGiral@gmail.com",
                Telefono = "3228878976",
                Especialidad = "Oncologia",
            }
        );


    }
}
