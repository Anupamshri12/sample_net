using WebApplication1.CustomDBContenxt;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data.Entities;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace WebApplication1.Services
{
    public class AuthService
    {
        public readonly DbContextdetail dbContextdetail;
        public readonly IConfiguration _configuration;
        public AuthService(DbContextdetail _dbContextdetail ,IConfiguration configuration)
        {
           dbContextdetail = _dbContextdetail;
            _configuration = configuration;
        }
        public UserDetail Register(string FirstName ,string LastName ,string UserName ,string Email ,string Password)
        {
            var new_user = new UserDetail()
            {
                FirstName = FirstName,
                LastName = LastName,
                UserName = UserName,
                Email = Email,
                Date = DateTime.Now.ToString(),
                Password = Password
            };
            var auth_user = new AuthDetail()
            {
                UserName = UserName,
                HashedPassword = Password
            };
            dbContextdetail.UserDetails.Add(new_user);
            dbContextdetail.AuthUsers.Add(auth_user);
            dbContextdetail.SaveChanges();
            return new_user;
        }
        public string Login(string UserName ,string Password)
        {
            var finduser = dbContextdetail.AuthUsers.FirstOrDefault(user=>user.UserName == UserName);
            if(finduser != null)
            {
                var check_password = dbContextdetail.AuthUsers.FirstOrDefault(user=>user.UserName == UserName && user.HashedPassword == Password); 
                if(check_password != null)
                {
                    return "Authenticated";
                }
               
            }
            return "Not Validated";
        }
        
    }
}
