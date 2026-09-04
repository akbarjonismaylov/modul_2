namespace Lesson4.Models;


public class Magazine : Publication, ISearchable, IPrintable
{
    public int IssueNumber { get; set; }

    public Magazine(string title, string author, int year, int issueNumber) : base(title, author, year)
    {
        IssueNumber = issueNumber;
    }

    public Magazine(string title, string author, int year) : base(title, author, year)
    {
    }

    public bool MatchesSearch(string keyword)
    {
        return Title.Contains(keyword);
    }

    public void Print()
    {
        Console.WriteLine($"[Jurnal] {Title} - {Author} ({Year}), Soni: {IssueNumber}");
    }
}
