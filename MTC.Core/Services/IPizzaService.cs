using MTC.Core.Models;

namespace MTC.Core.Services
{
    public interface IPizzaService
    {
        Task<Pizza> GetByIdAsync(string id);
        Task<IEnumerable<Pizza>> GetAllAsync();

        Task<Pizza> Create(Pizza pizza);
    }
}
