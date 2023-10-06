using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia.Data;

namespace Aplicacion.Repository;
    public class MedicamentosProveedoresRepository : GenericRepository<MedicamentosProveedores>, IMedicamentosProveedores{

        private readonly DbAppContext _Context;
        public MedicamentosProveedoresRepository(DbAppContext context) : base(context)
        {
            _Context = context;
        }

        public override async Task<IEnumerable<MedicamentosProveedores>> GetAllAsync()
        {
            return await _Context.Set<MedicamentosProveedores>()
                                    .Include(p => p.Medicamentos)
                                    .Include(p => p.Proveedores)
                                    .ToListAsync();        
        }
        
    }
