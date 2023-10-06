namespace Dominio.Entities;
    public class MovimientoMedicamento : BaseEntity{
        
        public int ProductoId { get; set; }
        public Medicamento ? Medicamentos { get; set; }
        public int Cantidad { get; set; }
        public DateTime ? FechaMovimiento { get; set; }

        public ICollection<DetalleMovimiento> ? DetalleMovimientos { get; set; }

    }
