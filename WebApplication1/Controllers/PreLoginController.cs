using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

using WebApplication1.CustomDBContenxt;
using WebApplication1.Data.Entities;
using WebApplication1.Services;
namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PreLoginController:ControllerBase
    {
        public readonly  DbContextdetail dbContextdetail;
        public readonly AuthService authService;
        public PreLoginController(DbContextdetail dbContextdetail ,AuthService authService)
        {
            this.dbContextdetail = dbContextdetail;
            this.authService = authService;
        }
       
        [HttpPost]
        [Route("register")]
        public  IActionResult Register(string Name ,string UserName ,string Location ,string Password)
        {
            
            var create_user = authService.Register(Name ,UserName ,Location ,Password);

     
            return Ok(create_user);
        }

        [HttpGet]
        [Route("Login")]
        public IActionResult Login(string UserName ,string Password)
        {
            var token = authService.Login(UserName ,Password);
            return Ok(token);
        }
    }
}