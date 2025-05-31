using MTC.Core.Models;
using MTC.Core.Repositories;
using MTC.Core.Services;

namespace MTC.Data.Services
{
    public class OrderService : IOrderService
    {
        private readonly IRepositoryManager repository;
        public OrderService(IRepositoryManager repository)
        {
            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<Order> Create(Order order)
        {
            if (string.IsNullOrEmpty(order.Id)) order.Id = Guid.NewGuid().ToString();
            await repository.OrderRepository.AddAsync(order);
            await repository.CommitAsync();

            return order;
        }

        public async Task<IEnumerable<Order>> GetAllAsync()
        {
            var list = await repository.OrderRepository.GetAllAsync();
            return list!;
        }

        public async Task<IEnumerable<Order>> GetAllPagingAsync(PageParameter param)
        {
            var list = await repository.OrderRepository.GetAllPagingAsync(param);
            return list!;
        }

        public async Task<Order> GetByIdAsync(string id)
        {
            var result = await repository.OrderRepository.GetByIdAsync(id);
            return result!;
        }

        public async Task<Order> Update(Order order)
        {
            await repository.OrderRepository.Update(order);
            await repository.CommitAsync();
            return order;
        }
    }
}
