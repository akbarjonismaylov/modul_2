using Lesson4.Polygon;
using Lesson4.Polygon.Interface;

namespace LG_CoffeeMachine;

public class LgCoffeeMachine : ICoffeeMaker
{
    public Coffee BrewCoffee(int coffeeSpoonCount)
    {
        // suv qaynat
        // kofe qo'sh
        return new Coffee("Latte");
    }
}
