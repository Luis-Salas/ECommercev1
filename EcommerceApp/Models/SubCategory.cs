using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;


namespace EcommerceApp.Models
{
    public class SubCategory
    {
        [Key]
        public int SubCategoryId {get;set;}

        // //MIGHT WANT TO SEPERATE THESE SUBCATEGORIES INTO THEIR OWN MODEL*********
        // public string Blazers {get;set;}
        // public string Cardigans{get;set;}
        // public string Coats{get;set;}
        // public string Jackets{get;set;}
        // public string Vests{get;set;}
        // public string CapriPants{get;set;}
        // public string DressPants{get;set;}
        // public string Jeans{get;set;}
        // public string JumperPants{get;set;}
        // public string SkinnyPants{get;set;}
        // public string StraightCutPants{get;set;}
        // public string SweatPants{get;set;}
        // public string BasicShorts{get;set;}
        // public string DenimShorts{get;set;}
        // public string PatternedShorts{get;set;}
        // public string SwimmingTrunks{get;set;}
        // public string CasualShirts{get;set;}
        // public string DressShirts{get;set;}
        // public string KnitTops{get;set;}
        // public string PoloShirts{get;set;}
        // public string SweatShirts{get;set;}
        // public string TShirts{get;set;}
        // public string Socks{get;set;}
        // public string PhoneCases{get;set;}
        // public string Belts{get;set;}
        // public string Eyewear{get;set;}
        // public string Jewlery{get;set;}
        // public string Hats{get;set;}
        // public string Gloves{get;set;}
        // public string Scarves{get;set;}
        // public string Watches{get;set;}
        // public string Glasses{get;set;}

        // //----Foreign Key -------

        // public int CategoryId {get;set;}

        // //-----------------------

        //         // -------NAVIGATIONAL PROPERTIES HERE------------

        // //Link with model that the user is using to create product and 
        // //The list of products the user has access to + pages etc

        // //------------------------------------------------

        
        // public DateTime CreatedAt {get;set;} = DateTime.Now;
        // public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}