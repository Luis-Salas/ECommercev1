using System.ComponentModel.DataAnnotations;
using System;

namespace EcommerceApp.Models
{
    public class Style
    {
        [key]
        public int StyleId {get;set;}

        public string StyleType {get;set;}

        //-------Foreign Key -------------
        // Will the style inherit anything from the User?

        public int ProductId {get;set;}
        public int PageId {get;set;}
        //--------------------------------


        //-----Navigational Property------


        //--------------------------------

        
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}