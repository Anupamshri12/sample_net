
namespace WebApplication1.Data.DTO
{
    public enum Activity
    {
        Online = 1,
        Offline = 0,
        Terminated = -1

    }
    public class UserDto
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public Activity? Activity { get; set; }
    }
}
