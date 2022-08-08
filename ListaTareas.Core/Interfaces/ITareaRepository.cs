using ListaTareas.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ListaTareas.Core.Interfaces
{
    public interface ITareaRepository
    {
        Task<IEnumerable<Tarea>> GetTareas();
        Task<Tarea> GetTarea(int id);
        Task PostTarea(Tarea tarea);
        Task<bool> PutTarea(Tarea tarea);
        Task DeleteTarea(int id);
    }
}
