namespace Dominio.Entities;
    public class MedicamentosProveedores : BaseEntity{
        
        public int MedicamentoId { get; set; }
        public Medicamento ? Medicamentos { get; set; }
        public int ProveedorId { get; set; }
        public Proveedor ? Proveedores { get; set; } 

    }
