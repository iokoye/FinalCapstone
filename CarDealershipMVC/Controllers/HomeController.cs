using CarDealership.Services;
using CarDealershipMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealershipMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICarService _service;

        public HomeController(ILogger<HomeController> logger, ICarService service)
        {
            _logger = logger;
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public async Task<IActionResult> SearchCarByYear(int year)
        {
            var car = await _service.GetCarByYear(year);
            return View(car);
        }
        public async Task<IActionResult> SearchCarByColor(string color)
        {
            var car = await _service.GetCarByColor(color);
            return View(car);
        }
        public async Task<IActionResult> SearchCarByModel(string model)
        {
            var car = await _service.GetCarByModel(model);
            return View(car);
        }

        public async Task<IActionResult> SearchCarByMake(string make)
        {
            var car = await _service.GetCarByMake(make);
            return View(car);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
