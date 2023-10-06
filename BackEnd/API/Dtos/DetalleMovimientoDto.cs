namespace API.Dtos;
    public class DetalleMovimientoDto{
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public int MovimientoMedicamentoId { get; set; }
        public int TipoMovimientoId { get; set; }
        public string ? PrecioTotal { get; set; }  
    }
