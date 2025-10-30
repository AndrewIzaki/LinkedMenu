using Microsoft.AspNetCore.Mvc;
using Product;
namespace ProductController.Controllers;

[ApiController]
[Route("api/products")]
public class ProductController : ControllerBase
{
    [HttpGet]
    public product get()
    {
        return new product
        {
            id = 1,
            names = "Pizza",
            price = 19.99f
        };
    }
} 