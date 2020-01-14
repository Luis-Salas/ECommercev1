using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

using EcommerceApp.Models;
    namespace EcommerceApp.Controllers 
    {
        public class UserPageController : Controller  
        {
            [HttpGet]      
            [Route("UserPage/{id}")]    
            public ViewResult DisplayUserPage()
            {            
                return View("Home");
            }
        }

    }