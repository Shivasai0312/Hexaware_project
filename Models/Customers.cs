using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System;
using WebAPIwithIdentity.Models;

namespace cafe_try_two.Models
{
    public class Customers : IdentityDbContext<ApplicationUser>
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }
        [EmailAddress]
        [Required(ErrorMessage = "Email is required")] 
        public string Email { get; set; }
        [Required(ErrorMessage ="Password is required")]
        public string Password { get; set; }
        public Int64 Phone { get; set; }
    }
}