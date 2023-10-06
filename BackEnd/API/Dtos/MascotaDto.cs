namespace API.Dtos;
    public class MascotaDto{
        public int Id { get; set; }
        public string ? Nombre { get; set; }
        public DateTime ? FechaNacimiento { get; set; }
        public int PropietarioId { get; set; }
        public int EspecieId { get; set; }
        public int RazaId { get; set; }

        public List<CitaDto> ? Citas { get; set; }
    }
