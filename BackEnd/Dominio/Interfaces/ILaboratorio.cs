using Dominio.Entities;

namespace Dominio.Interfaces;
    public interface ILaboratorio : IGenericRepository<Laboratorio>{
        //!Consulta Nro.2
        Task<IEnumerable<Laboratorio?>> MedicamentosGenfar();
    }
