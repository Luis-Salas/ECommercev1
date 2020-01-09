using System.ComponentModel.DataAnnotations;
using System;

namespace EcommerceApp.Models
{
    public class Category
    {
        [Key]
        public int CategoryId {get;set;}

        public string Outwear {get;set;}
        public string Pants{get;set;}
        public string Shorts{get;set;}
        public string Sleepwear{get;set;}
        public string Socks{get;set;}
        public string Sportswear{get;set;}
        public string Suits{get;set;}
        public string Swinwear{get;set;}
        public string Tops{get;set;}
        public string Undergarments{get;set;}
        public string Assesories{get;set;}

        //----Foreign Key -------

        public int ProductId {get;set;}
        //-----------------------

                // -------NAVIGATIONAL PROPERTIES HERE------------

        //Link with model that the user is using to create product and 
        //The list of products the user has access to + pages etc

        //------------------------------------------------

        
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}