using Microsoft.EntityFrameworkCore;
using MTC.Core.Models;
using MTC.Core.Repositories;

namespace MTC.Data.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly DataContext context;
        public CategoryRepository(DataContext context) : base(context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            //fetch all categories in the database
            var list = await context.Categories.ToListAsync();
            return list!;
        }

        public async Task<Category> GetByIdAsync(string id)
        {
            //fetch category in the database by Id
            var result = await context.Categories.FirstOrDefaultAsync(c => c.Id == id);
            return result ?? throw new ArgumentNullException(nameof(result));
        }
    }
}
