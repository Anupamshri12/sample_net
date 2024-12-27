using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApplication1.CustomDBContenxt;
using WebApplication1.Data.Entities;


namespace WebApplication1.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class PostLoginController:ControllerBase

    {
        public readonly DbContextdetail _dbcontextdetail;
        public PostLoginController(DbContextdetail dbcontextdetail)
        {
           _dbcontextdetail = dbcontextdetail;
        }

        [HttpGet]
        [Route("getallusers")]
        public async Task<List<UserDetail>> GetallUser(string define)
        {
            if(define == "all")
            {
                var alluser = await _dbcontextdetail.UserDetails.ToListAsync();
                return alluser;
            }
            return new List<UserDetail>();

        }
    }
}
