using System;

namespace ListaTareas.Core.DTOs
{
    public class TareaDto
    {
        public decimal IdTarea { get; set; }
        public decimal? IdLista { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public bool? Estado { get; set; }
    }
}
