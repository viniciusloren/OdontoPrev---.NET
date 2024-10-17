using CHALLENGE.Domain;

namespace CHALLENGE.Application;

public interface ICadastroRepository
{
    Task<IEnumerable<Cadastro>> GetAllCadastrosAsync();
    Task<Cadastro> GetCadastroByIdAsync(int id);
    Task AddCadastroAsync(Cadastro cadastro);
}