using System.Collections.Generic;
using AspIntroApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspIntroApp.Controllers
{
    public class LearningResourceController : Controller
    {
        List<LearningResourceModel> models;

        public LearningResourceController()
        {
            models = new List<LearningResourceModel>();
        }

        /*
         We are using annotation to ensure suitable request method and to 
         map controller method to be triggered when given route will be requested in web 
         browser 

        */
        [HttpGet]
        [Route("/LearningResource/Index")]
        public ActionResult Index()
        {
            /*
                Loaded data is passed to a view which 
                (with integration with razor)
                will render requested informations
            */
            models = GetListWithTestModels();
            return View(models);
        }

        public List<LearningResourceModel> GetListWithTestModels()
        {
            /*
               Here we are preparing in-memory data, 
               usually the parsed data to model 
               will come from database layer
            */

            var models = new List<LearningResourceModel>();
            models.Add(new LearningResourceModel("Introduction to ASP.NET Core", "let's start with framework introduction.", "https://docs.microsoft.com/en-us/aspnet/core/introduction-to-aspnet-core?view=aspnetcore-3.1", LearningCategory.ASP_BASIC, 2));
            models.Add(new LearningResourceModel("ASP.NET Core fundamentals", "more information on how the magic under the hood works. You **do not** need to know and understand those. They are here to sate your curiosity", "https://docs.microsoft.com/en-us/aspnet/core/fundamentals/?view=aspnetcore-3.1", LearningCategory.MVC, 3));
            models.Add(new LearningResourceModel("Introduction to Controllers", "in ASP .NET Core or simplified [Straightforward Controller]", "https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/actions?view=aspnetcore-3.1", LearningCategory.ASP_BASIC, 3));
            models.Add(new LearningResourceModel("Introduction to Routing", "mapping our code to certain address. We recommend starting with *Attribute Routing* first. Checkout how to pass a parameter and how to handle different http request types.", "https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/routing?view=aspnetcore-3.1", LearningCategory.ASP_BASIC, 10));
            models.Add(new LearningResourceModel("Introduction to Views", "Layer responsible for visual representation of an app with embedded razor", "https://docs.microsoft.com/en-us/aspnet/core/mvc/views/overview?view=aspnetcore-3.1", LearningCategory.MVC, 6));
            models.Add(new LearningResourceModel("Introduction to Razor Pages", "they help you build web UI easier and more productive. They let you write C# code directly on the html via .cshtml format. Read up on them, they will come in usefull for you.", "https://docs.microsoft.com/en-us/aspnet/web-pages/overview/getting-started/introducing-razor-syntax-c", LearningCategory.ASP_BASIC, 4));
            return models;
        }

    }      
}