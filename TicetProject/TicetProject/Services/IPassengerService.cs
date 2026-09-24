using TicetProject.Dtos;
using TicetProject.Entities;
namespace TicetProject.Services;

public interface IPassengerService
{
    (bool IsSuccess, string Message) Add(PassengerCreateDto dto);
    List<Passenger> GetAll();
    Passenger? GetById(Guid id);
    bool Delete(Guid id);
}
