namespace Dominio.Entities;
    public class Medicamento : BaseEntity{
        
        public string ? Nombre { get; set; }
        public int CantidadDisponible { get; set; }
        public string ? PrecioUnidad { get; set; }
        public int LaboratorioId { get; set; }
        public Laboratorio ? Laboratorios { get; set; }

        public ICollection<TratamientoMedico> ? TratamientoMedicos { get; set; }
        public ICollection<MedicamentosProveedores> ? MedicamentosProveedores { get; set; }
        public ICollection<MovimientoMedicamento> ? MovimientoMedicamentos { get; set; }
        public ICollection<DetalleMovimiento> ? DetalleMovimientos { get; set; }

    }
