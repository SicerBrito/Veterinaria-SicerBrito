using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia.Data;

namespace Aplicacion.Repository;
    public class CitaRepository : GenericRepository<Cita>, ICita{
        
        private readonly DbAppContext _Context;
        public CitaRepository(DbAppContext context) : base(context)
        {
            _Context = context;
        }

        public override async Task<IEnumerable<Cita>> GetAllAsync()
        {
            return await _Context.Set<Cita>()
                                    .Include(p => p.Mascotas)
                                    .Include(p => p.Veterinarios)
                                    .Include(p => p.TratamientoMedicos)
                                    .ToListAsync();        
        }

    }
