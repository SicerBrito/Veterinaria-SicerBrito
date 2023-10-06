using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia.Data;

namespace Aplicacion.Repository;
    public class TratamientoMedicoRepository : GenericRepository<TratamientoMedico>, ITratamientoMedico{

        private readonly DbAppContext _Context;
        public TratamientoMedicoRepository(DbAppContext context) : base(context)
        {
            _Context = context;
        }

        public override async Task<IEnumerable<TratamientoMedico>> GetAllAsync()
        {
            return await _Context.Set<TratamientoMedico>()
                                    .Include(p => p.Citas)
                                    .Include(p => p.Medicamentos)
                                    .ToListAsync();        
        }
        
    }
