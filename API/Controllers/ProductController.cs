using System.Text.Json;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{   
    [Route("api/product")] 
    [ApiController]    
    public class ProductController
    {        
        public ProductController()
        {
        }

        [HttpGet("products")]
        public IActionResult GetProducts()
        {
            var products = new List<ProductDto>();
            products.Add(new ProductDto(1, "Product 1", 10.99m));
            products.Add(new ProductDto(2, "Product 2", 15.99m));
            products.Add(new ProductDto(3, "Product 3", 20.99m));            

            var productsJson = JsonSerializer.Serialize<IEnumerable<ProductDto>>(products);

            return new ContentResult
            {
                Content = productsJson,
                ContentType = "application/json"
            };
        }
    
    }
}