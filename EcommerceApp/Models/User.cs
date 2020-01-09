using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace EcommerceApp.Models
{
    public class User
    {
         [Key]
        public int UserId { get; set;}
        [Required]
        [MinLength(2, ErrorMessage = "First Name must be at least 2 characters")]
        public string FirstName { get; set;}
        [Required]
        [MinLength(2, ErrorMessage = "First Name must be at least 2 characters")]

        public string LastName {get; set;}
        [Required]
        [EmailAddress]
        public string Email {get; set;}
        [Required]
        
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters")]
        public string Password {get; set;}
        [Required]
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        [Required]
        public DateTime UpdatedAt {get; set;} = DateTime.Now;

        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword {get;set;}
        public List<Page> Pages {get;set;}

    }

    // public class PasswordValiAttribute : ValidationAttribute
    // {
    //     protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    //     {
    //         bool validPassword = false;
    //         string Error = String.Empty;
    //         string Password = value == null ? String.Empty : value.ToString();
    //         if (String.IsNullOrEmpty(Password) || Password.Length < 8)
    //         {
    //             return new ValidationResult("Your new password must be at least 8 characters long.");
    //         }
    //         else
    //         {
    //             Regex reSymbol = new Regex("[^a-zA-Z0-9]");
    //             if (!reSymbol.IsMatch(Password))
    //             {
    //                 Error += "Your new password must contain at least 1 symbol character.";
    //             }
    //             else
    //             {
    //                 validPassword = true;
    //             }
    //         }
    //         if (validPassword)
    //         {
    //             return ValidationResult.Success;
    //         }
    //         else
    //         {
    //             return new ValidationResult(Error);
    //         }
    //     }
    // }
}