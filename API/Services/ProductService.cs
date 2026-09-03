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
            var products = await _context.Products.Select(p => new ProductDto
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price
            }).ToListAsync();

            return products;
        }

    }
}