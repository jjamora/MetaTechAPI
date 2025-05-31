using MTC.Core.Models;

namespace MTC.Core.Services
{
    public interface IPizzaService
    {
        Task<Pizza> GetByIdAsync(string id);
        Task<IEnumerable<Pizza>> GetAllAsync();
        Task<IEnumerable<Pizza>> GetAllPagingAsync(PageParameter param);

        Task<Pizza> Create(Pizza pizza);
    }
}
