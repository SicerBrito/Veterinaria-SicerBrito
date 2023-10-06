using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia.Data;

namespace Aplicacion.Repository;
    public class PropietarioRepository : GenericRepository<Propietario>, IPropietario{

        private readonly DbAppContext _Context;
        public PropietarioRepository(DbAppContext context) : base(context)
        {
            _Context = context;
        }

        public override async Task<IEnumerable<Propietario>> GetAllAsync()
        {
            return await _Context.Set<Propietario>()
                                    .Include(p => p.Mascotas)
                                    .ToListAsync();        
        }


        //!consulta nro.4
    public async Task<List<Propietario>> Propietario()
    {
        return await _Context.Propietarios!
            .Include(p => p.Mascotas)
            .Select(p => new Propietario
            {
                NombreCompleto = p.NombreCompleto + " ",
                Email = p.Email,
                Telefono = p.Telefono,
                Mascotas = p.Mascotas!.Select(m => new Mascota
                {
                    Nombre = m.Nombre,
                    FechaNacimiento = m.FechaNacimiento,
                }).ToList()
            })
            .ToListAsync();
    }
}
