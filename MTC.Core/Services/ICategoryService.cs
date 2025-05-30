using MTC.Core.Models;

namespace MTC.Core.Services
{
    public interface ICategoryService
    {
        Task<Category> GetByIdAsync(string id);
        Task<IEnumerable<Category>> GetAllAsync();

        Task<Category> Create(Category category);
    }
}
