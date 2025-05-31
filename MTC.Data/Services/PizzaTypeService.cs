using MTC.Core.Models;
using MTC.Core.Repositories;
using MTC.Core.Services;

namespace MTC.Data.Services
{
    public class PizzaTypeService : IPizza_TypeService
    {
        private readonly IRepositoryManager repository;
        public PizzaTypeService(IRepositoryManager repository)
        {
            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<Pizza_Type> Create(Pizza_Type pizzaType)
        {
            if (string.IsNullOrEmpty(pizzaType.Id)) pizzaType.Id = Guid.NewGuid().ToString();
            await repository.PizzaTypeRepository.AddAsync(pizzaType);
            await repository.CommitAsync();

            return pizzaType;
        }

        public async Task<IEnumerable<Pizza_Type>> GetAllAsync()
        {
            var list = await repository.PizzaTypeRepository.GetAllAsync();
            return list!;
        }

        public async Task<IEnumerable<Pizza_Type>> GetAllPagingAsync(PageParameter param)
        {
            var list = await repository.PizzaTypeRepository.GetAllPagingAsync(param);
            return list!;
        }

        public async Task<Pizza_Type> GetByIdAsync(string id)
        {
            var result = await repository.PizzaTypeRepository.GetByIdAsync(id);
            return result!;
        }
    }
}
