using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EcommerceApp.Models
{
    public class Order
    {
        [Key]
        public int OrderId {get;set;}
        [Required]

        public int orderNumber {get;set;}
        [Required]

        public int total {get;set;}

        public string status {get;set;}
        //navigational property to Product
        public List<Product> Products {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

    }
}