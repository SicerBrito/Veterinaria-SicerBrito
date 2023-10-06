using API.Dtos;
using API.Dtos.Generic;
using AutoMapper;
using Dominio.Entities;

namespace API.Profiles;
    public class MappingProfile : Profile{
        public MappingProfile(){

            CreateMap<Rol, RolDto>()
                .ReverseMap();

            CreateMap<Usuario, UsuarioDto>()
                .ReverseMap();

            CreateMap<Cita, CitaDto>()
                .ReverseMap();

            CreateMap<DetalleMovimiento, DetalleMovimientoDto>()
                .ReverseMap();

            CreateMap<Especie, EspecieDto>()
                .ReverseMap();

            CreateMap<Laboratorio, LaboratorioDto>()
                .ReverseMap();

            CreateMap<Mascota, MascotaDto>()
                .ReverseMap();

            CreateMap<Medicamento, MedicamentoDto>()
                .ReverseMap();

            CreateMap<MedicamentosProveedores, MedicamentosProveedoresDto>()
                .ReverseMap();

            CreateMap<MovimientoMedicamento, MovimientoMedicamentoDto>()
                .ReverseMap();

            CreateMap<Propietario, PropietarioDto>()
                .ReverseMap();

            CreateMap<Proveedor, ProveedorDto>()
                .ReverseMap();

            CreateMap<Raza, RazaDto>()
                .ReverseMap();

            CreateMap<TipoMovimiento, TipoMovimientoDto>()
                .ReverseMap();

            CreateMap<TratamientoMedico, TratamientoMedicoDto>()
                .ReverseMap();

            CreateMap<Veterinario, VeterinarioDto>()
                .ReverseMap();

        }
    }
