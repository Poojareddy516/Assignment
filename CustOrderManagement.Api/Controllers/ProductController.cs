using CustOrderManagement.Api.Model;
using CustOrderManagement.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustOrderManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        

        // GET: api/<ProductController>/
        [HttpGet("GetProductsBasedOnRatings")]
        public async Task<IActionResult> GetProductsBasedOnRatings()
        {
            var products = await _productService.GetProducts(false);
            if (products == null)
            {
                return NotFound();
            }
            return Ok(products);
        }
    }
}
