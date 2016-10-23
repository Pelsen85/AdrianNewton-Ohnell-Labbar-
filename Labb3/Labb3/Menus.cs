using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3
{
    class Menus
    {

        public static void PrintMainMenu()
        {
            Console.WriteLine("Welcome to the booking program!");
            Console.WriteLine("-------------------------------");           
            Console.WriteLine("1. Book a ticket ");
            Console.WriteLine("2. Show your tickets");
            Console.WriteLine("3. Quit");
        }

        public static void PrintEvents()
        {
            Console.WriteLine("What kind of event do you want to book tickets to?");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("1. Movies");
            Console.WriteLine("2. Concerts");
            Console.WriteLine("3. Festivals");
            Console.WriteLine("--------------------------------------------------");
        }


        public static void PrintMovies()
        {
            Console.WriteLine("Please choose a movie");
            Console.WriteLine("1. Heat");
            Console.WriteLine("2. Superman");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Type in the number of the event you want to book!");
        }

        public static void PrintConcerts()
        {
            Console.WriteLine("1. Elvis");
            Console.WriteLine("2. Beatles");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Type in the number of the event you want to book!");
        }

        public static void PrintFestivals()
        {
            Console.WriteLine("1. Roskilde");
            Console.WriteLine("2. Woodstock");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Type in the number of the event you want to book!");
        }


    }
}
