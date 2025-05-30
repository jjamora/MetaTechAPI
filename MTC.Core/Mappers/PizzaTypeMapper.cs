using MTC.Core.Models;
using MTC.Core.Models.DTO;

namespace MTC.Core.Mappers
{
    public static class PizzaTypeMapper
    {
        public static async Task<Pizza_Type?> DTOtoDomain(object obj)
        {
            if (obj == null) return null;

            try
            {
                var model = (Pizza_TypeDTO)obj;
                return await Task.FromResult(new Pizza_Type
                {
                    Id = model.Id!,
                    Name = model.Name!,
                    CategoryId = model.CategoryId!,
                    Ingredients = model.Ingredients!
                });
            }
            catch
            {
                return null;
            }
        }
    }
}
