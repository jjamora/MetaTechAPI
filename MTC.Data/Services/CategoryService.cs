using MTC.Core.Models;
using MTC.Core.Repositories;
using MTC.Core.Services;

namespace MTC.Data.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepositoryManager repository;
        public CategoryService(IRepositoryManager repository)
        {
            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<Category> Create(Category category)
        {
            if (string.IsNullOrEmpty(category.Id)) category.Id = Guid.NewGuid().ToString();
            await repository.CategoryRepository.AddAsync(category);
            await repository.CommitAsync();

            return category;
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            var list = await repository.CategoryRepository.GetAllAsync();
            return list!;
        }

        public async Task<Category> GetByIdAsync(string id)
        {
            var result = await repository.CategoryRepository.GetByIdAsync(id);
            return result!;
        }
    }
}
