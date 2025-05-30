using MTC.Core.Repositories;

namespace MTC.Data.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly DataContext context;
        private readonly CategoryRepository? categoryRepository;
        private readonly Order_DetailRepository? orderDetailRepository;
        private readonly OrderRepository? orderRepository;
        private readonly PizzaRepository? pizzaRepository;
        private readonly PIzzaTypeRepository? pizzaTypeRepository;

        public RepositoryManager(DataContext context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public ICategoryRepository CategoryRepository => categoryRepository ?? new CategoryRepository(context);
        public IOrder_DetailRepository Order_DetailRepository => orderDetailRepository ?? new Order_DetailRepository(context);
        public IOrderRepository OrderRepository => orderRepository ?? new OrderRepository(context);
        public IPizzaRepository PizzaRepository => pizzaRepository ?? new PizzaRepository(context);
        public IPizza_TypeRepository PizzaTypeRepository => pizzaTypeRepository ?? new PIzzaTypeRepository(context);

        public async Task<int> CommitAsync()
        {
            return await context.SaveChangesAsync();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
