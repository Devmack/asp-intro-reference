using Microsoft.AspNetCore.Mvc;

namespace AspIntroApp.Controllers
{
    public class MainPageController : Controller
    {   
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }

       
    }
}