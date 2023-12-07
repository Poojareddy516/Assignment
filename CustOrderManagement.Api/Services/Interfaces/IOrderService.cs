using CustOrderManagement.Data.Model;

namespace CustOrderManagement.Api.Services.Interfaces
{
    public interface IOrderService
    {
        Task CreateOrder(Order order);
        Task<Order> Get(int orderId);
        Task<IEnumerable<Order>> GetPendingOrders();
    }
}