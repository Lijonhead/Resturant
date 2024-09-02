using Resturant.Models.DTOs;

namespace Resturant.Services.IServices
{
    public interface ITableServices
    {
        Task<IEnumerable<TableDTO>> GetAllTablesAsync();

        Task<TableDTO> GetTableByIdAsync(int tableId);

        Task AddTableAsync(TableDTO table);
        Task UpdateTableAsync(TableDTO table, int tableId);
        Task DeleteTableAsync(int tableId);

        
        


    }
}
