using System.ComponentModel.DataAnnotations;

namespace Sample.API.Models
{
    public class User
    {
        [Required]
        [EmailAddress]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
