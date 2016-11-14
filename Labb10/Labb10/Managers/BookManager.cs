using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb10
{
    class BookManager
    {
        public List<Book> Books { get; set; }

        public BookManager()
        {
            Books = new List<Book>
            {
                new Book {Name = "Heartbroken", Pages = 100, Genre = "Novel", Price = 150 },
                new Book {Name = "The Boat", Pages = 200, Genre = "Shortstory", Price = 186 },
                new Book {Name = "Princess", Pages = 300, Genre = "Novel", Price = 317 },
                new Book {Name = "Bitchass", Pages = 400, Genre = "Mystery", Price = 689 },
                new Book {Name = "Sword", Pages = 500, Genre = "Fantasy", Price = 432 },
                new Book {Name = "Lovers", Pages = 600, Genre = "Romance", Price = 910 },
                new Book {Name = "Tables", Pages = 700, Genre = "Shortstory", Price = 700 },
                new Book {Name = "The Murder", Pages = 800, Genre = "Mystery", Price = 330 }

            };
        }

        public void PrintWhere(BookFilter filter)
        {
            foreach (var book in Books)
            {
                if (filter(book))
                    Console.WriteLine(book.Name);
            }
        }
    }
}
