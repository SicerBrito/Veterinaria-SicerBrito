namespace Dominio.Entities;
    public class Raza : BaseEntity{
        
        public string ? Nombre { get; set; }
        public string ? Especie { get; set; }
        public Especie ? Especies { get; set; }

        public ICollection<Mascota> ? Mascotas { get; set; }

    }
