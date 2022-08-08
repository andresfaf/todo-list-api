using ListaTareas.Core.Entities;
using ListaTareas.Core.Interfaces;
using ListaTareas.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ListaTareas.Infrastructure.Repositories
{
    public class TareaRepository : ITareaRepository
    {
        private readonly ListaTareasContext _context;
        public TareaRepository(ListaTareasContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Tarea>> GetTareas()
        {
            var tareas = await _context.Tarea.ToListAsync();
            return tareas;
        }

        public async Task<Tarea> GetTarea(int id)
        {
            var tarea = await _context.Tarea.FirstOrDefaultAsync(x=> x.IdTarea == id);
            return tarea;
        }

        public async Task PostTarea(Tarea tarea)
        {
            _context.Tarea.Add(tarea);
           await  _context.SaveChangesAsync();
        }

        public async Task<bool> PutTarea(Tarea tarea)
        {
            var currentDatos = await GetTarea((int)tarea.IdTarea);
            currentDatos.Descripcion = tarea.Descripcion;
            currentDatos.Estado = tarea.Estado;
            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }

        public async Task DeleteTarea(int id)
        {
            var tarea = await GetTarea(id);
            _context.Tarea.Remove(tarea);
            await _context.SaveChangesAsync();
        }

    }
}
