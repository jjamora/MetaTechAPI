using MTC.Core.Models;
using MTC.Core.Models.DTO;

namespace MTC.Core.Mappers
{
    public static class OrderMapper
    {
        public static async Task<Order?> DTOtoDomain(object obj)
        {
            if (obj == null) return null;

            try
            {
                var model = (OrderDTO)obj;
                return await Task.FromResult(new Order
                {
                    Id = model.Id!,
                    Date = model.Date!,
                    Time = model.Time!
                });
            }
            catch
            {
                return null;
            }
        }
    }
}
