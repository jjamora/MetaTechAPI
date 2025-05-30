using MTC.Core.Models;

namespace MTC.Core.Repositories
{
    public interface IOrderRepository : IRepository<Order>
    {
        Task<Order> GetByIdAsync(string id);
        Task<IEnumerable<Order>> GetAllAsync();
    }
}
