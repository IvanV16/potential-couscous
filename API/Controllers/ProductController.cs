using System.Text.Json;
using API.Interfaces;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{   
    [ApiController]    
    [Route("api/product")]     
    public class ProductController: ControllerBase
    {    
        private readonly IProductService _productService;    

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("products")]
        public async Task<IActionResult> GetProducts()
        {
            var result = await _productService.GetProductsAsync();
            return Ok(result);
        }
    
    }
}