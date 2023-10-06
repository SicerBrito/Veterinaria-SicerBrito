using API.Dtos;
using API.Helpers;
using AutoMapper;
using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

    [ApiVersion("1.0")]
    [ApiVersion("1.1")]
    public class VeterinarioController : BaseApiController{

        private readonly IUnitOfWork _UnitOfWork;
        private readonly IMapper _Mapper;

        public VeterinarioController(IUnitOfWork unitOfWork,IMapper mapper){
            _UnitOfWork = unitOfWork;
            _Mapper = mapper;
        }

        [HttpGet]
        [MapToApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<VeterinarioDto>>> Get(){
            var records = await _UnitOfWork.Veterinarios!.GetAllAsync();
            return _Mapper.Map<List<VeterinarioDto>>(records);
        }

        [HttpGet]
        [MapToApiVersion("1.1")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Pager<VeterinarioDto>>> Get11([FromQuery] Params recordParams)
        {
            var record = await _UnitOfWork.Veterinarios!.GetAllAsync(recordParams.PageIndex,recordParams.PageSize,recordParams.Search);
            var lstrecordsDto = _Mapper.Map<List<VeterinarioDto>>(record.registros);
            return new Pager<VeterinarioDto>(lstrecordsDto,record.totalRegistros,recordParams.PageIndex,recordParams.PageSize,recordParams.Search);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<VeterinarioDto>> Get(string id)
        {
            var record = await _UnitOfWork.Veterinarios!.GetByIdAsync(id);
            if (record == null){
                return NotFound();
            }
            return _Mapper.Map<VeterinarioDto>(record);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Veterinario>> Post(VeterinarioDto recordDto){
            var record = _Mapper.Map<Veterinario>(recordDto);
            _UnitOfWork.Veterinarios!.Add(record);
            await _UnitOfWork.SaveAsync();
            if (record == null)
            {
                return BadRequest();
            }
            recordDto.Id = record.Id;
            return CreatedAtAction(nameof(Post),new {id= recordDto.Id}, recordDto);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<VeterinarioDto>> Put(string id, [FromBody]VeterinarioDto recordDto){
            if(recordDto == null)
                return NotFound();
            var records = _Mapper.Map<Veterinario>(recordDto);
            _UnitOfWork.Veterinarios!.Update(records);
            await _UnitOfWork.SaveAsync();
            return recordDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(string id){
            var record = await _UnitOfWork.Veterinarios!.GetByIdAsync(id);
            if(record == null){
                return NotFound();
            }
            _UnitOfWork.Veterinarios.Remove(record);
            await _UnitOfWork.SaveAsync();
            return NoContent();
        }

        //! Consulta Nro.1
        [HttpGet("especialidadCirujano")]
        public async Task<ActionResult<Veterinario>> Cirujano()
        {
            var Especialidad = await _UnitOfWork.Veterinarios!.GetVeterinarioCirujanoAsync()!;
            return Ok(Especialidad);
        }

    }
