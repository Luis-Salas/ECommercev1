using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;


namespace EcommerceApp.Models
{
    public class Design
    {
        [Key]
        public int DesignId {get;set;}

        public string Image {get;set;}

        public int PromoTime {get;set;}
        //nav property to Product
        public List<Product> ParentProduct {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}