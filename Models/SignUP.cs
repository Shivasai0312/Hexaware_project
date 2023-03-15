using System.ComponentModel.DataAnnotations;

namespace cafe_try_two.Models
{
    public class SignUP
    {
        [Required]
        public string Name { get; set; }
        [EmailAddress] 
        public string Email { get; set;}
        [Required]
        [Compare("ConfirmPassword")]
        public string Password { get; set;}
        [Required]
        public string ConfirmPassword { get; set;}


    }
}
