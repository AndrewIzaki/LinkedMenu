using Microsoft.AspNetCore.Mvc;
using product.Models;
namespace ProductController.Controllers;

[ApiController]
[Route("api/products")]
public class ProductController : ControllerBase
{
    [HttpGet]
    public Product get()
    {
        return new Product
        {
            id = 1,
            name = "Pizza",
            price = 19.99f
        };
    }
} 