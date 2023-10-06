namespace Dominio.Entities;
    public class Proveedor : BaseEntity{
        
        public string ? Nombre { get; set; }
        public string ? Direccion { get; set; }
        public long Telefono { get; set; }

        public ICollection<MedicamentosProveedores> ? MedicamentosProveedores { get; set; }

    }
