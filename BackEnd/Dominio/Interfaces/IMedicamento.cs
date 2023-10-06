using Dominio.Entities;

namespace Dominio.Interfaces;
    public interface IMedicamento : IGenericRepository<Medicamento>{
        //!Consulta Nro.5
        Task<List<Medicamento>> medicamentomayor50000();
    }
