using lesson2.Models;
using lesson2.Services;

namespace lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            {
                car.CarId = Guid.NewGuid();
                car.CarName = "Toyota";
                car.CarModel = "Camry";
                car.CarYear = 2020;
                car.CarColor = "Red";
                car.CarPrice = 25000.00m;
            }
            Car car2 = new Car();
            {
                car2.CarId = Guid.NewGuid();
                car2.CarName = "Honda";
                car2.CarModel = "Civic";
                car2.CarYear = 2021;
                car2.CarColor = "Blue";
                car2.CarPrice = 22000.00m;
            }
            Car car3 = new Car();
            {
                car3.CarId = Guid.NewGuid();
                car3.CarName = "Ford";
                car3.CarModel = "Mustang";
                car3.CarYear = 2022;
                car3.CarColor = "Black";
                car3.CarPrice = 30000.00m;
            }

            CarService carService = new CarService();

            var car1id = carService.AddCar(car);
            var car2id = carService.AddCar(car2);
            var car3id = carService.AddCar(car3);

            carService.DeleteCar(car3id);
            var cars  = carService.GetAllCars();

        }
    }
}