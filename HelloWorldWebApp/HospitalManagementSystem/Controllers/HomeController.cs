using HospitalManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            TempData["Foo"] = "Hello Foo! From Temp Data";
            ViewData["Foo"] = "Hello Foo! From View Data";
            ViewBag.Foo = "Hello Foo! From View Bag";

            _logger.LogInformation($"View Data for Foo: {ViewData["Foo"]}");
            _logger.LogInformation($"View Bag for Foo: {ViewBag.Foo}");
            _logger.LogInformation($"Temp Data for Foo: {TempData["Foo"]}");
            TempData.Keep();

            return View();
        }

        public IActionResult Privacy()
        {
            _logger.LogInformation($"View Data for Foo: {ViewData["Foo"]}");
            _logger.LogInformation($"View Bag for Foo: {ViewBag.Foo}");
            _logger.LogInformation($"Temp Data for Foo: {TempData["Foo"]}");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
