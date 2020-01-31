using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using System.IO;


using EcommerceApp.Models;
namespace EcommerceApp.Controllers
{
    public class UserPageController : Controller
    {
        private HomeContext dbContext;
        private readonly IHostingEnvironment hostingEnvironment;



        public UserPageController(IHostingEnvironment hostingEnvironment, HomeContext context)
        {
            this.hostingEnvironment = hostingEnvironment;
            dbContext = context;

        }
        // here we can "inject" our context service into the constructor

        [HttpGet]
        [Route("UserPage/{id}")]
        public ViewResult DisplayUserPage(int id)
        {
            var userPageName = dbContext.Pages
                .Include(P => P.UsersPage)
                .Include(P => P.Products)
                // .Include(D => D.design)
                .FirstOrDefault(P => P.UserId == id);
            ViewBag.PageName = userPageName.name;
            ViewBag.id = userPageName.PageId;
            ViewBag.products = userPageName.Products;
            // ViewBag.AllDesigns = dbContext.Designs

            return View("Home");
        }
        [HttpPost]
        [Route("CreateProduct/{id}")]
        public IActionResult CreateProduct(Product ProductInfo, int id)
        {
            dbContext.Products.Add(ProductInfo);
            dbContext.SaveChanges();

            return RedirectToAction("DisplayUserPage", new{id = id});
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

            var newConnection = new ProductStyle() { ProductId = id, StyleId = styleid };
            System.Console.WriteLine("/////////////////////");
            System.Console.WriteLine(id);
            dbContext.ProductStyles.Add(newConnection);
            dbContext.SaveChanges();
            return Redirect("/DisplayProductPage/" + id);
        }
        [HttpGet]
        [Route("DisplayDesignPage/{PageId}")]
        public IActionResult DisplayDesignPage(int PageId)
        {   
            ViewBag.PageId = PageId;
            return View();
        }

        [HttpPost]
        [Route("CreateDesign/{PageId}")]
        public IActionResult CreateDesign(DesignViewModel DesignformData, int PageId)
        {
            string uniqueFileName = null;

            // If the Photo property on the incoming model object is not null, then the user
            // has selected an image to upload.
            if (DesignformData.Photo != null)
            {
                System.Console.WriteLine("///////////////////////////////////////////");
                // The image must be uploaded to the images folder in wwwroot
                // To get the path of the wwwroot folder we are using the inject
                // HostingEnvironment service provided by ASP.NET Core
                string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                // To make sure the file name is unique we are appending a new
                // GUID value and and an underscore to the file name
                uniqueFileName = Guid.NewGuid().ToString() + "_" + DesignformData.Photo.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                // Use CopyTo() method provided by IFormFile interface to
                // copy the file to wwwroot/images folder
                DesignformData.Photo.CopyTo(new FileStream(filePath, FileMode.Create));
            }

            Design newDesign = new Design
            {
                PromoTime = DesignformData.PromoTime,
                // Store the file name in PhotoPath property of the employee object
                // which gets saved to the Employees database table
                Image = uniqueFileName
            };

            dbContext.Designs.Add(newDesign);
            dbContext.SaveChanges();
            return RedirectToAction("DisplayUserPage", new {id = PageId });
        }
        // public string generateID()
        // {
        //     var guid = Guid.NewGuid();
        //     return Guid.NewGuid().ToString();
        // }
        // public string generateID(string sourceUrl)
        // {
        //     return string.Format("{0}_{1:N}", sourceUrl, Guid.NewGuid());
        // }
    }

}
