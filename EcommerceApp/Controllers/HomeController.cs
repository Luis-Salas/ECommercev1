    using Microsoft.AspNetCore.Mvc;
    using EcommerceApp.Models;
    namespace EcommerceApp.Controllers 
    {
        public class Home : Controller  
        {
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
        }
    }