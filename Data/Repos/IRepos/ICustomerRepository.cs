using Resturant.Models;

namespace Resturant.Data.Repos.IRepos
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetAllCustomersAsync();
        Task<Customer> GetCustomerByIdAsync(int customerId);

        Task AddCustomerAsync(Customer customer);
        Task UpdateCustomerAsync (Customer customer);
        Task DeleteCustomerAsync (int customerId);
    }
}
