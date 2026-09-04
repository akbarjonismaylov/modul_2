namespace Lesson4.Polygon.Abstract;

public abstract class CoffeeMakerWithWater
{
    public abstract Coffee BrewCoffee(int coffeeSpoonCount);

    public virtual void AddWater()
    {
        Console.WriteLine("Adding water...");
        this.WaterCupAmount++;
    }

    public int WaterCupAmount { get; protected set; }
}
