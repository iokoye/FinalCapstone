using CarDealershipMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarDealership.Services
{
    public class CarService : ICarService
    {
        private readonly HttpClient _client;

        public CarService(HttpClient client)
        {
            _client = client;
        }

        public async Task<CarDataModel> GetCarAsync(CarDataModel model)
        {
            return await _client.GetFromJsonAsync<CarDataModel>("GetCar");
        }

        public async Task<List<CarDataModel>> GetCarByMake(string make)
        {
            return await _client.GetFromJsonAsync<List<CarDataModel>>($"/getCarByMake/{make}");
        }
        public async Task<List<CarDataModel>> GetCarByModel(string model)
        {
            return await _client.GetFromJsonAsync<List<CarDataModel>>($"/getCarByMake/{model}");
        }
        public async Task<List<CarDataModel>> GetCarByColor(string color)
        {
            return await _client.GetFromJsonAsync<List<CarDataModel>>($"/getCarByMake/{color}");
        }
        public async Task<List<CarDataModel>> GetCarByYear(int year)
        {
            return await _client.GetFromJsonAsync<List<CarDataModel>>($"/getCarByMake/{year}");
        }


    }
}
