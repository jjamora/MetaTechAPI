using MTC.Core.Models;

namespace MTC.Core.Repositories
{
    public interface IPizza_TypeRepository : IRepository<Pizza_Type>
    {
        Task<Pizza_Type> GetByIdAsync(string id);
        Task<IEnumerable<Pizza_Type>> GetAllAsync();
        Task<IEnumerable<Pizza_Type>> GetAllPagingAsync(PageParameter param);
    }
}
