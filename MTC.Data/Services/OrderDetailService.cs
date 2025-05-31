using MTC.Core.Models;
using MTC.Core.Repositories;
using MTC.Core.Services;

namespace MTC.Data.Services
{
    public class OrderDetailService : IOrder_DetailService
    {
        private readonly IRepositoryManager repository;
        public OrderDetailService(IRepositoryManager repository)
        {
            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<Order_Detail> Create(Order_Detail orderDetail)
        {
            if (string.IsNullOrEmpty(orderDetail.Id)) orderDetail.Id = Guid.NewGuid().ToString();
            await repository.Order_DetailRepository.AddAsync(orderDetail);
            await repository.CommitAsync();

            return orderDetail;
        }

        public async Task<IEnumerable<Order_Detail>> GetAllByOrderIdAsync(string orderId)
        {
            var list = await repository.Order_DetailRepository.GetAllByOrderIdAsync(orderId);
            return list!;
        }

        public async Task<Order_Detail> GetByIdAsync(string id)
        {
            var result = await repository.Order_DetailRepository.GetByIdAsync(id);
            return result!;
        }

        public async Task<Order_Detail> Update(Order_Detail orderDetail)
        {
            await repository.Order_DetailRepository.Update(orderDetail);
            await repository.CommitAsync();
            return orderDetail;
        }
    }
}
