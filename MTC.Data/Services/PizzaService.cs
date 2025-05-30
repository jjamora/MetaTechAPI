using MTC.Core.Models;
using MTC.Core.Repositories;
using MTC.Core.Services;

namespace MTC.Data.Services
{
    public class PizzaService : IPizzaService
    {
        private readonly IRepositoryManager repository;
        public PizzaService(IRepositoryManager repository)
        {
            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<Pizza> Create(Pizza pizza)
        {
            if (string.IsNullOrEmpty(pizza.Id)) pizza.Id = Guid.NewGuid().ToString();
            await repository.PizzaRepository.AddAsync(pizza);
            await repository.CommitAsync();

            return pizza;
        }

        public async Task<IEnumerable<Pizza>> GetAllAsync()
        {
            var list = await repository.PizzaRepository.GetAllAsync();
            return list!;
        }

        public async Task<Pizza> GetByIdAsync(string id)
        {
            var result = await repository.PizzaRepository.GetByIdAsync(id);
            return result!;
        }
    }
}
