using Microsoft.EntityFrameworkCore;
using MTC.Core.Models;
using MTC.Core.Repositories;

namespace MTC.Data.Repositories
{
    public class PIzzaTypeRepository : Repository<Pizza_Type>, IPizza_TypeRepository
    {
        private readonly DataContext context;
        public PIzzaTypeRepository(DataContext context) : base(context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<Pizza_Type>> GetAllAsync()
        {
            //fetch all pizzas in the database
            var list = await context.Pizza_Types
                .Include(t => t.Category)
                .ToListAsync();
            return list!;
        }

        public async Task<IEnumerable<Pizza_Type>> GetAllPagingAsync(PageParameter param)
        {
            //fetch all pizzas in the database
            var list = await context.Pizza_Types
                .Include(t => t.Category)
                .Skip((param.PageNumber - 1) * param.PageSize)
                .Take(param.PageSize)
                .ToListAsync();
            return list!;
        }

        public async Task<Pizza_Type> GetByIdAsync(string id)
        {
            //fetch pizza in the database by Id
            var result = await context.Pizza_Types
                .Include(t => t.Category)
                .FirstOrDefaultAsync(c => c.Id == id);
            return result ?? throw new ArgumentNullException(nameof(result));
        }
    }
}
