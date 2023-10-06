namespace API.Dtos;
    public class MedicamentoDto{
        public int Id { get; set; }
        public string ? Nombre { get; set; }
        public int CantidadDisponible { get; set; }
        public string ? PrecioUnidad { get; set; }
        public int LaboratorioId { get; set; }

        public List<TratamientoMedicoDto> ? TratamientoMedicos { get; set; }
        public List<MedicamentosProveedoresDto> ? MedicamentosProveedores { get; set; }
        public List<MovimientoMedicamentoDto> ? MovimientoMedicamentos { get; set; }
        public List<DetalleMovimientoDto> ? DetalleMovimientos { get; set; }
    }
