namespace Dominio.Entities;
    public class Cita : BaseEntity{
        
        public int MascotaId { get; set; }
        public Mascota ? Mascotas { get; set; }
        public DateTime ? FechaCita { get; set; }
        public string ? Motivo { get; set; }
        public int VeterinarioId { get; set; }
        public Veterinario ? Veterinarios { get; set; }

        public ICollection<TratamientoMedico> ? TratamientoMedicos { get; set; }

    }
