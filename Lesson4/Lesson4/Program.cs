using Lesson4.Models;
using Lesson4.Servises;

namespace Lesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookServis servis = new BookServis();

            Books hobbit = new Books("The Hobbit", "J.R.R. Tolkien", 1937, "Fantasy");
            Books book1984 = new Books("1984", "George Orwell", 1949, "Dystopia");

            servis.addBook(hobbit);
            servis.addBook(book1984);

            Console.WriteLine("All Books:");
            foreach (var book in servis.GetAllBooks())
            {
                book.Print();
            }

            Console.WriteLine("\n --- Search: 'Hob' ---");
            foreach (var book in servis.GetAllBooks())
            {
                if (book.MatchesSearch("Hob"))
                {
                    book.Print();
                }
            }

            Console.WriteLine(("\n --- Search: ---"));
            Books NewInfo  = new Books("The Hobbit", "J.R.R. Tolkien", 1951, "Fantasy");
            bool updated = servis.UpdateBook(hobbit.Id, NewInfo);
            Console.WriteLine(updated ? "Book updated successfully." : "Book update failed.");
            hobbit.Print();

            Console.WriteLine("\n --- Deleted Book: ---");
            bool deleted = servis.DeleteBook(book1984.Id);
            Console.WriteLine(deleted ? "Book deleted successfully." : "Book delete failed.");

            Console.WriteLine("\nAll Books after deletion:");
            foreach (var book in servis.GetAllBooks())
            {
                book.Print();
            }
        }
    }
}
