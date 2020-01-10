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
            List<User> AllUsers = dbContext.Users.ToList();
                return View("index", AllUsers);
            }

            [HttpGet]      
            [Route("ContentCreator")]     
            public ViewResult ContentCreator()
            {
                return View("ContentCreator");
            }

            [HttpGet]      
            [Route("login")] 
            public ViewResult RenderLogin()
            {
                return View("login");
        }


        [HttpPost("LoginUser")]
        public IActionResult LoginUser(LoginUser thisUser)
        {
            {       if(ModelState.IsValid)
                {
                    var userInDb = dbContext.Users.FirstOrDefault(u => u.Email == thisUser.Email);
                
                    if(userInDb == null)
                    {
                        ModelState.AddModelError("Email", "Invalid Email or Password");
                        return View();
                    }   
                    
                    var hasher = new PasswordHasher<LoginUser>();
                    var result = hasher.VerifyHashedPassword(thisUser, userInDb.Password, thisUser.Password);
                    
                    if(result == 0)
                    {
                        ModelState.AddModelError("Email", "Invalid Email or Password");
                        return View("Login");
                    }
                    else
                    {
                        HttpContext.Session.SetString("Email", thisUser.Email);
                        string UserEmail = HttpContext.Session.GetString("Email");
                        return RedirectToAction("Index");
                    } 
                
                }
                Console.WriteLine("hellpppppp");
                return View("Login");
        }
        }


        [HttpPost("Create")]
        public IActionResult Create(User myUser)
        {

            if(ModelState.IsValid) 
            {   
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
                    System.Console.WriteLine(myUser.UserId);
                    dbContext.SaveChanges();
                    
                    User UserFromDB = dbContext.Users.FirstOrDefault(u => u.Email == myUser.Email);
                    Console.WriteLine("///////////////////////////////");

                    Console.WriteLine(UserFromDB);
                    Page Userpage = new Page(){name=UserFromDB.FirstName +" Page", about=" ",UserId=UserFromDB.UserId};
                    dbContext.Pages.Add(Userpage);
                    dbContext.SaveChanges();

                    return RedirectToAction("Index");    
                }
                    
            }
            return View("index");
        }

        }
    }