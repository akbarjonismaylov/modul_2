using Lesson4.Polygon;
using Lesson4.Polygon.Abstract;

namespace SamsungCoffeeMachine;

public class SamsungS66Ultra : CoffeeMakerWithWater
{
    public override Coffee BrewCoffee(int coffeeSpoonCount)
    {
        // suv qaynat
        // sut aralashtir
        // qahvani fincana qoy
        return new Coffee("Cappuccino");
    }
}
