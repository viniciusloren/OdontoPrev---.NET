using CHALLENGE.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CHALLENGE.Application
{
    public interface IProntuarioRepository
    {
        Task<IEnumerable<Prontuario>> GetAllProntuariosAsync();
        Task<Prontuario> GetProntuariosByIdAsync(int id);
        Task<IEnumerable<Prontuario>> GetProntuariosByPacienteIdAsync(int pacienteId);
        Task AddProntuarioAsync(Prontuario prontuario);
        Task UpdateProntuarioAsync(Prontuario prontuario);
        Task DeleteProntuarioAsync(int id);
    }
}