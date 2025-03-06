using Microsoft.AspNetCore.Mvc;
using ProductApi.Models;

namespace ProductApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private static readonly List<Product> Products = new()
        {
            new Product { Id = 1, Name = "Laptop", Description = "High performance laptop", Price = 1200.99M, ImageUrl = "/Images/laptop.jpg"  },
            new Product { Id = 2, Name = "Smartphone", Description = "Latest model smartphone", Price = 799.99M, ImageUrl = "/Images/Phone.jpg"  },
            new Product { Id = 3, Name = "Headphones", Description = "Noise-canceling headphones", Price = 199.99M, ImageUrl = "/Images/HeadPhones.jpeg"  }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            return Ok(Products);
        }
    }
}
