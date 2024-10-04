using Resturant.Models;
using Resturant.Models.DTOs;

namespace Resturant.Services.IServices
{
    public interface ICustomerServices
    {
        Task<IEnumerable<CustomerDTO>> GetAllCustomersAsync();
        Task<CustomerDTO> GetCustomerByIdAsync(int customerId);

        Task <CustomerDTO>AddCustomerAsync(CustomerDTO customer);
        Task UpdateCustomerAsync(CustomerDTO customer, int customerId);
        Task DeleteCustomerAsync(int customerId);
    }
}
