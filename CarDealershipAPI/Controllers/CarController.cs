using CarDealershipAPI.Data;
using CarDealershipAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealershipAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly CarDbContext _context;

        public CarController(CarDbContext context)
        {
            _context = context;
        }

        // GET, POST, PUT, DELETE
        [HttpPost]
        public async Task<IActionResult> AddCar(Car model)
        {
            await _context.Cars.AddAsync(model);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet("getCarByMake/{make}")]
        public async Task<IActionResult> GetCarByMake(string make)
        {
            var cars = _context.Cars.Where(c => c.Make == make).ToList();

            return Ok(cars);
        }

        [HttpGet]
        public async Task<IActionResult> GetCar(Car model)
        {
            var cars = _context.Cars.Where(c => c.Make == model.Make || c.Model == model.Model || c.Year == model.Year || c.Color == model.Color).ToList();           

            return Ok(cars);
        }
    }
}
