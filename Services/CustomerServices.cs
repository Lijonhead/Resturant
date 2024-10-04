using Resturant.Data.Repos.IRepos;
using Resturant.Models;
using Resturant.Models.DTOs;
using Resturant.Services.IServices;

namespace Resturant.Services
{
    public class CustomerServices : ICustomerServices
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerServices(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public async Task<CustomerDTO> AddCustomerAsync(CustomerDTO customer)
        {
            var newCustomer = new Customer
            {
                Name = customer.Name,
                Email = customer.Email
            };
            await _customerRepository.AddCustomerAsync(newCustomer);

            return new CustomerDTO
            {
                CustomerId = newCustomer.Id, 
                Name = newCustomer.Name,
                Email = newCustomer.Email
                
            };
            

        }

        public async Task DeleteCustomerAsync(int customerId)
        {
           await _customerRepository.DeleteCustomerAsync(customerId);
        }

        public async Task<IEnumerable<CustomerDTO>> GetAllCustomersAsync()
        {
            var listOfCustomers = await _customerRepository.GetAllCustomersAsync();
            return listOfCustomers.Select(x => new CustomerDTO
            {
                CustomerId = x.Id,
                Name = x.Name,
                Email = x.Email

            }).ToList();
        }

        public async Task<CustomerDTO> GetCustomerByIdAsync(int customerId)
        {
            var customerGot = await _customerRepository.GetCustomerByIdAsync(customerId);
            if (customerGot == null)
            {
                return null;
            }

            return new CustomerDTO
            {
                CustomerId = customerGot.Id,
                Name = customerGot.Name,
                Email = customerGot.Email

            };
        }

        public async Task UpdateCustomerAsync(CustomerDTO customer, int customerId)
        {
            var updateCustomer = await _customerRepository.GetCustomerByIdAsync(customerId);
            
            updateCustomer.Name = customer.Name;
            updateCustomer.Email = customer.Email;
            await _customerRepository.UpdateCustomerAsync(updateCustomer);
        }
    }
}
