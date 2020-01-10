using System.ComponentModel.DataAnnotations;
using System;

namespace EcommerceApp.Models
{
    public class ProductStyle
    {
        [Key]
        public int ProductStyleId {get;set;}
        //product table id
        public int ProductId { get; set; }
        //style table id
        public int StyleId { get; set; }
        //nav property to Product
        public Product Product { get; set; }
        //nav property to Style
        public Style Style { get; set; }
        
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}
