using CarDealershipMVC.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarDealership.Services
{
    public interface ICarService
    {
        Task<CarDataModel> GetCarAsync(CarDataModel model);
        Task<List<CarDataModel>> GetCarByColor(string color);
        Task<List<CarDataModel>> GetCarByMake(string make);
        Task<List<CarDataModel>> GetCarByModel(string model);
        Task<List<CarDataModel>> GetCarByYear(int year);
    }
}