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
        public class CartController : Controller  
        {
             private HomeContext dbContext;
     
            // here we can "inject" our context service into the constructor
            public CartController(HomeContext context)
            {
                dbContext = context;
            }
            [HttpPost]      
            [Route("addItemToCart")]     
            public IActionResult addItemToCart()
            {

                        //this section should go in the add cart button
                // else
                // {
                //     //create a new order for the guest user
                //      Order newOrder = new Order
                //         {
                //             orderNumber = HttpContext.Session.GetString("guid"),
                //             // total = Product.Price,
                //             status = "not processed",
                //         };
                //         dbContext.Orders.Add(newOrder);
                //         dbContext.SaveChanges();

                //     //search db for the product
                //     Product ProductFromDB = dbContext.Products.FirstOrDefault(p => p.ProductId == ProductIdFromForm);
                //     //search for the order with guid so we  can get the id of order
                //     Order OrderFromdb = dbContext.Orders.FirstOrDefault(o => o.orderNumber == HttpContext.Session.GetString("guid"));
                //     //point product to order
                //     ProductFromDB.OrderId = OrderFromdb.OrderId;


                // }
                System.Console.WriteLine("//////////////////////////");
                return RedirectToAction("DisplayProductPage","UserPage", new{id = 1} );
            }

          
        }
    }