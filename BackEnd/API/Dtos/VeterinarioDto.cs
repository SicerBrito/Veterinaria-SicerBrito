namespace API.Dtos;
    public class VeterinarioDto{
        public int Id { get; set; }
        public string ? NombreCompleto { get; set; }
        public string ? Email { get; set; }
        public string ? Telefono { get; set; }
        public string ? Especialidad { get; set; }

        public List<CitaDto> ? Citas { get; set; }
    }
