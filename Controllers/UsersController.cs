using Microsoft.AspNetCore.Mvc;
using user.Models;

namespace UsersController.Controllers;


[ApiController]
[Route("api/users")]
public class UsersController : ControllerBase
{
    [HttpGet]
    public User get()
    {
        return new User {
            id= 1, 
            name="John Doe"
        };
    }

}
