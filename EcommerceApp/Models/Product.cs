using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;


namespace EcommerceApp.Models
{
    public class Product
    {
        [Key]
        public int ProductId {get;set;}

        public string ProductName {get;set;}

        public string ProductSize {get;set;}

        public string ProductDescription {get;set;}

        public string Testimonial {get;set;}


        public string ProductColor {get;set;}
        public int ProductPrice {get;set;}


        public int ProductQuantity {get;set;}
        //navigation property to design
        public int DesignId {get;set;}
        public Design design {get;set;}

        //navigation property to page
        public int PageId {get;set;}
        public Page ProductsPage {get;set;}

        //navigation property to productstyle
        public List<ProductStyle> ProductsStyles {get; set;}
        //navigation property to productOrder
        public List<ProductOrders> Buying {get; set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}