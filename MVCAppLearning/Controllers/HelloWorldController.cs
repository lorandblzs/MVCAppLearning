using Microsoft.AspNetCore.Mvc;
using MVCAppLearning.Models;

namespace MVCAppLearning.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult  Index()  
        {
           DogViewModel dogo = new DogViewModel() { Name = "Sif", Age = 2 };
            return View(dogo);
        }

        public IActionResult Create() 
        {
            return View();
        }

        public string Hello()
        {
            return "Who's there?";
        }
    }
}
