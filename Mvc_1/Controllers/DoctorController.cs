using Microsoft.AspNetCore.Mvc;
using Mvc_1.Models;

namespace Mvc_1.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult Fever()
        {
            fevCalc fev = new fevCalc(0);
            return View(fev);
        }
        [HttpPost]
        public IActionResult Fever(int temp)
        {
            
            fevCalc fev = new fevCalc(temp);
            return View(fev);
        }
    }
}
