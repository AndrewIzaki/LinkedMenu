using Microsoft.AspNetCore.Mvc;
using Users.Models;

namespace UsersController.Controllers;


[ApiController]
[Route("api/users")]
public class UsersController : ControllerBase
{
    [HttpGet]
    public user get()
    {
        return new user {
            id= 1, 
            name="John Doe"
        };
    }

}
