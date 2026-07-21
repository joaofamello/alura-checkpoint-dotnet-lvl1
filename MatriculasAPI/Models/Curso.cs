namespace MatriculasAPI.Models;

public class Curso
{
    public string Titulo { get; set; }
    public string Descricao { get; set; }
    public string Categoria { get; set; }
    public int CargaHoraria { get; set; }
    public DateOnly DataCadastro { get; set; }
}
