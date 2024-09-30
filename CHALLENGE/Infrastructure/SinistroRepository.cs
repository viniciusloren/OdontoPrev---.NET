using System.Collections.Generic;
using System.Threading.Tasks;
using CHALLENGE.Domain;
using CHALLENGE.Application; // Certifique-se de que o namespace está correto
using Microsoft.EntityFrameworkCore;

namespace CHALLENGE.Infrastructure
{
    public class SinistroRepository : ISinistroRepository
    {
        private readonly AppDbContext _context;

        public SinistroRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Sinistro>> GetAllSinistrosAsync()
        {
            return await _context.Sinistros.ToListAsync();
        }

        public async Task<Sinistro> GetSinistroByIdAsync(int id)
        {
            return await _context.Sinistros.FindAsync(id);
        }

        public async Task AddSinistroAsync(Sinistro sinistro)
        {
            await _context.Sinistros.AddAsync(sinistro);
            await _context.SaveChangesAsync(); // Salva as mudanças no banco de dados
        }

        public async Task UpdateSinistroAsync(Sinistro sinistro)
        {
            _context.Sinistros.Update(sinistro);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteSinistroAsync(int id)
        {
            var sinistro = await GetSinistroByIdAsync(id);
            if (sinistro != null)
            {
                _context.Sinistros.Remove(sinistro);
                await _context.SaveChangesAsync();
            }
        }
    }
}