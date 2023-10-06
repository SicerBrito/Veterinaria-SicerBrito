using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia.Data;

namespace Aplicacion.Repository;
    public class PropietarioRepository : GenericRepository<Propietario>, IPropietario{

        private readonly DbAppContext _Context;
        public PropietarioRepository(DbAppContext context) : base(context)
        {
            _Context = context;
        }

        public override async Task<IEnumerable<Propietario>> GetAllAsync()
        {
            return await _Context.Set<Propietario>()
                                    .Include(p => p.Mascotas)
                                    .ToListAsync();        
        }
        
    }
