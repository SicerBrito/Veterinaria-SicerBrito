using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class MovimientoMedicamentoConfiguration : IEntityTypeConfiguration<MovimientoMedicamento>
{
    public void Configure(EntityTypeBuilder<MovimientoMedicamento> builder)
    {
                
        builder.ToTable("MovimientoMedicamento");

        builder.Property(p => p.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("IdMovimientoMedicamento")
            .HasColumnType("int")
            .IsRequired();


        builder.Property(p => p.ProductoId)
            .HasColumnName("Producto_Id")
            .HasColumnType("int")
            .IsRequired();

        builder.HasOne(p => p.Medicamentos)
            .WithMany(p => p.MovimientoMedicamentos)
            .HasForeignKey(p => p.ProductoId);

        builder.Property(p => p.Cantidad)
            .HasColumnName("Cantidad")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.FechaMovimiento)
            .HasColumnName("FechaMovimiento")
            .HasColumnType("DateTime")
            .IsRequired();






        builder.HasData(
            new {
                Id = 1,
                ProductoId = 1,
                Cantidad = 20,
                FechaMovimiento = new DateTime (2023,12,15)
            },
            new {
                Id = 2,
                ProductoId = 3,
                Cantidad = 50,
                FechaMovimiento = new DateTime (2024,02,25)
            },
            new {
                Id = 3,
                ProductoId = 2,
                Cantidad = 10,
                FechaMovimiento =  new DateTime (2024,08,28)
            }
        );


    }
}
