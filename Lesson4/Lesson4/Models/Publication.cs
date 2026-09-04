namespace Lesson4.Models;

public abstract class Publication
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

    protected Publication(string title, string author, int year)
    {
        Id = Guid.NewGuid();
        Title = title;
        Author = author;
        Year = year;
    }
}
