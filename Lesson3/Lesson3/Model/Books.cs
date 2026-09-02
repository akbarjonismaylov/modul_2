
namespace Lesson3.Model;

public class Books
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public int Year { get; set; }
    public Guid BookId { get; internal set; }

    public Books(string title, string author, string genre, int year = 0)
    {
        Title = title;
        Author = author;
        Genre = genre;
        Year = year;
    }

    Books FindBook
}
