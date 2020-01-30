using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace EcommerceApp.Models
{
    public class Order
    {
        [Key]

        public int OrderId {get; set;}
        [Required]
        public string OrderNumber {get; set;}
        [Required]
        public int total {get; set;}
        public string status {get; set;}
        public List<Product> Products {get; set;}
        public List<ProductOrders> OrderedProducts {get; set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

    }
}
