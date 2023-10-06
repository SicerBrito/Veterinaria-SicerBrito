using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class ProveedorConfiguration : IEntityTypeConfiguration<Proveedor>
{
    public void Configure(EntityTypeBuilder<Proveedor> builder)
    {
                        
        builder.ToTable("Proveedor");

        builder.Property(p => p.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("IdProveedor")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.NombreCompleto)
            .HasColumnName("NombreCompleto")
            .HasColumnType("varchar")
            .HasMaxLength(255)
            .IsRequired();

        builder.Property(p => p.Direccion)
            .HasColumnName("Email")
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
                NombreCompleto = "Pablo Antonio Gimenes Ortega",
                Direccion = "Calle José Ortega y Gasset, 40 - loc.",
                Telefono = "3224546545"
            },
            new {
                Id = 2,
                NombreCompleto = "Juanita Perez Ordoñez",
                Direccion = "Calle Vitoshko Lale 16, 1618.", 
                Telefono = "3012312312"
            },
            new {
                Id = 3,
                NombreCompleto = "Konny Liseth Alucema Torres",
                Direccion = "Calle Serrano Galvache, 56.",
                Telefono = "3208818203"
            }
        );


    }
}
