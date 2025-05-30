using MTC.Core.Models;
using MTC.Core.Models.DTO;

namespace MTC.Core.Mappers
{
    public static class CategoryMapper
    {
        public static async Task<Category?> DTOtoDomain(object obj)
        {
            if (obj == null) return null;

            try
            {
                var model = (CategoryDTO)obj;
                return await Task.FromResult(new Category
                {
                    Id = model.Id!,
                    Name = model.Name!
                });
            }
            catch
            {
                return null;
            }
        }
    }
}
