using System;
using System.ComponentModel.DataAnnotations;

namespace EcommerceApp.Models
{
    public class Page
    {
        [Key]
        public int PageId {get;set;}
        [Required]

        public string name {get;set;}
        [Required]

        public string about {get;set;}
        //navigation property to the use
        public User UsersPage {get;set;}

         public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

    }
}