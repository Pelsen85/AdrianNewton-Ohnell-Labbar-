using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5.Models
{
    class Song
    {
        public enum Songtype
        {
            Rap = 1,
            Rock,
            Pop,
            Opera,
            Techno
        }
        public string Name { get; set; }
        public Songtype Type { get; set; }
    }
}
