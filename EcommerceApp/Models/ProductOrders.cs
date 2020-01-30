using System.ComponentModel.DataAnnotations;
using System;



namespace EcommerceApp.Models
{
    public class ProductOrders
    {
        public int ProductId {get; set;}
        public int OrderId {get; set;}
        // nav property to Products
        public Product Product {get; set;}
        // nav property to Orders
        public Order Order {get; set;}
    }
}