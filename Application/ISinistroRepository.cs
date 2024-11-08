using System.Collections.Generic;
using System.Threading.Tasks;
using CHALLENGE.Domain;

namespace CHALLENGE.Application
{
    public interface ISinistroRepository
    {
        Task<IEnumerable<Sinistro>> GetAllSinistrosAsync();
        Task<Sinistro> GetSinistroByIdAsync(int id);
        Task AddSinistroAsync(Sinistro sinistro);
        Task UpdateSinistroAsync(Sinistro sinistro);
        Task DeleteSinistroAsync(int id);
    }
}