using Dominio.Entities;

namespace Dominio.Interfaces;
    public interface ILaboratorio : IGenericRepository<Laboratorio>{
        Task<IEnumerable<Laboratorio?>> MedicamentosGenfar();
    }
