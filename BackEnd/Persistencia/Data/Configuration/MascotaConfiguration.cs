using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class MascotaConfiguration : IEntityTypeConfiguration<Mascota>
{
    public void Configure(EntityTypeBuilder<Mascota> builder)
    {
        
        builder.ToTable("Mascota");

        builder.Property(p => p.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("IdMascota")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.Nombre)
            .HasColumnName("Nombre")
            .HasColumnType("varchar")
            .HasMaxLength(25)
            .IsRequired();

        builder.Property(p => p.FechaNacimiento)
            .HasColumnName("FechaNacimiento")
            .HasColumnType("DateTime")
            .IsRequired();

        builder.Property(p => p.PropietarioId)
            .HasColumnName("Propietario_Id")
            .HasColumnType("int")
            .IsRequired();

        builder.HasOne(p => p.Propietarios)
            .WithMany(p => p.Mascotas)
            .HasForeignKey(p => p.PropietarioId);

        builder.Property(p => p.EspecieId)
            .HasColumnName("Especie_Id")
            .HasColumnType("int")
            .IsRequired();

        builder.HasOne(p => p.Especies)
            .WithMany(p => p.Mascotas)
            .HasForeignKey(p => p.EspecieId);

        builder.Property(p => p.RazaId)
            .HasColumnName("Raza_Id")
            .HasColumnType("int")
            .IsRequired();

        builder.HasOne(p => p.Razas)
            .WithMany(p => p.Mascotas)
            .HasForeignKey(p => p.RazaId);







        builder.HasData(
            new {
                Id = 1,
                Nombre = "Pepinill0",
                FechaNacimiento = new DateTime (2024,01,24), // YY-MM-DD
                PropietarioId = 1,
                EspecieId = 1,
                RazaId = 1
            },
            new {
                Id = 2,
                Nombre = "Sparkles",
                FechaNacimiento = new DateTime (2024,01,24),
                PropietarioId = 2,
                EspecieId = 3,
                RazaId = 2
            },
            new {
                Id = 3,
                Nombre = "Brillitos",
                FechaNacimiento = new DateTime (2024,01,24),
                PropietarioId = 3,
                EspecieId = 4,
                RazaId = 3
            }
        );


    }
}
