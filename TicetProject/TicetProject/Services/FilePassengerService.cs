using TicetProject.Dtos;
using TicetProject.Entities;
using TicetProject.Extensions;
namespace TicetProject.Services;

public class FilePassengerService : IPassengerService
{
    private readonly string _filePath = "passengers.txt";

    public FilePassengerService()
    {
        if (!File.Exists(_filePath))
        {
            File.Create(_filePath).Close();
        }
    }

    public (bool IsSuccess, string Message) Add(PassengerCreateDto dto)
    {
        var validation = dto.Validate();
        if (!validation.IsValid)
        {
            return (false, validation.ErrorMessage);
        }

        Passenger passenger = dto.ToEntity();

        string line = $"{passenger.Id}, {passenger.FirstName}, {passenger.LastName}, {passenger.PassportNumber},{passenger.Pinfl},{passenger.DateofBirth:yyyy.MM.dd}";
        File.AppendAllText(_filePath, line + Environment.NewLine);

        return (true, "Yo'lovchi Muvaffaqiyatli qo'shildi!");
    }


    public List<Passenger> GetAll()
    {
        var passengers = new List<Passenger>();

        if (!File.Exists(_filePath)) return passengers;

        string[] lines = File.ReadAllLines(_filePath);

        foreach (var line in lines)
        {
            if(string.IsNullOrEmpty(line)) continue;

            string[] parts = line.Split(',');

            var passenger = new Passenger
            {
                Id = Guid.Parse(parts[0]),
                FirstName = parts[1],
                LastName = parts[2],
                PassportNumber = parts[3],
                Pinfl = parts[4],
                DateofBirth = parts.Length > 5 ? DateTime.Parse(parts[5]) : null
            };
            passengers.Add(passenger);
        }
        return passengers;
    }

    public Passenger? GetById (Guid id)
    {
        return GetAll().FirstOrDefault(p => p.Id == id);
    }

    public bool Delete(Guid id)
    {
        var passengers = GetAll();
        var passenger = passengers.FirstOrDefault(p => p.Id == id);

        if (passenger == null) return false;
        passengers.Remove(passenger);

        var lines = passengers.Select(p => $"{p.Id},{p.FirstName},{p.LastName},{p.PassportNumber},{p.Pinfl},{p.DateOfBirth:yyyy-MM-dd}");
        File.WriteAllLines(_filePath, lines);
        return true;
    }
}
