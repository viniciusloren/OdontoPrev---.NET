using Microsoft.EntityFrameworkCore;
using CHALLENGE.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;
using CHALLENGE.Application;

namespace CHALLENGE.Infrastructure.Repositories
{
    public class CadastroRepository : ICadastroRepository
    {
        private readonly DbContext _context;

        public CadastroRepository(DbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Cadastro>> GetAllCadastrosAsync()
        {
            return await _context.Set<Cadastro>().ToListAsync();
        }

        public async Task<Cadastro> GetCadastroByIdAsync(int id)
        {
            return await _context.Set<Cadastro>().FindAsync(id);
        }

        public async Task AddCadastroAsync(Cadastro cadastro)
        {
            await _context.Set<Cadastro>().AddAsync(cadastro);
            await _context.SaveChangesAsync();
        }
    }
}