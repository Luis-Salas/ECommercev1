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
            private HomeContext dbContext;
     
            // here we can "inject" our context service into the constructor
            public UserPageController(HomeContext context)
            {
                dbContext = context;
            }

            [HttpGet]      
            [Route("UserPage/{id}")]    
            public ViewResult DisplayUserPage()
            {            
                int? IdFromDb = HttpContext.Session.GetInt32("Id"); 
                var userPageName =  dbContext.Pages.Include(P => P.UsersPage)
                    .Where(P => P.UserId == IdFromDb);
                System.Console.WriteLine(userPageName);
                System.Console.WriteLine("///////////////////////");

                return View("Home");
            }
        }

    }