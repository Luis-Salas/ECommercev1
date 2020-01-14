using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;


namespace EcommerceApp.Models
{
    public class SubStyle
    {
        [Key]
        public int SubStyleyId {get;set;}
        public string Name {get;set;}
        //navigation property to Style
        public int StyleId {get;set;}
        public Style ParentStyle{get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

    }
}