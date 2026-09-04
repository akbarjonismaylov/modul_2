using Lesson4.Polygon;
using Lesson4.Polygon.Abstract;

namespace LG_CoffeeMachine;

public class Lg99Pro : CoffeeMakerWithWater
{
    public override void AddWater()
    {
        Console.WriteLine("Adding water to LG99Pro...");
        this.WaterCupAmount += 5; // LG99Pro adds 5 cups of water at a time
    }

    public override Coffee BrewCoffee(int coffeeSpoonCount)
    {
        // suv qaynat
        // kofe qo'sh
        int water = WaterCupAmount;
        return new Coffee($"Latte with {water} water");
    }
}

public class Lg99ProWithMilk : CoffeeMakerWithWater
{
    public override Coffee BrewCoffee(int coffeeSpoonCount)
    {
        // suv qaynat
        // kofe qo'sh
        // sut aralashtir
        int water = WaterCupAmount;
        return new Coffee($"Latte with {water} water and milk");
    }
}
