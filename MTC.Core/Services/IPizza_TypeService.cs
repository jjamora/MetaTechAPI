using MTC.Core.Models;

namespace MTC.Core.Services
{
    public interface IPizza_TypeService
    {
        Task<Pizza_Type> GetByIdAsync(string id);
        Task<IEnumerable<Pizza_Type>> GetAllAsync();

        Task<Pizza_Type> Create(Pizza_Type pizzaType);
    }
}
