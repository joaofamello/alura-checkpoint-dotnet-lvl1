using Microsoft.EntityFrameworkCore;

namespace MatriculasAPI.Configurations
{
    public class CursoConfig : IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Titulo)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasIndex(c => c.Titulo);

            builder.HasCheckConstraint("CK_Curso_CargaHoraria", "\"CargaHoraria\" > 0");
        }
    }
}
