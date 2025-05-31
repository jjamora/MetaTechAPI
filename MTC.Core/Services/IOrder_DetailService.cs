using MTC.Core.Models;

namespace MTC.Core.Services
{
    public interface IOrder_DetailService
    {
        Task<Order_Detail> GetByIdAsync(string id);
        Task<IEnumerable<Order_Detail>> GetAllByOrderIdAsync(string orderId);

        Task<Order_Detail> Create(Order_Detail orderDetail);
        Task<Order_Detail> Update(Order_Detail orderDetail);
    }
}
