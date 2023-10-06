using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia.Data;

namespace Aplicacion.Repository;
public class DetalleMovimientoRepository : GenericRepository<DetalleMovimiento>, IDetalleMovimiento
{
    private readonly DbAppContext _Context;
    public DetalleMovimientoRepository(DbAppContext context) : base(context)
    {
        _Context = context;
    }

        public override async Task<IEnumerable<DetalleMovimiento>> GetAllAsync()
        {
            return await _Context.Set<DetalleMovimiento>()
                                    .Include(p => p.Medicamentos)
                                    .Include(p => p.MovimientoMedicamentos)
                                    .Include(p => p.TipoMovimientos)
                                    .ToListAsync();        
        }
}
