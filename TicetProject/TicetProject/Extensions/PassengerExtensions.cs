using TicetProject.Dtos;
using TicetProject.Entities;

namespace TicetProject.Extensions;

public static class PassengerExtensions
{
    public static Passenger ToEntity(this PassengerCreateDto dto)
    {
        return new Passenger
        {
            FirstName = dto.FirstName,
            LastName = dto.LastName,
            PassportNumber = dto.PassportNumber,
            Pinfl = dto.Pinfl,
            DateofBirth = dto.BirthDate,
        };
    }

    public static (bool IsValid, string ErrorMessage) Validate(this PassengerCreateDto dto)
    {
        if (string.IsNullOrEmpty(dto.FirstName) || string.IsNullOrEmpty(dto.LastName))
            return (false, "Ism va familiya bo'sh bo'lishi mumkin emas!");
        if (dto.PassportNumber.Length != 9)
            return (false, "Pasport seriyasi 9 ta belgidan iborat bo'lishi kerak!");
        if (dto.Pinfl.Length != 14)
            return (false, "PINFL 14 ta raqamdan iborat bo'lishi kerak!");

        return(true, string.Empty);
    }

}
