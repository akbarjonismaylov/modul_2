using Lesson4.Polygon.Abstract;
using Lesson4.Polygon.Interface;

namespace CoffeeApparatus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qaysi kofe");
            Console.WriteLine("1. Latte");
            Console.WriteLine("2. Cappuccino");
            var choice = Console.ReadLine();

            ICoffeeMaker coffeeMachine;

            switch (choice)
            {
                case "1":
                    coffeeMachine = new LG_CoffeeMachine.LgCoffeeMachine();
                    break;
                case "2":
                    coffeeMachine = new SamsungCoffeeMachine.SamsungCoffeeMachine();
                    break;
                default:
                    Console.WriteLine("Noto'g'ri tanlov");
                    return;
            }

            var coffee = coffeeMachine.BrewCoffee(2);
            Console.WriteLine($"Coffee is ready! Type: {coffee.CoffeeType}");

            // @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@

            Console.WriteLine("Qaysi kofe");
            Console.WriteLine("1. Latte");
            Console.WriteLine("2. Cappuccino");

            var choiceStr = Console.ReadLine();

            CoffeeMakerWithWater machineWithWater = ChooseMachine(choiceStr);

            string command = "";
            do
            {
                Console.WriteLine("Suv qo'shaymi ha/yo'q");
                command = Console.ReadLine();
                
                if (command == "ha")
                    machineWithWater.AddWater();

            } while (command != "exit");

            Console.WriteLine($"You have added {machineWithWater.WaterCupAmount} amount of water");

            var coffeeWithWater = machineWithWater.BrewCoffee(2);

            Console.WriteLine("Coffee is ready! Type: " + coffeeWithWater.CoffeeType);
        }

        private static CoffeeMakerWithWater ChooseMachine(string choice)
            => choice switch
            {
                "1" => new LG_CoffeeMachine.Lg99Pro(),
                "2" => new SamsungCoffeeMachine.SamsungS66Ultra(),
                _ => throw new ArgumentException("Noto'g'ri tanlov"),
            };


        private static void AddWater(CoffeeMakerWithWater coffeeMachineWithWater)
        {
            coffeeMachineWithWater.AddWater();
        }
    }
}
