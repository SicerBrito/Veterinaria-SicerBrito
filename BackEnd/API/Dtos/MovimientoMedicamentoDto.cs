namespace API.Dtos;
    public class MovimientoMedicamentoDto{
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public DateTime ? FechaMovimiento { get; set; }

        public List<DetalleMovimientoDto> ? DetalleMovimientos { get; set; }
    }
