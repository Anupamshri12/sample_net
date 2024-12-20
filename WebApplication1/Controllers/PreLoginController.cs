using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data.DTO;
namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PreLoginController:ControllerBase
    {
       public static readonly Dictionary<string, string> dict = new Dictionary<string, string>();
        [HttpPost]
        [Route("register")]
        public  IActionResult Register(string Name ,string email ,string Password)
        {
            var create_user = new UserDto
            {
                Name = Name,
                Email = email,
                Activity = Activity.Online
            };

            dict[Name] = Password;
            return Ok(create_user);
        }

        [HttpGet]
        [Route("login")]

        public IActionResult Login(string Name ,string Password)
        {
            if (dict.ContainsKey(Name))
            {
                if (dict[Name] == Password)
                {
                    return Ok("You are validated");
                }

            }
            return BadRequest("Not validated");
        }
    }
}