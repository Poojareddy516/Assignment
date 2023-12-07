using CustOrderManagement.Api.Model;
using CustOrderManagement.Api.Services;
using CustOrderManagement.Api.Services.Interfaces;
using CustOrderManagement.Data.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustOrderManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly ICustomerService _customerService;
        private readonly IProductService _productService;

        public OrderController(IOrderService orderService
            , ICustomerService customerService
            , IProductService productService)
        {
            _orderService = orderService;
            _customerService = customerService;
            _productService = productService;
        }

        // GET: api/<ProductController>/
        [HttpGet]
        public async Task<IActionResult> Get(int orderId)
        {
            var order = await _orderService.Get(orderId);
            if (order == null)
            {
                return NotFound();
            }
            return Ok(order);
        }

        // GET: api/<OrderController>
        [HttpGet("GetPendingOrders")]
        public async Task<IActionResult> GetPendingOrders()
        {
            var orders =await  _orderService.GetPendingOrders();
            var customer = await _customerService.GetAll();

            if (orders is null || !orders.Any())
            {
                return NotFound();
            }

            var result = from o in orders
                         join c in customer on o.CustomerId equals c.CustomerId
                         select new OrderResponseDto()
                         {
                             CustomerId = c.CustomerId,
                             CustomerName = c.CustomerName,
                             OrderId = o.OrderId,
                             OrderDate = o.OrderDate,
                             Quantity = o.Quantity,
                             PricePaid = o.PricePaid
                         };

            
            return Ok(result);
        }

        // POST api/<OrderController>
        [HttpPost("SaveOrders")]
        public async Task<IActionResult> SaveOrder([FromBody] Order order)
        {
            if (order == null)
                return BadRequest("Order not passed");

            if (order.OrderId > 0)
                return BadRequest("Order already exsists");

            var product =await _productService.Get(order.ProductId);
            if (product == null)
                return BadRequest("Product does not exsists");

            var customer =await _customerService.Get(order.CustomerId);
            if (customer == null)
                return BadRequest("Customer does not exsists");

            await _orderService.CreateOrder(order);


            return CreatedAtAction(nameof(Get), new { id = order.OrderId }, order);

        }
    }
}
