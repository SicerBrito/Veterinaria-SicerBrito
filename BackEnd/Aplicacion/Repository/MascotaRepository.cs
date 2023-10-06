using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia.Data;

namespace Aplicacion.Repository;
    public class MascotaRepository : GenericRepository<Mascota>, IMascota{
        private readonly DbAppContext _Context;
        public MascotaRepository(DbAppContext context) : base(context)
        {
            _Context = context;
        }

        public override async Task<IEnumerable<Mascota>> GetAllAsync()
        {
            return await _Context.Set<Mascota>()
                                    .Include(p => p.Propietarios)
                                    .Include(p => p.Especies)
                                    .Include(p => p.Razas)
                                    .Include(p => p.Citas)
                                    .ToListAsync();        
        }


}
