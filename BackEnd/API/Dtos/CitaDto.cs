namespace API.Dtos;
    public class CitaDto{
        public int Id { get; set; }
        public int MascotaId { get; set; }
        public DateTime ? FechaCita { get; set; }
        public string ? Motivo { get; set; }
        public int VeterinarioId { get; set; }
        public List<TratamientoMedicoDto> ? TratamientoMedicos { get; set; }
    }
