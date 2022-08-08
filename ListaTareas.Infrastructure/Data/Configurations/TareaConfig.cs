using ListaTareas.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ListaTareas.Infrastructure.Data.Configurations
{
    public class TareaConfig : IEntityTypeConfiguration<Tarea>
    {
        public void Configure(EntityTypeBuilder<Tarea> builder)
        {
            builder.HasKey(e => e.IdTarea);

            builder.ToTable("TAREA");

            builder.Property(e => e.IdTarea)
                .HasColumnName("ID_TAREA")
                .HasColumnType("numeric(18, 0)")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.Descripcion)
                .HasColumnName("DESCRIPCION")
                .HasMaxLength(150);

            builder.Property(e => e.Estado).HasColumnName("ESTADO");

            builder.Property(e => e.FechaCreacion)
                .HasColumnName("FECHA_CREACION")
                .HasColumnType("datetime");

        }
    }
}
