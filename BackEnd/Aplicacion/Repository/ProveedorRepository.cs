using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia.Data;

namespace Aplicacion.Repository;
    public class ProveedorRepository : GenericRepository<Proveedor>, IProveedor{

        private readonly DbAppContext _Context;
        public ProveedorRepository(DbAppContext context) : base(context)
        {
            _Context = context;
        }

        public override async Task<IEnumerable<Proveedor>> GetAllAsync()
        {
            return await _Context.Set<Proveedor>()
                                    .Include(p => p.MedicamentosProveedores)
                                    .ToListAsync();        
        }
        
    }
