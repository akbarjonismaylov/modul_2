namespace TicetProject.Entities;

public class Passenger
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PassportNumber { get; set; }
    public string Pinfl { get; set; }
    public string? Patronymic { get; set; }
    public DateTime? DateofBirth { get; set; }

}
