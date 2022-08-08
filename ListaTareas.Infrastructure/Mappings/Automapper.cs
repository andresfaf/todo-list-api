using AutoMapper;
using ListaTareas.Core.DTOs;
using ListaTareas.Core.Entities;

namespace ListaTareas.Infrastructure.Mappings
{
    public class Automapper : Profile
    {
        public Automapper()
        {
            CreateMap<Tarea, TareaDto>();
            CreateMap<TareaDto, Tarea>();
        }
    }
}
