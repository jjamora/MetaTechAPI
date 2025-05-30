using Microsoft.EntityFrameworkCore;
using MTC.Core.Models;
using MTC.Core.Repositories;

namespace MTC.Data.Repositories
{
    public class Order_DetailRepository : Repository<Order_Detail>, IOrder_DetailRepository
    {
        private readonly DataContext context;
        public Order_DetailRepository(DataContext context) : base(context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<Order_Detail>> GetAllByOrderIdAsync(string orderId)
        {
            //fetch all order details in the database by order Id
            var list = await context.OrderDetails.Where(o => o.Order_Id == orderId).ToListAsync();
            return list!;
        }

        public async Task<Order_Detail> GetByIdAsync(string id)
        {
            //fetch order detail in the database by Id
            var result = await context.OrderDetails.FirstOrDefaultAsync(c => c.Id == id);
            return result ?? throw new ArgumentNullException(nameof(result));
        }
    }
}
