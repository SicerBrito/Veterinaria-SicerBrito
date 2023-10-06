using Dominio.Entities;

namespace Dominio.Interfaces;
    public interface IPropietario : IGenericRepository<Propietario>{
        //!consulta nro.4
        Task<List<Propietario>> Propietario();
    }
