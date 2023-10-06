namespace Dominio.Entities;
    public class Propietario : BaseEntity{
        
        public string ? NombreCompleto { get; set; }
        public string ? Email { get; set; }
        public string ? Telefono { get; set; }

        public ICollection<Mascota> ? Mascotas { get; set; }

    }
