using MatriculasAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MatriculasAPI.Data;

public class MatriculaContext : DbContext
{
    public MatriculaContext(DbContextOptions<MatriculaContext> options) : base(options)
    { }

    public DbSet<Curso> Cursos { get; set; }
    public DbSet<Inscricao> Inscricoes { get; set; }
}
