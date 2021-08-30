using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloWorldWebApp.Models;

namespace HelloWorldWebApp.Controllers
{
    public class HomeController : Controller
    {
        //[Route("/")]
        //[Route("/Home")]
        //[Route("/Home/Index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
