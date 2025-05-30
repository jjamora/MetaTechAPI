using MTC.Core.Models;
using MTC.Core.Models.DTO;

namespace MTC.Core.Mappers
{
    public static class PizzaMapper
    {
        public static async Task<Pizza?> DTOtoDomain(object obj)
        {
            if (obj == null) return null;

            try
            {
                var model = (PizzaDTO)obj;
                return await Task.FromResult(new Pizza
                {
                    Id = model.Id!,
                    Name = model.Name!,
                    PIzza_Type_Id = model.PIzza_Type_Id!,
                    Price = model.Price,
                    Size = model.Size,
                });
            }
            catch
            {
                return null;
            }
        }
    }
}
