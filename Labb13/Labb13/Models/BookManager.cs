using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb13.Models
{
   public class BookManager
    {
        public List<Book> Books { get; set; }

        public BookManager()
        {
             Books = new List<Book>
            {
                new Book { Name = "Lord of the rings", Pages = 280 },
                new Book { Name = "Catcher in the rye", Pages = 150 },
                new Book { Name = "The Triad", Pages = 400 }
            };
        }

        public void AddBook()
        {
            var newBook = new Book();

            Console.Write("Name: ");
            newBook.Name = Console.ReadLine();

            Console.Write("Pages: ");
            newBook.Pages = int.Parse(Console.ReadLine());

            Books.Add(newBook);
            Console.WriteLine("Book added");
            Console.ReadKey(true);
        }

        public void PrintAllBooks()
        {
            foreach (var book in Books)
            {
                Console.WriteLine("Name: {0}, Pages {1}", book.Name, book.Pages);
            }
            Console.ReadKey(true);
        }

        public void PrintSingleBook(Book book)
        {
            Console.WriteLine("Name: {0}, Pages: {1}", book.Name, book.Pages);
        }
    }
}
