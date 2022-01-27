using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mvc_1.Models;
using System;

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
        public IActionResult GNumber()
        {
            var num = new Random();
            int j = num.Next(1, 100);
            HttpContext.Session.SetInt32("num", j);
            ViewBag.Message = j;
            return RedirectToAction("GuessNumber");
        }
        public IActionResult GuessNumber()
        {
            int num = (int)HttpContext.Session.GetInt32("num");
            ViewBag.Message =  num;
            return View();
        }
        [HttpPost]
        public IActionResult GuessNumber(int number)
        {
            numCheck numCheck = new numCheck();

            int num = (int)HttpContext.Session.GetInt32("num");
            ViewBag.Message = numCheck.numValid(number, num);

            if (ViewBag.Message != "Corect can you gues the next one")
            {
               
                return View();
            }
            else
            {

                return RedirectToAction("GNumber");
            }
        }
    }
}
