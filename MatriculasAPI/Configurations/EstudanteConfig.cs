using Microsoft.EntityFrameworkCore;

namespace MatriculasAPI.Configurations
{
    public class EstudanteConfig : IEntityTypeConfiguration<Estudante>
    {
        public void Configura(EntityTypeBuilder<Estudante> builder)
        {
            builder.Property(e => e.NomeCompleto)
                .IsRequired()
                .HasMaxLength(150);
        }
    }
}
