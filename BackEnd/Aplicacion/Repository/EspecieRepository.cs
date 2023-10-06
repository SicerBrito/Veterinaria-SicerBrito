using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia.Data;

namespace Aplicacion.Repository;
    public class EspecieRepository : GenericRepository<Especie>, IEspecie{
        private readonly DbAppContext _Context;
        public EspecieRepository(DbAppContext context) : base(context)
        {
            _Context = context;
        }

            public override async Task<IEnumerable<Especie>> GetAllAsync()
            {
                return await _Context.Set<Especie>()
                                        .Include(p => p.Mascotas)
                                        .Include(p => p.Razas)
                                        .ToListAsync();        
            }
    }
