using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class DetalleMovimientoConfiguration : IEntityTypeConfiguration<DetalleMovimiento>
{
    public void Configure(EntityTypeBuilder<DetalleMovimiento> builder)
    {
        
        builder.ToTable("DetalleMovimiento");

        builder.Property(p => p.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("IdDetalleMovimiento")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.ProductoId)
            .HasColumnName("Producto_Id")
            .HasColumnType("int")
            .IsRequired();

        builder.HasOne(p => p.Medicamentos)
            .WithMany(p => p.DetalleMovimientos)
            .HasForeignKey(p => p.ProductoId);
        
        builder.Property(p => p.Cantidad)
            .HasColumnName("Cantidad")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.MovimientoMedicamentoId)
            .HasColumnName("MovimientoMedicamento_Id")
            .HasColumnType("int")
            .IsRequired();

        builder.HasOne(p => p.MovimientoMedicamentos)
            .WithMany(p => p.DetalleMovimientos)
            .HasForeignKey(p => p.MovimientoMedicamentoId);

        builder.Property(p => p.TipoMovimientoId)
            .HasColumnName("TipoMovimiento_Id")
            .HasColumnType("int")
            .IsRequired();

        builder.HasOne(p => p.TipoMovimientos)
            .WithMany(p => p.DetalleMovimientos)
            .HasForeignKey(p => p.TipoMovimientoId);

        builder.Property(p => p.PrecioTotal)
            .HasColumnName("PrecioTotal")
            .HasColumnType("VARCHAR")
            .HasMaxLength(50)
            .IsRequired();





        builder.HasData(
            new {
                Id = 1,
                ProductoId = 1,
                Cantidad = 6,
                MovimientoMedicamentoId = 1,
                TipoMovimientoId = 1,
                PrecioTotal = "60000"
            },
            new {
                Id = 2,
                ProductoId = 2,
                Cantidad = 2,
                MovimientoMedicamentoId = 2,
                TipoMovimientoId = 2,
                PrecioTotal = "10000"
            },
            new {
                Id = 3,
                ProductoId = 3,
                Cantidad = 10,
                MovimientoMedicamentoId = 3,
                TipoMovimientoId = 2,
                PrecioTotal = "100000"
            }
        );


    }
}
