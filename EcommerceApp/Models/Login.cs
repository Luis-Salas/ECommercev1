using System.ComponentModel.DataAnnotations;

namespace EcommerceApp.Models
{
    public class LoginUser
    {
        [Required]
        [EmailAddress]
        public string Email {get; set;}
        
        [Required]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters")]
        public string Password {get; set;}
    }
}