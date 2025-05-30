using MTC.Core.Models;

namespace MTC.Core.Repositories
{
    public interface IOrder_DetailRepository : IRepository<Order_Detail>
    {
        Task<Order_Detail> GetByIdAsync(string id);
        Task<IEnumerable<Order_Detail>> GetAllByOrderIdAsync(string orderId);
    }
}
