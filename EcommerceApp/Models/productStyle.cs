using System.ComponentModel.DataAnnotations;
using System;

namespace EcommerceApp.Models
{
    public class ProductStyle
    {

        //product table id
        public int ProductId { get; set; }
        public int StyleId { get; set; }
        //style table id
        //nav property to Product
        public Product Product { get; set; }
        //nav property to Style
        public Style Style { get; set; }
        
    }
}
