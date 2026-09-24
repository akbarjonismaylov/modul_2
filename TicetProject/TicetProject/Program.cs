using TicetProject.Dtos;
using TicetProject.Services;

namespace TicetProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPassengerService passengerService = new FilePassengerService();

            var newDto = new PassengerCreateDto
            {
                FirstName = "Akbarjon",
                LastName = "Ismaylov",
                PassportNumber = "Ad1234567",
                Pinfl = "12345678901234",
                BirthDate = new DateTime(2004, 11, 10)
            };

            var result = passengerService.Add(newDto);

            Console.WriteLine($"Natija: {result.IsSuccess} | Xabar: {result.Message}");

            var list = passengerService.GetAll();

            foreach (var p in list)
            {
                Console.WriteLine($"ID: {p.Id} | Ism: {p.FirstName} {p.LastName} | Pasport: {p.PassportNumber}");
            }
        }
    }
}
