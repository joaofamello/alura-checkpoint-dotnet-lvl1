namespace MatriculasAPI.Models;

public class Inscricao
{
    private string _status = "Ativo";
    public int Id { get; set; }
    public string Status 
    { 
        get => _status; 
        set
        {
            if(value != "Ativo" && value != "Cancelado")
            {
                throw new ArgumentException("Status deve ser 'Ativo' ou 'Cancelado'.");
            }
        } 
    }
    public DateOnly DataMatricula { get; set; }
}
