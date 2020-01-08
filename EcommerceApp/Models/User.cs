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
        public int UserId {get;set;}
        [Required (ErrorMessage="Please enter a first name")]
        public string FirstName {get;set;}

        [Required(ErrorMessage="Please enter a Last name")]
        public string LastName {get;set;}

        [Required (ErrorMessage="Please enter a Email")]
        [EmailAddress]
        public string Email {get;set;}

        [Required(ErrorMessage="Please enter a password")]
        [MinLength(8)]
        [DataType(DataType.Password)]
        [PasswordVali]
        public string Password {get;set;}

        [Compare("Password")]
        [DataType(DataType.Password)]
        [NotMapped]
        [PasswordVali]
        public string Confirm {get;set;}

        // -------NAVIGATIONAL PROPERTIES HERE------------

        //Link with model that the user is using to create product and 
        //The list of products the user has access to + pages etc

        //------------------------------------------------
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public List<Page> Pages {get;set;}

    }

    public class PasswordValiAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            bool validPassword = false;
            string Error = String.Empty;
            string Password = value == null ? String.Empty : value.ToString();
            if (String.IsNullOrEmpty(Password) || Password.Length < 8)
            {
                return new ValidationResult("Your new password must be at least 8 characters long.");
            }
            else
            {
                Regex reSymbol = new Regex("[^a-zA-Z0-9]");
                if (!reSymbol.IsMatch(Password))
                {
                    Error += "Your new password must contain at least 1 symbol character.";
                }
                else
                {
                    validPassword = true;
                }
            }
            if (validPassword)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult(Error);
            }
        }
    }
}