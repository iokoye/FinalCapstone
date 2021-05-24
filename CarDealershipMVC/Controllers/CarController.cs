using CarDealership.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealershipMVC.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarService _service;
        public CarController(ICarService service)
        {
            _service = service;
        }

        public IActionResult Index()
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
    }
}
