using Microsoft.AspNetCore.Mvc;
using Promolt.Core.Interfaces;
using Promolt.Core.Models;

namespace Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        IUserServices _userServices;

        public UsersController(IUserServices UserServices)
        {
            _userServices = UserServices;
        }

       

        [HttpGet]
     
        public async Task<ActionResult<List<UserModel>>> Get()
        {
            var users= await _userServices.GetUsers();
            return users;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserModel>> Get(string id)
        {
            var user = await _userServices.GetUser(id);

            if (user is null)
            {
                return NotFound();
            }

            return user;
        }

        [HttpPost]

        public async Task<IActionResult> CreateUser(UserModel newUser)
        {
            await _userServices.CreateUser(newUser);

            return CreatedAtAction(nameof(Get),   newUser);


        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, UserModel updatedUser)
        {
            var user = await _userServices.GetUser(id);

            if (user is null)
            {
                return NotFound();
            }

            updatedUser.Id = user.Id;

            await _userServices.UpdateUser(id, updatedUser);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var user = await _userServices.GetUser(id);

            if (user is null)
            {
                return NotFound();
            }

            await _userServices.DeleteUser(id);

            return NoContent();
        }
    }
}