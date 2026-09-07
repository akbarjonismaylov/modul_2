namespace Lesson6.Model;

public class Student : ISearchable, IPrintable
{
    public Guid StudentId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Password { get; set; }
    public int Age { get; set; }

    public Student (string firstName, string lastName, string password, int age)
    {
        StudentId = Guid.NewGuid();
        FirstName = firstName;
        LastName = lastName;
        Password = password;
        Age = age;
    }

    public bool MatchesSearch(string keyword)
    {
        return FirstName.Contains(keyword) || LastName.Contains(keyword);
    }

    public void Print()
    {
        Console.WriteLine($"{FirstName} {LastName}, Age: {Age}");
    }
}

