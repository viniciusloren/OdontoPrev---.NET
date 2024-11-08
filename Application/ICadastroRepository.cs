using CHALLENGE.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CHALLENGE.Application
{
    public interface ICadastroRepository
    {
        Task<IEnumerable<Cadastro>> GetAllUsuariosAsync();   
        Task<Cadastro> GetUsuarioByIdAsync(int id);           
        Task AddUsuarioAsync(Cadastro cadastro); 
        Task UpdateUsuarioAsync(Cadastro cadastro);
        Task DeleteUsuarioAsync(int id); 
    }
}