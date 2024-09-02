using Microsoft.EntityFrameworkCore;
using Resturant.Models;

namespace Resturant.Data.Repos.IRepos
{
    public interface ITableRepository
    {
        Task<IEnumerable<Table>> GetAllTablesAsync();

        Task<Table> GetTableByIdAsync(int tableId);

        Task AddTableAsync(Table table);
        Task UpdateTableAsync(Table table);
        Task DeleteTableAsync(int tableId);
        public Task<bool> IsTableNumberExistsAsync(int tableNumber);
        

    }
}
