using CHALLENGE.Domain;

public interface IPacienteRepository
{
    Task<IEnumerable<Paciente>> GetAllPacientesAsync();
    Task<Paciente> GetPacienteByIdAsync(int id);
    Task AddPacienteAsync(Paciente paciente);
    Task<IEnumerable<Paciente>> GetPacientesByCadastroIdAsync(int cadastroId); 
}