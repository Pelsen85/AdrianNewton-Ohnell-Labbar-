using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3
{
    class Runtime
    {

        public void Start()
        {         
            TicketManager manager = new TicketManager();

            bool loop = true;

            while(loop)
            {
                Console.Clear();
                Menus.PrintMainMenu();

                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Menus.PrintEvents();
                        manager.AddBooking();                                              
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        manager.ShowBookings();
                        Console.ReadLine();
                        break;                 

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:                        
                        Environment.Exit(0);
                        break;
                }
             }

         }

    }

}
