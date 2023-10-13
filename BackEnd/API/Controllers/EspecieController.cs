using API.Dtos;
using API.Helpers;
using AutoMapper;
using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

    [ApiVersion("1.0")]
    [ApiVersion("1.1")]
    public class EspecieController : BaseApiController{

        private readonly IUnitOfWork _UnitOfWork;
        private readonly IMapper _Mapper;

        public EspecieController(IUnitOfWork unitOfWork,IMapper mapper){
            _UnitOfWork = unitOfWork;
            _Mapper = mapper;
        }

        [HttpGet]
        [MapToApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<EspecieDto>>> Get(){
            var records = await _UnitOfWork.Especies!.GetAllAsync();
            return _Mapper.Map<List<EspecieDto>>(records);
        }

        [HttpGet("Paginacion")]
        [MapToApiVersion("1.1")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Pager<EspecieDto>>> Get11([FromQuery] Params recordParams)
        {
            var record = await _UnitOfWork.Especies!.GetAllAsync(recordParams.PageIndex,recordParams.PageSize,recordParams.Search);
            var lstrecordsDto = _Mapper.Map<List<EspecieDto>>(record.registros);
            return new Pager<EspecieDto>(lstrecordsDto,record.totalRegistros,recordParams.PageIndex,recordParams.PageSize,recordParams.Search);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<EspecieDto>> Get(string id)
        {
            var record = await _UnitOfWork.Especies!.GetByIdAsync(id);
            if (record == null){
                return NotFound();
            }
            return _Mapper.Map<EspecieDto>(record);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Especie>> Post(EspecieDto recordDto){
            var record = _Mapper.Map<Especie>(recordDto);
            _UnitOfWork.Especies!.Add(record);
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
        public async Task<ActionResult<EspecieDto>> Put(string id, [FromBody]EspecieDto recordDto){
            if(recordDto == null)
                return NotFound();
            var records = _Mapper.Map<Especie>(recordDto);
            _UnitOfWork.Especies!.Update(records);
            await _UnitOfWork.SaveAsync();
            return recordDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(string id){
            var record = await _UnitOfWork.Especies!.GetByIdAsync(id);
            if(record == null){
                return NotFound();
            }
            _UnitOfWork.Especies.Remove(record);
            await _UnitOfWork.SaveAsync();
            return NoContent();
        }

    }
