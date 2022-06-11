using CarListMauiApp.Models;
using CarListMauiApp.Services;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarListMauiApp.ViewModels
{
    public partial class CarListViewModel :BassViewModel
    {
        private readonly CarService carService;
        public ObservableCollection<Car> Cars { get; private set; } = new();

        public CarListViewModel(CarService carService)
        {
            Title = "Car List";
            this.carService = carService;
        }

        [ICommand]
        async Task GetCarList() 
        {
            if (IsLoading) return;
            try 
            { 
                IsLoading = true;
                if (Cars.Any()) Cars.Clear();

                var cars =carService.GetCars();
                foreach (var car in cars) Cars.Add(car);
  
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Unable to get cars:{ex.Message}");
                await Shell.Current.DisplayAlert("Error", "Failed to retrive the list of cars.", "OK");
            }
            finally
            {
                IsLoading = false;
            }
        
        }
    }
}
