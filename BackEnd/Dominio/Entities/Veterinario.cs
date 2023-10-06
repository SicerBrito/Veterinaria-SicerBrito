namespace Dominio.Entities;
    public class Veterinario : BaseEntity{
        
        public string ? Nombre { get; set; }
        public string ? Email { get; set; }
        public long Telefono { get; set; }
        public string ? Especialidad { get; set; }

        public ICollection<Cita> ? Citas { get; set; }

    }
