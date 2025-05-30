using MTC.Core.Models;

namespace MTC.Core.Services
{
    public interface IOrderService
    {
        Task<Order> GetByIdAsync(string id);
        Task<IEnumerable<Order>> GetAllAsync();

        Task<Order> Create(Order order);
    }
}
