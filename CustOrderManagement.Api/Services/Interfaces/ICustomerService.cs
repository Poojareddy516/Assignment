using CustOrderManagement.Data.Model;

namespace CustOrderManagement.Api.Services.Interfaces
{
    public interface ICustomerService
    {
        Task<Customer> Get(int customerId);
        Task<IEnumerable<Customer>> GetAll();
    }
}