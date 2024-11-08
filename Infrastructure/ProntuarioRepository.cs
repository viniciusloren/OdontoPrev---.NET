using Microsoft.EntityFrameworkCore;
using CHALLENGE.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;
using CHALLENGE.Application;

namespace CHALLENGE.Infrastructure
{
    public class ProntuarioRepository : IProntuarioRepository
    {
        private readonly AppDbContext _context;

        public ProntuarioRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Prontuario>> GetAllProntuariosAsync()
        {
            return await _context.Prontuarios.ToListAsync();
        }

        public async Task<Prontuario> GetProntuariosByIdAsync(int id)
        {
            return await _context.Prontuarios
            .Include(p => p.Paciente) // Incluindo o paciente associado ao prontuário, se necessário
            .FirstOrDefaultAsync(p => p.Id == id); // Retorna o prontuário ou null se não encontrado
        }

        public async Task<IEnumerable<Prontuario>> GetProntuariosByPacienteIdAsync(int pacienteId)
        {
            return await _context.Prontuarios
            .Where(p => p.PacienteId == pacienteId) // Lógica para filtrar prontuários pelo PacienteId
            .ToListAsync(); // Retorna a lista filtrada
        }

        public async Task AddProntuarioAsync(Prontuario prontuario)
        {
            await _context.Prontuarios.AddAsync(prontuario);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateProntuarioAsync(Prontuario prontuario)
        {
            _context.Prontuarios.Update(prontuario);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProntuarioAsync(int id)
        {
            var prontuario = await GetProntuariosByIdAsync(id);
            if (prontuario != null)
            {
                _context.Prontuarios.Remove(prontuario);
                await _context.SaveChangesAsync();
            }
        }
    }
}