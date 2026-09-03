using API.Interfaces;
using API.Models;
using API.Persistence;
using Microsoft.EntityFrameworkCore;

namespace API.Services
{
    public class ProductService : IProductService
    {
        private readonly StoreDbContext _context;

        public ProductService(StoreDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ProductDto>> GetProductsAsync()
        {
           var products = new List<ProductDto>();
            products.Add(new ProductDto(1, "Product 1", 10.99m));
            products.Add(new ProductDto(2, "Product 2", 15.99m));
            products.Add(new ProductDto(3, "Product 3", 20.99m));    
          

            return products;
        }

    }
}