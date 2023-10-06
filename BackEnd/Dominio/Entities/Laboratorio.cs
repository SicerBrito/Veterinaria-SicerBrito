namespace Dominio.Entities;
    public class Laboratorio : BaseEntity{
        
        public string ? Nombre { get; set; }
        public string ? Direccion { get; set; }
        public long Telefono { get; set; }

        public ICollection<Medicamento> ? Laboratorios { get; set; }

    }
