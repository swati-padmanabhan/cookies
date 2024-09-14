using System.ComponentModel.DataAnnotations;

namespace CookiesDemo.Models
{
    public class User
    {
        [Required(ErrorMessage = "Please Enter User Name")]
        public string Username { get; set; }
    }
}