using System;

namespace ListaTareas.Core.Entities
{
    public partial class Tarea
    {
        public decimal IdTarea { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public bool? Estado { get; set; }

    }
}
