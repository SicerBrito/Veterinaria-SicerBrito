namespace Dominio.Entities;
    public class Proveedor : BaseEntity{
        
        public string ? NombreCompleto { get; set; }
        public string ? Direccion { get; set; }
        public string ? Telefono { get; set; }

        public ICollection<MedicamentosProveedores> ? MedicamentosProveedores { get; set; }

    }
