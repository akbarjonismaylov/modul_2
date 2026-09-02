using Lesson3.Model;

namespace Lesson3.Services;

public class BookService
{
    private List<Books> _books;

    public BookService()
    {
        _books = new List<Books>();
    }

    public Guid AddBook(Books books)
    {
        books.BookId = Guid.NewGuid();
        _books.Add(books);
        return books.BookId;
    }

    public Books? GetBookById(Guid bookId)
    {
        foreach (var book in _books)
        {
            if (book.BookId == bookId)
            {
                return book;
            }
        }
        return null;
    }

    public bool DeleteBook(Guid bookId)
    {
        var book = GetBookById(bookId);
        if (book == null)
        {
            return false;
        }
        _books.Remove(book);
        return true;
    }

    public bool UpdateBook(Guid bookId, Books newBooks)
    {
        var book = GetBookById(bookId);
        if (book == null)
        {
            return false;
        }

        book.Title = newBooks.Title;
        book.Author = newBooks.Author;
        book.Genre = newBooks.Genre;
        book.Year = newBooks.Year;
        return true; 
    }

}
