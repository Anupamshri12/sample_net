using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Data.Entities
{
    [Table("user")]
    public class UserDetail
    {
        [Key]
        public int UserId { get; set; }
        public string ?Name { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Location { get; set; }
        public string? Date { get; set; }

        

    }
}
