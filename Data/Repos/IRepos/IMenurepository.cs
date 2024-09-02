using Resturant.Models;

namespace Resturant.Data.Repos.IRepos
{
    public interface IMenurepository
    {
        Task<IEnumerable<Menu>> GetAllMenusAsync();

        Task<Menu> GetMenuByIdAsync(int menuId);

        Task AddMenuAsync(Menu menu);

        Task UpdateMenuAsync(Menu menu);
        Task DeleteMenuAsync(int menuId);

    }
}
