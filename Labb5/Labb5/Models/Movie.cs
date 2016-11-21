using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5.Models
{
    class Movie
    {
        public enum MovieType
        {
            Action = 1,
            Romance,
            Scifi,
            Blockbuster,
            Indie
        }

        public string Name { get; set; }
        public MovieType Type { get; set; }
    }
}
