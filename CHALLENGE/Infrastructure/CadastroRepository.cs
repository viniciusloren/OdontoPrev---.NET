using Microsoft.EntityFrameworkCore;
using CHALLENGE.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;
using CHALLENGE.Application;

namespace CHALLENGE.Infrastructure
{
    public class CadastroRepository : ICadastroRepository
    {
        private readonly AppDbContext _context; 

        public CadastroRepository(AppDbContext context) 
        {
            _context = context;
        }

        public async Task<IEnumerable<Cadastro>> GetAllUsuariosAsync()
        {
            return await _context.Cadastros.ToListAsync(); 
        }

        public async Task<Cadastro> GetUsuarioByIdAsync(int id)
        {
            return await _context.Cadastros.FindAsync(id); 
        }

        public async Task AddUsuarioAsync(Cadastro cadastro)
        {
            await _context.Cadastros.AddAsync(cadastro); 
            await _context.SaveChangesAsync();
        }

        public async Task UpdateUsuarioAsync(Cadastro cadastro)
        {
            _context.Cadastros.Update(cadastro); 
            await _context.SaveChangesAsync();
        }

        public async Task DeleteUsuarioAsync(int id)
        {
            var cadastro = await GetUsuarioByIdAsync(id);
            if (cadastro != null)
            {
                _context.Cadastros.Remove(cadastro); 
                await _context.SaveChangesAsync();
            }
        }
    }
}