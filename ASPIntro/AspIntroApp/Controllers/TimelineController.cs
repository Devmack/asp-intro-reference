using System.Collections.Generic;
using AspIntroApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspIntroApp.Controllers
{
    public class TimelineController : Controller
    {
        public List<TimelineModel> timelineItems;

        public TimelineController()
        {
            timelineItems = new List<TimelineModel>();
        }

        [HttpGet]
        [Route("/Timeline/Index")]
        public ActionResult Index()
        {
            timelineItems = GetListWithTestModels();
            return View(timelineItems);
        }

        public List<TimelineModel> GetListWithTestModels()
        {
            var models = new List<TimelineModel>();
            models.Add(new TimelineModel(1, "Read about http - what is for, its structure and return codes. How apps talk to each other via http"));
            models.Add(new TimelineModel(2, "Introduce yourself to asp.net core framework project structure. Read about purpose of specific file. For now, you don't have to know all the details"));
            models.Add(new TimelineModel(3, "Read about MVC layer within asp.net core. Think how your understanding of mvc correspond with it's web interpretation"));
            models.Add(new TimelineModel(4, "Dive into routing - what routing is, how it helps build web app and how it deal with http"));
            models.Add(new TimelineModel(5, "Get to know Razor - for now we will use razor to inject data from backend into front"));
            return models;
        }

    }
}