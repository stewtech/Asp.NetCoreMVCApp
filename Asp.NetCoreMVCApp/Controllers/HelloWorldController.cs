using Asp.NetCoreMVCApp.Models;
using Microsoft.AspNetCore.Mvc;


namespace Asp.NetCoreMVCApp.Controllers
{
    public class HelloWorldController : Controller
    {

        private static List<DogViewModel> dogs = new List<DogViewModel>();
        public IActionResult Index()
        {
            return View(dogs);
        }

        public IActionResult Create()
        {
            var dogVm = new DogViewModel();
            return View(dogVm);
        }

        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            //return View("Index");
            dogs.Add(dogViewModel);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Hello()
        {
            DogViewModel dog = new DogViewModel()
            { Name = "Gus", Age = 4 };
            return View(dog);
        }
    }
}
