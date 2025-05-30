namespace MTC.Core.Repositories
{
    public interface IRepositoryManager : IDisposable
    {
        ICategoryRepository CategoryRepository { get; }
        IOrder_DetailRepository Order_DetailRepository { get; }
        IOrderRepository OrderRepository { get; }
        IPizzaRepository PizzaRepository { get; }
        IPizza_TypeRepository PizzaTypeRepository { get; }

        Task<int> CommitAsync();
    }
}
