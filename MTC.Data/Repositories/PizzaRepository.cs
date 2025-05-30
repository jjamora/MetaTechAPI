using Microsoft.EntityFrameworkCore;
using MTC.Core.Models;
using MTC.Core.Repositories;

namespace MTC.Data.Repositories
{
    public class PizzaRepository : Repository<Pizza>, IPizzaRepository
    {
        private readonly DataContext context;
        public PizzaRepository(DataContext context) : base(context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<Pizza>> GetAllAsync()
        {
            //fetch all pizzas in the database
            var list = await context.Pizzas
                .Include(t => t.PIzza_Type)
                .ToListAsync();
            return list!;
        }

        public async Task<Pizza> GetByIdAsync(string id)
        {
            //fetch pizza in the database by Id
            var result = await context.Pizzas
                .Include(t => t.PIzza_Type)
                .FirstOrDefaultAsync(c => c.Id == id);
            return result ?? throw new ArgumentNullException(nameof(result));
        }
    }
}
