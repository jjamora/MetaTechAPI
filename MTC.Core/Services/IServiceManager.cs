namespace MTC.Core.Services
{
    public interface IServiceManager
    {
        ICategoryService CategoryService { get; }
        IOrder_DetailService Order_DetailService { get; }
        IOrderService OrderService { get; }
        IPizzaService PizzaService { get; }
        IPizza_TypeService PizzaTypeService { get; }
    }
}
