using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class TipoMovimientoConfiguration : IEntityTypeConfiguration<TipoMovimiento>
{
    public void Configure(EntityTypeBuilder<TipoMovimiento> builder)
    {
        
        builder.ToTable("TipoMovimiento");

        builder.Property(p => p.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("IdTipoMovimiento")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.Descripcion)
            .HasColumnName("Descripcion")
            .HasColumnType("varchar")
            .HasMaxLength(255)
            .IsRequired();



        builder.HasData(
            new {
                Id = 1,
                Descripcion = "Recepcion",
            },
            new {
                Id = 2,
                Descripcion = "Envio",
            },
            new {
                Id = 3,
                Descripcion = "Preparacion de pedidos",
            },
            new {
                Id = 4,
                Descripcion = "Intercambio de muelles",
            }
        );


    }
}
