using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb5.Models;

namespace Labb5
{
    class UI
    {
        public static void PrintMainMenu()
        {
            Console.WriteLine("Welcome to your book, movie and song selection");
            Console.WriteLine("1. Add an item to your selection");
            Console.WriteLine("2. Remove an item from your selection");
            Console.WriteLine("3. Exit");
        }

        public static Book CreateBook()
        {
            Book newBook = new Book();
            Console.Clear();
            Console.Write("Book name: ");
            newBook.Name = Console.ReadLine();

            Console.Write("Book types: ");
            PrintBookTypes();
            Console.Write("Choose a type: ");
            int choice = int.Parse(Console.ReadLine());
            newBook.Type = (Book.BookType)choice;

            return newBook;
        }

        public static void EditBook(Book book)
        {
            Console.Clear();
            Console.WriteLine("1. Change name");
            Console.WriteLine("2. Change type");
            Console.Write("Choice: ");
            var choice = Console.ReadKey(true).Key;

            Console.Clear();
            Console.WriteLine("Book: {0}. Type: {1}", book.Name, book.Type);

            switch (choice)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Console.Write("New name: ");
                    book.Name = Console.ReadLine();
                    break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    PrintBookTypes();
                    Console.Write("New type: ");
                    book.Type = (Book.BookType)int.Parse(Console.ReadLine());
                    break;
            }
        }

        public static int SelectBook(Book[] books)
        {
            PrintBookList(books);
            Console.Write("Select book: ");
            return int.Parse(Console.ReadLine());
        }

        public static void PrintBookTypes()
        {
            foreach(var type in Enum.GetValues(typeof(Book.BookType)))
            {
                Console.WriteLine("{0}, {1}", (int)type, type);
            }
        }

        public static void PrintBookList(Book[] books)
        {
            Console.Clear();
            foreach (var book in books)
            {
                Console.WriteLine("{0}. Game: {1}, Type: {2}",
                Array.IndexOf(books, book) + 1,
                book.Name,
                book.Type);
            }
        }
    }
}
