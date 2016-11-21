using Labb5.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Labb5
{
    class Client
    {
        public void Start()
        {
            var books = new ListController();
            var loop = true;
            

            while (loop)
            {
                UI.PrintMainMenu();
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        books.CreateBook();
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        books.RemoveBook();
                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        books.Print
                        break;
                }
            }
        }
    }
}
