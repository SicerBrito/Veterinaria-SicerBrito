using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class CitaConfiguration : IEntityTypeConfiguration<Cita>
{
    public void Configure(EntityTypeBuilder<Cita> builder)
    {
        
        builder.ToTable("Cita");

        builder.Property(p => p.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("IdCita")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.MascotaId)
            .HasColumnName("Mascota_Id")
            .HasColumnType("int")
            .IsRequired();

        builder.HasOne(p => p.Mascotas)
            .WithMany(p => p.Citas)
            .HasForeignKey(p => p.MascotaId);

        builder.Property(p => p.FechaCita)
            .HasColumnName("FechaCita")
            .HasColumnType("DateTime")
            .IsRequired();

        builder.Property(p => p.Motivo)
            .HasColumnName("MotivoCita")
            .HasColumnType("varchar")
            .HasMaxLength(255)
            .IsRequired();

        builder.Property(p => p.VeterinarioId)
            .HasColumnName("Veterinario_Id")
            .HasColumnType("int")
            .IsRequired();

        builder.HasOne(p => p.Veterinarios)
            .WithMany(p => p.Citas)
            .HasForeignKey(p => p.VeterinarioId);





        builder.HasData(
            new {
                Id = 1,
                MascotaId = 1,
                FechaCita = new DateTime (2024,01,24,05,35,00), // YY-MM-DD HH-MM-SS
                Motivo = "Lo atropello un carro",
                VeterinarioId = 1
            },
            new {
                Id = 2,
                MascotaId = 2,
                FechaCita = new DateTime (2024,01,24,14,35,00),
                Motivo = "Le sale mucho moco por la nariz",
                VeterinarioId = 1
            },
            new {
                Id = 3,
                MascotaId = 3,
                FechaCita = new DateTime (2024,05,07,20,15,00),
                Motivo = "Extraño bulto en el costado del abdomen",
                VeterinarioId = 2
            }
        );
        
    }
}
