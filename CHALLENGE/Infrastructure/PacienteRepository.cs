using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using CHALLENGE.Domain;
using CHALLENGE.Infrastructure;

public class PacienteRepository : IPacienteRepository
{
    private readonly AppDbContext _context;

    public PacienteRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Paciente>> GetAllPacientesAsync()
    {
        return await _context.Pacientes.ToListAsync();
    }

    public async Task<Paciente> GetPacienteByIdAsync(int id)
    {
        return await _context.Pacientes.FindAsync(id);
    }

    public async Task AddPacienteAsync(Paciente paciente)
    {
        await _context.Pacientes.AddAsync(paciente);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Paciente>> GetPacientesByCadastroIdAsync(int cadastroId)
    {
        return await _context.Pacientes
            .Where(p => p.CadastroId == cadastroId)
            .ToListAsync();
    }
}