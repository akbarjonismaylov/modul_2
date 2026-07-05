namespace Lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            Praduct praduct = new Praduct
            {
                
                PraductId = Guid.NewGuid(),
                PraductName = "Laptop",
                BussinessName = "TechStore",
                Price = 999.99m,
                term = dateTime.AddDays(30)

            };
            Console.WriteLine(praduct);
        }
    }
}
