using Lesson4.Polygon;
using Lesson4.Polygon.Interface;

namespace SamsungCoffeeMachine;

public class SamsungCoffeeMachine : ICoffeeMaker
{
    public Coffee BrewCoffee(int coffeeSpoonCount)
    {
        // suv qaynat
        // sut aralashtir
        // qahvani fincana qoy
        return new Coffee("Cappuccino");
    }
}
