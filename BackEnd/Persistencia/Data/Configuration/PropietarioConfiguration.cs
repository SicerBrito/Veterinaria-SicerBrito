using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class PropietarioConfiguration : IEntityTypeConfiguration<Propietario>
{
    public void Configure(EntityTypeBuilder<Propietario> builder)
    {
                
        builder.ToTable("Propietario");

        builder.Property(p => p.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("IdPropietario")
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
            .HasMaxLength(255)
            .IsRequired();

        builder.Property(p => p.Telefono)
            .HasColumnName("Telefono")
            .HasColumnType("VARCHAR")
            .HasMaxLength(50)
            .IsRequired();







        builder.HasData(
            new {
                Id = 1,
                NombreCompleto = "Juan Andres Lisarazo Ordoñez",
                Email = "JuanOrdoñez@gmail.com",
                Telefono = "3224546545"
            },
            new {
                Id = 2,
                NombreCompleto = "Pepito Perez Salamez",
                Email = "PepitoSalamez@gmail.com", 
                Telefono = "3012312312"
            },
            new {
                Id = 3,
                NombreCompleto = "Sicer Andres Brito Gutierrez",
                Email = "britodelgado514@gmail.com",
                Telefono = "3208818203"
            }
        );



    }
}
