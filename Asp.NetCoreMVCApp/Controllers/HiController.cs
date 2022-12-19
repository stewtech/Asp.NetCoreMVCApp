using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCoreMVCApp.Controllers
{
    public class HiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Whatup()
        {
            return View();
        }
    }
}
