using API.Dtos;
using API.Helpers;
using AutoMapper;
using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

    [ApiVersion("1.0")]
    [ApiVersion("1.1")]
    public class MovimientoMedicamentoController : BaseApiController{

        private readonly IUnitOfWork _UnitOfWork;
        private readonly IMapper _Mapper;

        public MovimientoMedicamentoController(IUnitOfWork unitOfWork,IMapper mapper){
            _UnitOfWork = unitOfWork;
            _Mapper = mapper;
        }

        [HttpGet]
        [MapToApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<MovimientoMedicamentoDto>>> Get(){
            var records = await _UnitOfWork.MovimientoMedicamentos!.GetAllAsync();
            return _Mapper.Map<List<MovimientoMedicamentoDto>>(records);
        }

        [HttpGet]
        [MapToApiVersion("1.1")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Pager<MovimientoMedicamentoDto>>> Get11([FromQuery] Params recordParams)
        {
            var record = await _UnitOfWork.MovimientoMedicamentos!.GetAllAsync(recordParams.PageIndex,recordParams.PageSize,recordParams.Search);
            var lstrecordsDto = _Mapper.Map<List<MovimientoMedicamentoDto>>(record.registros);
            return new Pager<MovimientoMedicamentoDto>(lstrecordsDto,record.totalRegistros,recordParams.PageIndex,recordParams.PageSize,recordParams.Search);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<MovimientoMedicamentoDto>> Get(string id)
        {
            var record = await _UnitOfWork.MovimientoMedicamentos!.GetByIdAsync(id);
            if (record == null){
                return NotFound();
            }
            return _Mapper.Map<MovimientoMedicamentoDto>(record);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<MovimientoMedicamento>> Post(MovimientoMedicamentoDto recordDto){
            var record = _Mapper.Map<MovimientoMedicamento>(recordDto);
            _UnitOfWork.MovimientoMedicamentos!.Add(record);
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
        public async Task<ActionResult<MovimientoMedicamentoDto>> Put(string id, [FromBody]MovimientoMedicamentoDto recordDto){
            if(recordDto == null)
                return NotFound();
            var records = _Mapper.Map<MovimientoMedicamento>(recordDto);
            _UnitOfWork.MovimientoMedicamentos!.Update(records);
            await _UnitOfWork.SaveAsync();
            return recordDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(string id){
            var record = await _UnitOfWork.MovimientoMedicamentos!.GetByIdAsync(id);
            if(record == null){
                return NotFound();
            }
            _UnitOfWork.MovimientoMedicamentos.Remove(record);
            await _UnitOfWork.SaveAsync();
            return NoContent();
        }

    }
