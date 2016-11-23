using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb13.Models
{
    class Menus
    {
        public static void PrintMainMenu()
        {
            Console.WriteLine("1. Add a Book");
            Console.WriteLine("2. Show books");
            Console.WriteLine("3. Show a special book");
        }

        public static void PrintSpecialBooks()
        {
            Console.WriteLine("Do you want to take a look at long or short books?");
            Console.WriteLine("1. Long books");
            Console.WriteLine("2. Short books");
        }

    }
}
