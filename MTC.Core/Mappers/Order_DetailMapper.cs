using MTC.Core.Models;
using MTC.Core.Models.DTO;

namespace MTC.Core.Mappers
{
    public static class Order_DetailMapper
    {
        public static async Task<Order_Detail?> DTOtoDomain(object obj)
        {
            if (obj == null) return null;

            try
            {
                var model = (Order_DetailDTO)obj;
                return await Task.FromResult(new Order_Detail
                {
                    Id = model.Id!,
                    Order_Id = model.Order_Id!,
                    Pizza_Id = model.Pizza_Id!,
                    Quantity = model.Quantity
                });
            }
            catch
            {
                return null;
            }
        }
    }
}
