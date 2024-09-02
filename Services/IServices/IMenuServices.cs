using Resturant.Models;
using Resturant.Models.DTOs;

namespace Resturant.Services.IServices
{
    public interface IMenuServices
    {
        Task<IEnumerable<MenuDTO>> GetAllMenusAsync();

        Task<MenuDTO> GetMenuByIdAsync(int menuId);

        Task AddMenuAsync(MenuDTO menu);

        Task UpdateMenuAsync(MenuDTO menu, int menuId);
        Task DeleteMenuAsync(int menuId);
    }
}
