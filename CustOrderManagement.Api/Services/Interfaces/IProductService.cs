using CustOrderManagement.Data.Model;

namespace CustOrderManagement.Api.Services.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetProducts(bool ascending);
        Task<Product> Get(int productId);
    }
}