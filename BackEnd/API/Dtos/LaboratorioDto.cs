namespace API.Dtos;
    public class LaboratorioDto{
        public int Id { get; set; }
        public string ? Nombre { get; set; }
        public string ? Direccion { get; set; }
        public string ? Telefono { get; set; }

        public List<MedicamentoDto> ? Medicamentos { get; set; }
    }
