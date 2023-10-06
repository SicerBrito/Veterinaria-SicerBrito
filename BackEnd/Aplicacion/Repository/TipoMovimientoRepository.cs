using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia.Data;

namespace Aplicacion.Repository;
    public class TipoMovimientoRepository : GenericRepository<TipoMovimiento>, ITipoMovimiento{

        private readonly DbAppContext _Context;
        public TipoMovimientoRepository(DbAppContext context) : base(context)
        {
            _Context = context;
        }

        public override async Task<IEnumerable<TipoMovimiento>> GetAllAsync()
        {
            return await _Context.Set<TipoMovimiento>()
                                    .Include(p => p.DetalleMovimientos)
                                    .ToListAsync();        
        }
        
    }
