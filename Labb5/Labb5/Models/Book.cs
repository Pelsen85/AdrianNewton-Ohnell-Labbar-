using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5.Models
{
    class Book
    {
        public enum BookType
        {
            Novel = 1,
            Scifi,
            Crime,
            Romance,
            Programming,
        }

        public string Name { get; set; }
        public BookType Type { get; set; }
    }
}
