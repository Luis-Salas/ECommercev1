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
            public ViewResult DisplayUserPage(int id)
            {            
                var userPageName =  dbContext.Pages
                    .Include(P => P.UsersPage)
                    .Include(P => P.Products)
                    .FirstOrDefault(P => P.UserId == id);
                ViewBag.PageName = userPageName.name;
                ViewBag.id = userPageName.PageId;
                ViewBag.products = userPageName.Products;
                return View("Home");
            }
            [HttpPost]      
            [Route("CreateProduct/{id}")]    
            public IActionResult CreateProduct(Product ProductInfo, int id)
            {
                ProductInfo.PageId = id;
                dbContext.Products.Add(ProductInfo);
                dbContext.SaveChanges();

                return RedirectToAction("DisplayUserPage");
            }
            [HttpPost]      
            [Route("CreateStyle")]    
            public IActionResult CreateStyle(Style formData)
            {
                dbContext.Styles.Add(formData);
                dbContext.SaveChanges();
                return RedirectToAction("DisplayStylePage");
            }
            [HttpGet]      
            [Route("DisplayStylePage")]    
            public IActionResult DisplayStylePage()
            {
                return View();
            }
            [HttpGet]      
            [Route("DisplayProductPage/{id}")]    
            public IActionResult DisplayProductPage(int id)
            {
            ViewBag.ProductInfo = dbContext.Products.FirstOrDefault(product => product.ProductId == id);
            ViewBag.AllStyles = dbContext.Styles.ToList();

                return View();
            }

            [HttpPost]      
            [Route("AddStyleToProduct/{id}")]    
            public IActionResult AddStyleToProduct(int id, int styleid)
            {
                var newConnection = new ProductStyle(){ ProductId= id, StyleId= styleid};
                System.Console.WriteLine("/////////////////////");
                System.Console.WriteLine(id);
                dbContext.ProductStyles.Add(newConnection);
                dbContext.SaveChanges();
                return Redirect("/DisplayProductPage/" + id);
            }
            [HttpGet]      
            [Route("DisplayDesignPage")]    
            public IActionResult DisplayDesignPage()
            {
                return View();
            }
        }

    }
