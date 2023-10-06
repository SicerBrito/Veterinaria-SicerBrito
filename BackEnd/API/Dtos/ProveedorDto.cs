namespace API.Dtos;
    public class ProveedorDto{
        public int Id { get; set; }
        public string ? NombreCompleto { get; set; }
        public string ? Direccion { get; set; }
        public string ? Telefono { get; set; }

        public List<MedicamentosProveedoresDto> ? MedicamentosProveedores { get; set; }
    }
