using Microsoft.AspNetCore.Mvc;
using EcommerceBackend.Models;

namespace EcommerceBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private static readonly List<Product> Products = new()
        {
            new Product { Id = 1, Name = "Laptop", Description = "High performance laptop", Price = 1200.99M, ImageUrl = "https://th.bing.com/th?id=OIP.hZE26Ng3dIyEwMaDhjAcsQHaFj&w=288&h=216&c=8&rs=1&qlt=90&o=6&dpr=1.3&pid=3.1&rm=2"  },
            new Product { Id = 2, Name = "Smartphone", Description = "Latest model smartphone", Price = 799.99M, ImageUrl = "https://th.bing.com/th?id=OIP.aTdhjRwB6bk7pTV2SX1tFwHaHa&w=250&h=250&c=8&rs=1&qlt=90&o=6&dpr=1.3&pid=3.1&rm=2"},
            new Product { Id = 3, Name = "Headphones", Description = "Noise-canceling headphones", Price = 199.99M, ImageUrl = "https://th.bing.com/th/id/OIP.dCWOWO2DOr66QBkxrM-grAHaHa?w=179&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7"  }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            return Ok(Products);
        }
        [HttpGet("{id}")]
        public ActionResult<Product> GetProductById(int id)
        {
            var product = Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound(new { message = "Product not found" });
            }
            return Ok(product);
        }

    }
}
