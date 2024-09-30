using CHALLENGE.Domain;

namespace CHALLENGE.Application
{
    public interface IPacienteRepository
    {
        Task<IEnumerable<Paciente>> GetAllPacientesAsync();
        Task<Paciente> GetPacienteByIdAsync(int id);
        Task AddPacienteAsync(Paciente paciente);
        Task UpdatePacienteAsync(Paciente paciente);
        Task DeletePacienteAsync(int id);
    }
}