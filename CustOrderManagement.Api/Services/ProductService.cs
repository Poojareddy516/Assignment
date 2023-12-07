using CustOrderManagement.Api.Services.Interfaces;
using CustOrderManagement.Data;
using CustOrderManagement.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace CustOrderManagement.Api.Services
{
    public class ProductService : IProductService
    {
        private readonly CustOrderManagementDbContext _dbContext;

        public ProductService(CustOrderManagementDbContext DbContext)
        {
            _dbContext = DbContext;
        }

        public async Task<Product> Get(int productId)
        {
            return await _dbContext.Products.FirstOrDefaultAsync(x => x.ProductId == productId);
        }

        public async Task<IEnumerable<Product>> GetProducts(bool ascending)
        {
            if (ascending)
            {
                return await _dbContext.Products.OrderBy(x => x.AverageCustomerRating).ToListAsync();
            }

            return await _dbContext.Products.OrderByDescending(x => x.AverageCustomerRating).ToListAsync();
        }
    }
}
