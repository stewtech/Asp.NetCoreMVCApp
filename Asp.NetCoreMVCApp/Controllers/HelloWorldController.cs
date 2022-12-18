using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCoreMVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
