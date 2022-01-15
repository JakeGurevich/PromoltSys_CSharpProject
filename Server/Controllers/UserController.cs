using Microsoft.AspNetCore.Mvc;
using Promolt.Core.Interfaces;

namespace Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        IUserServices _userServices;

        public UserController(IUserServices UserServices)
        {
            _userServices = UserServices;
        }

       

        [HttpGet(Name = "Users")]
     
        public IActionResult GetUsers()
        {
            return Ok(_userServices.GetUsers());
        }
    }
}