using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia.Data;

namespace Aplicacion.Repository;
    public class RazaRepository : GenericRepository<Raza>, IRaza{

        private readonly DbAppContext _Context;
        public RazaRepository(DbAppContext context) : base(context)
        {
            _Context = context;
        }

        public override async Task<IEnumerable<Raza>> GetAllAsync()
        {
            return await _Context.Set<Raza>()
                                    .Include(p => p.Especies)
                                    .Include(p => p.Mascotas)
                                    .ToListAsync();        
        }
        
    }
