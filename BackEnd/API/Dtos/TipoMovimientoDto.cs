namespace API.Dtos;
    public class TipoMovimientoDto{
        public int Id { get; set; }
        public string ? Descripcion { get; set; }

        public List<DetalleMovimientoDto> ? DetalleMovimientos { get; set; }
    }
