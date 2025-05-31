using Microsoft.EntityFrameworkCore;
using MTC.Core.Models;
using MTC.Core.Repositories;

namespace MTC.Data.Repositories
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        private readonly DataContext context;
        public OrderRepository(DataContext context) : base(context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<Order>> GetAllAsync()
        {
            //fetch all orders in the database
            var list = await context.Orders
                .Include(o => o.Details)
                .ToListAsync();
            return list!;
        }

        public async Task<IEnumerable<Order>> GetAllPagingAsync(PageParameter param)
        {
            //fetch all orders in the database by pagination
            var list = await context.Orders
                .Include(o => o.Details)
                .Skip((param.PageNumber -1) * param.PageSize)
                .Take(param.PageSize)
                .ToListAsync();
            return list!;
        }

        public async Task<Order> GetByIdAsync(string id)
        {
            //fetch orders in the database by Id
            var result = await context.Orders
                .Include(o => o.Details)
                .FirstOrDefaultAsync(c => c.Id == id);
            return result ?? throw new ArgumentNullException(nameof(result));
        }
    }
}
