using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia.Data;

namespace Aplicacion.Repository;
    public class MovimientoMedicamentoRepository : GenericRepository<MovimientoMedicamento>, IMovimientoMedicamento{

        private readonly DbAppContext _Context;
        public MovimientoMedicamentoRepository(DbAppContext context) : base(context)
        {
            _Context = context;
        }

        public override async Task<IEnumerable<MovimientoMedicamento>> GetAllAsync()
        {
            return await _Context.Set<MovimientoMedicamento>()
                                    .Include(p => p.Medicamentos)
                                    .Include(p => p.DetalleMovimientos)
                                    .ToListAsync();        
        }
        
    }
