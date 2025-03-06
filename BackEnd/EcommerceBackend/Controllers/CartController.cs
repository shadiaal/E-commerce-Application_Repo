using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using EcommerceBackend.Models;
namespace EcommerceBackend.Controllers
{
    [Route("api/[controller]")]
[ApiController]
public class CartController : ControllerBase
{
    private static List<CartItem> cart = new List<CartItem>();

    // Add item to cart
    [HttpPost]
    public IActionResult AddToCart([FromBody] CartItem item)
    {
        if (item == null)
        {
            return BadRequest("Item is null.");
        }

        var existingItem = cart.Find(x => x.Id == item.Id);
        if (existingItem != null)
        {
            existingItem.Quantity += item.Quantity; // Increment quantity if already in cart
        }
        else
        {
            cart.Add(item); // Add new item if not present
        }

        return Ok(cart);
    }

    // Get all items in the cart
    [HttpGet]
    public IActionResult GetCart()
    {
        return Ok(cart); // Return the current cart
    }

    // Remove item from the cart
    [HttpDelete("{id}")]
    public IActionResult RemoveFromCart(int id)
    {
        var item = cart.Find(x => x.Id == id);
        if (item == null) return NotFound("Item not found in cart");

        cart.Remove(item);
        return Ok(cart);
    }

    // Clear the entire cart
    [HttpDelete]
    [Route("clear")]
    public IActionResult ClearCart()
    {
        cart.Clear();
        return Ok("Cart has been cleared.");
    }
}

}