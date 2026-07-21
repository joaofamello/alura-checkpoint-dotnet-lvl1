using MatriculasAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MatriculasAPI.Configurations
{
    public class MatriculaConfig : IEntityTypeConfiguration<Matricula>
    {
        public void Configure(EntityTypeBuilder<Matricula> builder)
        {
            builder.HasKey(m => new { m.EstudanteId, m.CursoId });

            builder.Property(m => m.DataMatricula)
                .HasDefaultValueSql("GETDATE()"); // NOW() se for PostgreSQL, GETDATE() se for SQL Server

            builder.HasOne(m => m.Estudante)
                .WithMany(e => e.Matriculas)
                .HasForeignKey(m => m.EstudanteId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(m => m.Curso)
                .WithMany(c => c.Matriculas)
                .HasForeignKey(m => m.CursoId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
