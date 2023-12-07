using CustOrderManagement.Api.Services.Interfaces;
using CustOrderManagement.Data;
using CustOrderManagement.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace CustOrderManagement.Api.Services
{
    public class OrderService : IOrderService
    {
        private readonly CustOrderManagementDbContext _dbContext;

        public OrderService(CustOrderManagementDbContext DbContext)
        {
            _dbContext = DbContext;
        }

        public async Task<Order> Get(int orderId)
        {
            return await _dbContext.Orders.FirstOrDefaultAsync(x => x.OrderId == orderId);
        }

        public async Task CreateOrder(Order order)
        {
            _dbContext.Orders.Add(order);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Order>> GetPendingOrders()
        {
            return await _dbContext.Orders.Where(x => x.ShippedDate > DateTime.Now).ToListAsync();
        }
    }
}
