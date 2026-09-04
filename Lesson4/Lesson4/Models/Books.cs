namespace Lesson4.Models;

public class Books : Publication, ISearchable, IPrintable
{

    public string Genre { get; set; }

    public Books(string title, string author, int year, string genre) : base(title, author, year)
    {
        Genre = genre;
    }

    public bool MatchesSearch(string keyword)
    {
        return Title.Contains(keyword);
    }

    public void Print()
    {
        Console.WriteLine($"[Book] {Title} - {Author} ({Year}), Genre: {Genre}");
    }
}
