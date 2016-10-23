using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3
{
    class TicketManager
    {

        public List<Concert> Concerts { get; set; }
        public List<Festival> Festivals { get; set; }
        public List<Movie> Movies { get; set; }

        public List<Booking> Bookings { get; set; }

        public TicketManager()
        {
            Concerts = new List<Concert>()
            {
                new Concert { Type = "Concert", Name = "Elvis", },
                new Concert { Type = "Concert", Name = "Beatles", },
            };

            Festivals = new List<Festival>()
            {
                new Festival { Type = "Festival", Name = "Roskilde", },
                new Festival { Type = "Festival", Name = "Woodstock",  },
            };

            Movies = new List<Movie>()
            {
                new Movie { Type = "Movie", Name = "Heat",},
                new Movie { Type = "Movie", Name = "Superman", },
            };

            Bookings = new List<Booking>()
            {          
            
            };
       

        }
        public void AddBooking()
        {
            Console.Clear();
            Menus.PrintEvents();
            var choice = Console.ReadKey(true).Key;

            switch (choice)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    AddMovie();
                    Menus.PrintMovies();
                    break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    AddConcert();
                    Menus.PrintConcerts();
                    break;

                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    AddFestival();
                    Menus.PrintFestivals();
                    break;
            }        
        }

        public void AddMovie()
        {
            Menus.PrintMovies();

            var movieChoice = Console.ReadKey(true).Key;

            switch (movieChoice)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:

                    Booking movieBooking = new Booking();
                
                    movieBooking.Name = "Heat";

                    movieBooking.Type = "Movie";

                    Console.WriteLine("Please Enter your first name: ");
                    movieBooking.FirstName = Console.ReadLine();

                    Console.WriteLine("Please Enter your last name: ");
                    movieBooking.LastName = Console.ReadLine();

                    Bookings.Add(movieBooking);

                    break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:

                    Booking movieBooking1 = new Booking();

                    movieBooking1.Name = "Superman";
                    movieBooking1.Type = "Movie";

                    Console.WriteLine("Please Enter your first name: ");
                    movieBooking1.FirstName = Console.ReadLine();

                    Console.WriteLine("Please Enter your last name: ");
                    movieBooking1.LastName = Console.ReadLine();

                    Bookings.Add(movieBooking1);
                    
                    break;
            }
            
        }

        public void AddConcert()
        {
            Menus.PrintConcerts();

            var concertChoice = Console.ReadKey(true).Key;

            switch (concertChoice)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:

                    Booking concertBooking = new Booking();

                    concertBooking.Name = "Elvis";

                    concertBooking.Type = "Concert";

                    Console.WriteLine("Please Enter your first name: ");
                    concertBooking.FirstName = Console.ReadLine();

                    Console.WriteLine("Please Enter your last name: ");
                    concertBooking.LastName = Console.ReadLine();

                    Bookings.Add(concertBooking);

                    break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:

                    Booking concertBooking1 = new Booking();

                    concertBooking1.Name = "Beatles";
                    concertBooking1.Type = "Concert";

                    Console.WriteLine("Please Enter your first name: ");
                    concertBooking1.FirstName = Console.ReadLine();

                    Console.WriteLine("Please Enter your last name: ");
                    concertBooking1.LastName = Console.ReadLine();

                    Bookings.Add(concertBooking1);

                    break;
            }
        }
        public void AddFestival()
        {
            Menus.PrintFestivals();

            var festivalChoice = Console.ReadKey(true).Key;

            switch (festivalChoice)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:

                    Booking festivalBooking = new Booking();

                    festivalBooking.Name = "Roskilde";

                    festivalBooking.Type = "Festival";

                    Console.WriteLine("Please Enter your first name: ");
                    festivalBooking.FirstName = Console.ReadLine();

                    Console.WriteLine("Please Enter your last name: ");
                    festivalBooking.LastName = Console.ReadLine();

                    Bookings.Add(festivalBooking);

                    break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:

                    Booking festivalBooking1 = new Booking();

                    festivalBooking1.Name = "Woodstock";
                    festivalBooking1.Type = "Festival";

                    Console.WriteLine("Please Enter your first name: ");
                    festivalBooking1.FirstName = Console.ReadLine();

                    Console.WriteLine("Please Enter your last name: ");
                    festivalBooking1.LastName = Console.ReadLine();

                    Bookings.Add(festivalBooking1);

                    break;
            }
        }
        public void ShowBookings()
        {
            foreach (var bookings in Bookings)
            {
                Console.WriteLine("Firstname: " + bookings.FirstName + ", " + "Lastname: " + bookings.LastName + ", " + "Name: " + bookings.Name + ", " + "Type: " + bookings.Type);
            }
        }
    }
}



