using MTC.Core.Repositories;
using MTC.Core.Services;

namespace MTC.Data.Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly IRepositoryManager repositoryManager;
        public ServiceManager(IRepositoryManager repositoryManager)
        {
            this.repositoryManager = repositoryManager ?? throw new ArgumentNullException(nameof(repositoryManager));
        }

        public ICategoryService CategoryService => new CategoryService(repositoryManager);
        public IOrder_DetailService Order_DetailService => new OrderDetailService(repositoryManager);
        public IOrderService OrderService => new OrderService(repositoryManager);
        public IPizzaService PizzaService => new PizzaService(repositoryManager);
        public IPizza_TypeService PizzaTypeService => new PizzaTypeService(repositoryManager);
    }
}
