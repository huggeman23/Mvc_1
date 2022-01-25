using Microsoft.AspNetCore.Mvc;
using Mvc_1.Models;

namespace Mvc_1.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Projects()
        {

            return View();
        }
        
    }
}
