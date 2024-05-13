using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NLayer.MVC.Models;

namespace NLayer.MVC.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }

  

    }
}
