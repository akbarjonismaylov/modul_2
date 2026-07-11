using lesson2.Models;

namespace lesson2.Services;

public class CarService
{
    public List<Car> Cars = new List<Car>();

    public Guid AddCar(Car car)
    {
        car.CarId = Guid.NewGuid();
        Cars.Add(car);
        return car.CarId;
    }
    public List<Car> GetAllCars()
    {
        return Cars;
    }
    public bool DeleteCar(Guid carId)
    {
        foreach (var car in Cars)
        {
            if (car.CarId == carId)
            {
                Cars.Remove(car);
                return true;
            }
        }
        return false;
    }

}
