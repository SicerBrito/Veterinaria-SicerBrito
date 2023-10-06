using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class TratamientoMedicoConfiguration : IEntityTypeConfiguration<TratamientoMedico>
{
    public void Configure(EntityTypeBuilder<TratamientoMedico> builder)
    {

        
        builder.ToTable("TratamientoMedico");

        builder.Property(p => p.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("IdTratamientoMedico")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.CitaId)
            .HasColumnName("Cita_Id")
            .HasColumnType("int")
            .IsRequired();

        builder.HasOne(p => p.Citas)
            .WithMany(p => p.TratamientoMedicos)
            .HasForeignKey(p => p.CitaId);

        builder.Property(p => p.MedicamentoId)
            .HasColumnName("Medicamento_Id")
            .HasColumnType("int")
            .IsRequired();

        builder.HasOne(p => p.Medicamentos)
            .WithMany(p => p.TratamientoMedicos)
            .HasForeignKey(p => p.MedicamentoId);

        builder.Property(p => p.CantidadDosis)
            .HasColumnName("CantidadDosis")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.CantidadDias)
            .HasColumnName("CantidadDias")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.FechaAdministracion)
            .HasColumnName("FechaAdministracion")
            .HasColumnType("DateTime")
            .IsRequired();

        builder.Property(p => p.Observacion)
            .HasColumnName("Observacion")
            .HasColumnType("varchar")
            .HasMaxLength(255)
            .IsRequired();
        
        builder.HasData(
            new {
                Id = 1,
                CitaId = 1,
                MedicamentoId = 1,
                CantidadDosis = 800,
                CantidadDias = 30,
                FechaAdministracion = new DateTime (2023,04,13),
                Observacion = ""
            },
            new {
                Id = 2,
                CitaId = 2,
                MedicamentoId = 2,
                CantidadDosis = 1200,
                CantidadDias = 15,
                FechaAdministracion = new DateTime (2023,06,03),
                Observacion = ""
            },
            new {
                Id = 3,
                CitaId = 3,
                MedicamentoId = 3,
                CantidadDosis = 500,
                CantidadDias = 7,
                FechaAdministracion = new DateTime (2023,01,28),
                Observacion = ""
            },
            new {
                Id = 4,
                CitaId = 3,
                MedicamentoId = 1,
                CantidadDosis = 150,
                CantidadDias = 21,
                FechaAdministracion = new DateTime (2023,10,23),
                Observacion = ""
            }
        );
    }
}
