using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia.Data;

namespace Aplicacion.Repository;
    public class MedicamentoRepository : GenericRepository<Medicamento>, IMedicamento{
        private readonly DbAppContext _Context;
        public MedicamentoRepository(DbAppContext context) : base(context)
        {
            _Context = context;
        }

        public override async Task<IEnumerable<Medicamento>> GetAllAsync()
        {
            return await _Context.Set<Medicamento>()
                                    .Include(p => p.Laboratorios)
                                    .Include(p => p.TratamientoMedicos)
                                    .Include(p => p.MedicamentosProveedores)
                                    .Include(p => p.MovimientoMedicamentos)
                                    .Include(p => p.DetalleMovimientos)
                                    .ToListAsync();        
        }


    //!Consulta Nro.5
    public async Task<List<Medicamento>> medicamentomayor50000()
    {
        var medicamentos = await _Context.Medicamentos!
            .Where(m => (Convert.ToDouble(m.PrecioUnidad)) > 50000)
            .ToListAsync();

        return medicamentos;
    }
}
