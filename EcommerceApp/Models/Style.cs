using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;


namespace EcommerceApp.Models
{
    public class Style
    {
        [Key]
        public int StyleId {get;set;}

        public string Name {get;set;}

        //nav property to ProductStyle
        public List<ProductStyle> BaseProduct {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}