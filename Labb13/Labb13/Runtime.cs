using Labb13.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb13
{
    public delegate void PrintMessage(string message);
    class Runtime
    {
        private event PrintMessage InvalidInput;
        public Runtime()
        {
            InvalidInput += (message) =>
            {
                Console.WriteLine("Invalid input");
            };
        }

        public void Start()
        {
            BookManager manager = new BookManager();

            var loop = true;

            while (loop)
            {
                Console.Clear();
                Menus.PrintMainMenu();
                var choice = Console.ReadKey(true).Key;

                switch (choice)
                {
                    case ConsoleKey.D1:
                        manager.AddBook();
                        break;
                    case ConsoleKey.D2:
                        manager.PrintAllBooks();
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                           
                                            
                        break;

                    default:
                        InvalidInput.Invoke("Invalid input");
                        Console.ReadKey(true);
                        break;
                }
            }
        }

        private BookFilter GetFilter()
        {
            Menus.PrintSpecialBooks();
            var choice = Console.ReadKey(true).Key;
            BookFilter filter1 = new BookFilter(BookFilters.IsLong);
            BookFilter filter2 = new BookFilter(BookFilters.IsShort);

            switch (choice)
            {
                case ConsoleKey.D1:
                   
                    break;

                case ConsoleKey.D2:
                    
                    break;
            }
            return filter1;
            return filter2;
        }
    }
}
