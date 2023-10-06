using Dominio.Entities;

namespace Dominio.Interfaces;
    public interface IVeterinario : IGenericRepository<Veterinario>{
        
        //! Consulta Nro.1
        Task<IEnumerable<Veterinario?>> ? GetVeterinarioCirujanoAsync();
}
