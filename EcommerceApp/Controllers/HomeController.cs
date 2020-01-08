    using Microsoft.AspNetCore.Mvc;
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
        }
    }