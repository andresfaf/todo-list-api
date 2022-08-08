using ListaTareas.Core.Entities;
using ListaTareas.Infrastructure.Data.Configurations;
using Microsoft.EntityFrameworkCore;

namespace ListaTareas.Infrastructure.Data
{
    public partial class ListaTareasContext : DbContext
    {
        public ListaTareasContext()
        {
        }

        public ListaTareasContext(DbContextOptions<ListaTareasContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Tarea> Tarea { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TareaConfig());
        }
    }
}
