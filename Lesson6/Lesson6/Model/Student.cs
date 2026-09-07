namespace Lesson6.Model;

public class Student
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Password { get; set; }
    public int Age { get; set; }


    public Student(string firstName, string lastName, string password, int age)
    {
        Id = Guid.NewGuid();
        FirstName = firstName;
        LastName = lastName;
        Password = password;
        Age = age;
    }

   
}
