namespace Dominio.Entities;
    public class Medicamento : BaseEntity{
        
        public string ? Nombre { get; set; }
        public int CantidadDisponible { get; set; }
        public long Precio { get; set; }
        public int LaboratorioId { get; set; }
        public Laboratorio ? Laboratorios { get; set; }

        public ICollection<TratamientoMedico> ? TratamientoMedicos { get; set; }
        public ICollection<MedicamentosProveedores> ? MedicamentosProveedores { get; set; }

    }
