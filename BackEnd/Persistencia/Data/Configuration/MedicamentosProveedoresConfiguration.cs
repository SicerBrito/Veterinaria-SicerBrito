using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class MedicamentosProveedoresConfiguration : IEntityTypeConfiguration<MedicamentosProveedores>
{
    public void Configure(EntityTypeBuilder<MedicamentosProveedores> builder)
    {
                
        builder.ToTable("MedicamentosProveedores");

        builder.Property(p => p.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("IdMedicamentosProveedores")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.MedicamentoId)
            .HasColumnName("Medicamento_Id")
            .HasColumnType("int")
            .IsRequired();

        builder.HasOne(p => p.Medicamentos)
            .WithMany(p => p.MedicamentosProveedores)
            .HasForeignKey(p => p.MedicamentoId);

        builder.Property(p => p.ProveedorId)
            .HasColumnName("Proveedor_Id")
            .HasColumnType("int")
            .IsRequired();

        builder.HasOne(p => p.Proveedores)
            .WithMany(p => p.MedicamentosProveedores)
            .HasForeignKey(p => p.ProveedorId);




        builder.HasData(
            new {
                Id = 1,
                MedicamentoId = 1,
                ProveedorId = 1
            },
            new {
                Id = 2,
                MedicamentoId = 2,
                ProveedorId = 2
            },
            new {
                Id = 3,
                MedicamentoId = 3,
                ProveedorId = 3
            }
        );


    }
}
