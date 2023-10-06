using API.Dtos;
using API.Helpers;
using AutoMapper;
using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

    [ApiVersion("1.0")]
    [ApiVersion("1.1")]
    public class TratamientoMedicoController : BaseApiController{

        private readonly IUnitOfWork _UnitOfWork;
        private readonly IMapper _Mapper;

        public TratamientoMedicoController(IUnitOfWork unitOfWork,IMapper mapper){
            _UnitOfWork = unitOfWork;
            _Mapper = mapper;
        }

        [HttpGet]
        [MapToApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<TratamientoMedicoDto>>> Get(){
            var records = await _UnitOfWork.TratamientoMedicos!.GetAllAsync();
            return _Mapper.Map<List<TratamientoMedicoDto>>(records);
        }

        [HttpGet]
        [MapToApiVersion("1.1")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Pager<TratamientoMedicoDto>>> Get11([FromQuery] Params recordParams)
        {
            var record = await _UnitOfWork.TratamientoMedicos!.GetAllAsync(recordParams.PageIndex,recordParams.PageSize,recordParams.Search);
            var lstrecordsDto = _Mapper.Map<List<TratamientoMedicoDto>>(record.registros);
            return new Pager<TratamientoMedicoDto>(lstrecordsDto,record.totalRegistros,recordParams.PageIndex,recordParams.PageSize,recordParams.Search);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<TratamientoMedicoDto>> Get(string id)
        {
            var record = await _UnitOfWork.TratamientoMedicos!.GetByIdAsync(id);
            if (record == null){
                return NotFound();
            }
            return _Mapper.Map<TratamientoMedicoDto>(record);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<TratamientoMedico>> Post(TratamientoMedicoDto recordDto){
            var record = _Mapper.Map<TratamientoMedico>(recordDto);
            _UnitOfWork.TratamientoMedicos!.Add(record);
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
        public async Task<ActionResult<TratamientoMedicoDto>> Put(string id, [FromBody]TratamientoMedicoDto recordDto){
            if(recordDto == null)
                return NotFound();
            var records = _Mapper.Map<TratamientoMedico>(recordDto);
            _UnitOfWork.TratamientoMedicos!.Update(records);
            await _UnitOfWork.SaveAsync();
            return recordDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(string id){
            var record = await _UnitOfWork.TratamientoMedicos!.GetByIdAsync(id);
            if(record == null){
                return NotFound();
            }
            _UnitOfWork.TratamientoMedicos.Remove(record);
            await _UnitOfWork.SaveAsync();
            return NoContent();
        }

    }
