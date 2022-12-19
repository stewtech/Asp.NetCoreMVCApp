using Asp.NetCoreMVCApp.Models;
using Microsoft.AspNetCore.Mvc;


namespace Asp.NetCoreMVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            DogViewModel doggo = new DogViewModel() { Name= "Sif", Age=2 };
            return View(doggo);
        }

        public IActionResult Hello()
        {
            DogViewModel dog = new DogViewModel()
            { Name = "Gus", Age = 4 };
            return View(dog);
        }
    }
}
