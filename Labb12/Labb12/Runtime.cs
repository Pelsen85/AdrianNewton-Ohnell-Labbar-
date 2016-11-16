using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb12
{
    class Runtime
    {
        public void Start()
        {
            List<Movie> movies = new List<Movie>()
            {
                new Movie { Name = "Heat", Genre = "Action", Playtime = 115 },
                new Movie { Name = "Superman", Genre = "Sci-fi", Playtime = 135 },
                new Movie { Name = "Aladin", Genre = "Cartoon", Playtime = 149 },
                new Movie { Name = "Warcraft", Genre = "Fantasy", Playtime = 130 },
                new Movie { Name = "Tarzan", Genre = "Action", Playtime = 150 }
            };

            Movie singleMovie = movies.SingleOrDefault(movie => String.Equals(movie.ToString(), "Superman"));
            Console.WriteLine("i");
            string output;
            if (singleMovie != null)
                output = singleMovie.ToString();
            else
                output = "No Matches";

            Console.WriteLine(output);

            Movie[] subset = movies
                .Where(movie => movie.Genre.Contains("Action"))
                .ToArray();

            Console.WriteLine("ii ");
            foreach (var movie in subset)
            {
                
                Console.WriteLine("Where: {0}", movie.ToString());
            }

            Movie[] playtime = movies
                .Where(movie => movie.Playtime > 120)
                .ToArray();

            Console.WriteLine("iii");
            foreach (var movie in playtime)
            {
                Console.WriteLine("{0}", movie.ToString());
            }

            MovieMeta[] movieMeta = movies
                .Select(movie => new MovieMeta { MovieName = movie.ToString() })
                .ToArray();

            Console.WriteLine("iv");
            foreach (var movie in movieMeta)
            {
                Console.WriteLine("{0}", movie.ToString());
            }

            MovieMeta[] name = movies
                .Select(movie => new MovieMeta { MovieName = movie.ToString() })
                .ToArray();

            string[] allnames = movies
                .Where(movie => String.Equals(movie.Name, "Warcraft"))
                .Select(movie => movie.Name)
                .ToArray();

            Console.WriteLine("v");
            foreach (var movie in allnames)
            {
                Console.WriteLine("{0}", movie.ToString());
            }

            Movie[] datMovie = movies
                .Where(movie => movie.Name.StartsWith("W") && movie.Playtime > 120 && movie.Genre.Contains("Fantasy"))
                .ToArray();

            Console.WriteLine("vi");
            foreach (var movie in datMovie)
            {
                Console.WriteLine("{0}", movie.ToString());
            }

        }
    }
}
