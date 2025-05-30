using MTC.Core.Models;

namespace MTC.Core.Repositories
{
    public interface IPizzaRepository : IRepository<Pizza>
    {
        Task<Pizza> GetByIdAsync(string id);
        Task<IEnumerable<Pizza>> GetAllAsync();
    }
}
