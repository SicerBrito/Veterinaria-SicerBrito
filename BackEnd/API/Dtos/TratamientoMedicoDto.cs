namespace API.Dtos;
    public class TratamientoMedicoDto{
        public int Id { get; set; }
        public int CitaId { get; set; }
        public int MedicamentoId { get; set; }
        public int CantidadDosis { get; set; }
        public int CantidadDias { get; set; }
        public DateTime ? FechaAdministracion { get; set; }
        public string ? Observacion { get; set; }
    }
