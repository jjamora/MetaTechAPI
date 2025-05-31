using MTC.Core.Models;

namespace MTC.Core.Services
{
    public interface IOrderService
    {
        Task<Order> GetByIdAsync(string id);
        Task<IEnumerable<Order>> GetAllAsync();
        Task<IEnumerable<Order>> GetAllPagingAsync(PageParameter param);

        Task<Order> Create(Order order);
    }
}
