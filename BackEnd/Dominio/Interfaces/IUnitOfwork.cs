namespace Dominio.Interfaces;
    public interface IUnitOfWork{
        
        IUsuario ? Usuarios { get; }
        IRol ? Roles { get; }
        IUsuarioRoles UsuariosRoles { get; }
        ICita ? Citas { get; }
        IDetalleMovimiento ? DetalleMovimientos { get; }
        IEspecie ? Especies { get; }
        ILaboratorio ? Laboratorios { get; }
        IMascota ? Mascotas { get; }
        IMedicamento ? Medicamentos { get; }
        IMedicamentosProveedores ? MedicamentosProveedores { get; }
        IMovimientoMedicamento ? MovimientoMedicamentos { get; }
        IPropietario ? Propietarios { get; }
        IProveedor ? Proveedores { get; }
        IRaza ? Razas { get; }
        ITipoMovimiento ? TipoMovimientos { get;}
        ITratamientoMedico ? TratamientoMedicos { get; }
        IVeterinario ? Veterinarios { get; }
        Task<int> SaveAsync();
        
    }
