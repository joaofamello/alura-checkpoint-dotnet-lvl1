using Microsoft.AspNetCore.Identity;

namespace MatriculasAPI.Models;

public class Estudante : IdentityUser
{
    public string NomeCompleto { get; set; }
    public DateOnly DataCadastro { get; set; }
}
