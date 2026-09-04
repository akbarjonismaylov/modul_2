using Lesson4.Models;
using System.Numerics;

namespace Lesson4.Servises;

public class BookServis
{
    private List<Books> _books;

    public BookServis()
    {
        _books = new List<Books>();
    }

    public void addBook(Books book)
    {
        _books.Add(book);
    }

    public List<Books> GetAllBooks()
    {
        return _books;
    }

    private Books GetBooksById(Guid bookId)
    {
        foreach(var book in _books)
        {
            if(book.Id == bookId)
            {
                return book;
            }
        }
        return null;
    }

    public bool UpdateBook(Guid bookId, Books newBooks)
    {
        var book = GetBooksById(bookId);
        if(book == null)
        {
            return false;
        }

        book.Title = newBooks.Title;
        book.Author = newBooks.Author;
        book.Genre = newBooks.Genre;
        book.Year = newBooks.Year;
        return true;
    }

    public bool DeleteBook(Guid bookId)
    {
        var book = GetBooksById(bookId);
        if (book == null)
        {
            return false;
        }
        _books.Remove(book);
        return true;
    }
}
