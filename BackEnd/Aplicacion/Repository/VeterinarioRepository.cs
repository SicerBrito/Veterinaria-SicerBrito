using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia.Data;

namespace Aplicacion.Repository;
    public class VeterinarioRepository : GenericRepository<Veterinario>, IVeterinario{

        private readonly DbAppContext _Context;
        public VeterinarioRepository(DbAppContext context) : base(context)
        {
            _Context = context;
        }

        public override async Task<IEnumerable<Veterinario>> GetAllAsync()
        {
            return await _Context.Set<Veterinario>()
                                    .Include(p => p.Citas)
                                    .ToListAsync();        
        }
        
    }
