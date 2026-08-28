using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public ProductDto(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}