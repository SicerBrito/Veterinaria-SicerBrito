using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class MedicamentoConfiguration : IEntityTypeConfiguration<Medicamento>
{
    public void Configure(EntityTypeBuilder<Medicamento> builder)
    {
        
        builder.ToTable("Medicamento");

        builder.Property(p => p.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("IdMedicamento")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.Nombre)
            .HasColumnName("Nombre")
            .HasColumnType("varchar")
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(p => p.CantidadDisponible)
            .HasColumnName("CantidadDisponible")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.PrecioUnidad)
            .HasColumnName("PrecioUnidad")
            .HasColumnType("VARCHAR")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(p => p.LaboratorioId)
            .HasColumnName("Laboratorio_Id")
            .HasColumnType("int")
            .IsRequired();

        builder.HasOne(p => p.Laboratorios)
            .WithMany(p => p.Medicamentos)
            .HasForeignKey(p => p.LaboratorioId);





        
        
        builder.HasData(
            new {
                Id = 1,
                Nombre = "Aspirina",
                CantidadDisponible = 100,
                PrecioUnidad = "5000",
                LaboratorioId = 1
            },
            new {
                Id = 2,
                Nombre = "Paracetamol",
                CantidadDisponible = 250,
                PrecioUnidad = "1000",
                LaboratorioId = 2
            },
            new {
                Id = 3,
                Nombre = "Omeprazol",
                CantidadDisponible = 30,
                PrecioUnidad = "10000",
                LaboratorioId = 3
            }
        );

    }
}
