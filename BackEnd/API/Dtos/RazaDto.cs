namespace API.Dtos;
    public class RazaDto{
        public int Id { get; set; }
        public string ? Nombre { get; set; }
        public int EspecieId { get; set; }

        public List<MascotaDto> ? Mascotas { get; set; }
    }
