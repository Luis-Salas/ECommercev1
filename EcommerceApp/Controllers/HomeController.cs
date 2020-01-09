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
        public class HomeController : Controller  
        {
             private HomeContext dbContext;
     
            // here we can "inject" our context service into the constructor
            public HomeController(HomeContext context)
            {
                dbContext = context;
            }
            [HttpGet]      
            [Route("")]     
            public ViewResult Index()
            {
                return View("index");
            }
            [HttpGet]      
            [Route("ContentCreator")]     
            public ViewResult ContentCreator()
            {
                return View("ContentCreator");
            }
        [HttpPost("Create")]
        public IActionResult Create(User myUser)
        {
            System.Console.WriteLine("HEREEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEee");
            System.Console.WriteLine(myUser.FirstName);

            if(ModelState.IsValid) 
            {   
                            System.Console.WriteLine("HEREEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEee");

                if(dbContext.Users.Any(u => u.Email == myUser.Email))
                {   
                    ModelState.AddModelError("Email", "Email already in use!");
                    return View("Index");
                } 
                else
                {   
                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    myUser.Password = Hasher.HashPassword(myUser, myUser.Password);
                    dbContext.Users.Add(myUser);
                    dbContext.SaveChanges();
                    return RedirectToAction("Login");    
                }
                    
            }
            return View("Index");
        }

        }
    }