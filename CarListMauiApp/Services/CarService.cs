using CarListMauiApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarListMauiApp.Services
{
    public class CarService
    {
        public List<Car> GetCars() 
        {
            return new List<Car>() 
            { 
                new Car
                {
                    Id = 1, Make = "Honda", Model ="Fit", Vin= "100"
                },
                new Car
                {
                    Id = 2, Make = "Toyota", Model ="Prado", Vin= "200"
                },
                new Car
                {
                    Id = 3, Make = "Honda", Model ="Civic", Vin= "300"
                },
                new Car
                {
                    Id = 4, Make = "Audi", Model ="A5", Vin= "400"
                },
                new Car
                {
                    Id = 5, Make = "BMW", Model ="M3", Vin= "500"
                },
                new Car
                {
                    Id = 6, Make = "Nissan", Model ="Note", Vin= "528"
                },
                new Car
                {
                    Id = 7, Make = "Ferrari", Model ="Spider", Vin= "553"
                },
            };
        }
    }
}
