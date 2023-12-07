using CustOrderManagement.Api.Services.Interfaces;
using CustOrderManagement.Data;
using CustOrderManagement.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace CustOrderManagement.Api.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly CustOrderManagementDbContext _dbContext;

        public CustomerService(CustOrderManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Customer>> GetAll()
        {
            return await _dbContext.Customers.ToListAsync();
        }

        public async Task<Customer> Get(int customerId)
        {
            return await _dbContext.Customers.FirstOrDefaultAsync(x => x.CustomerId==customerId);
        }
    }
}
