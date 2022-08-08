using AutoMapper;
using ListaTareas.Core.DTOs;
using ListaTareas.Core.Entities;
using ListaTareas.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ListaTareas.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TareaController : ControllerBase
    {
        private readonly ITareaRepository _tareaRepository;
        private readonly IMapper _mapper;

        public TareaController(ITareaRepository tareaRepository, IMapper mapper) 
        {
            _tareaRepository = tareaRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetTareas()
        {
            var tareas = await _tareaRepository.GetTareas();
            var tareasDto = _mapper.Map<IEnumerable<TareaDto>>(tareas);

            return Ok(tareasDto);
        }
         
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTarea(int id)
        {
            var tarea = await _tareaRepository.GetTarea(id);
            var tareaDto = _mapper.Map<TareaDto>(tarea);

            return Ok(tareaDto);
        }

        [HttpPost]
        public async Task<IActionResult> PostTarea(TareaDto tareaDto)
        {
            var tarea = _mapper.Map<Tarea>(tareaDto);
            await  _tareaRepository.PostTarea(tarea);

            return Ok(tarea);
        }

        [HttpPut]
        public async Task<IActionResult> PutTarea(TareaDto tareaDto)
        {
            var tarea = _mapper.Map<Tarea>(tareaDto);
            await _tareaRepository.PutTarea(tarea);
            return Ok(tarea);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTarea(int id)
        {
            await _tareaRepository.DeleteTarea(id);
            return Ok();
        }
    }
}
