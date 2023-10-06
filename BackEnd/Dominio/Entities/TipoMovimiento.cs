namespace Dominio.Entities;
    public class TipoMovimiento : BaseEntity{
        
        public string ? Descripcion { get; set; }

        public ICollection<DetalleMovimiento> ? DetalleMovimientos { get; set; }

    }
