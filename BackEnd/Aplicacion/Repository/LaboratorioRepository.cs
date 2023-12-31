using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia.Data;

namespace Aplicacion.Repository;
    public class LaboratorioRepository : GenericRepository<Laboratorio>, ILaboratorio{
        private readonly DbAppContext _Context;
        public LaboratorioRepository(DbAppContext context) : base(context)
        {
            _Context = context;
        }

        public override async Task<IEnumerable<Laboratorio>> GetAllAsync()
        {
            return await _Context.Set<Laboratorio>()
                                    .Include(p => p.Medicamentos)
                                    .ToListAsync();        
        }

        //!Consulta Nro.2
        public async Task<IEnumerable<Laboratorio?>> MedicamentosGenfar()
        {
            var genfar = await _Context.Laboratorios!
                .Where(m => m.Nombre == "Genfar")
                .ToListAsync();

                return genfar;
        }
}
