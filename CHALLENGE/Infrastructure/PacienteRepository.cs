using CHALLENGE.Application;
using CHALLENGE.Domain;
using Microsoft.EntityFrameworkCore;

namespace CHALLENGE.Infrastructure
{
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
            _context.Pacientes.Add(paciente);
            await _context.SaveChangesAsync();
        }

        public async Task UpdatePacienteAsync(Paciente paciente)
        {
            _context.Pacientes.Update(paciente);
            await _context.SaveChangesAsync();
        }

        public async Task DeletePacienteAsync(int id)
        {
            var paciente = await _context.Pacientes.FindAsync(id);
            if (paciente != null)
            {
                _context.Pacientes.Remove(paciente);
                await _context.SaveChangesAsync();
            }
        }
    }
}