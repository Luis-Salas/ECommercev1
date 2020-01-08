using System.ComponentModel.DataAnnotations;
using System;

namespace EcommerceApp.Models
{
    public class Product
    {
        [key]
        public int ProductId {get;set;}

        public string ProductName {get;set;}

        public string ProductSize {get;set;}

        public string ProductDescription {get;set;}

        public string Testimonial {get;set;}

        public string ProductStyle {get;set;}

        public string ProductColor {get;set;}

        public int ProductQuantity {get;set;}
        
        //--------Foreign Ket-----------
        public int UserId {get;set;}
        //------------------------------



        //--------Navagational Property ---------

        //---------------------------------------

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}