namespace API.Dtos;
    public class EspecieDto{
        public int Id { get; set; }
        public string ? Nombre { get; set; }
        public List<MascotaDto> ? Mascotas { get; set; }
        public List<RazaDto> ? Razas { get; set; }
    }
