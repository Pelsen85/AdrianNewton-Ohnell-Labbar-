using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Del1
{
    class Dog
    {

        public string Name { get; set; }
        public int Age { get; set; }

        public string Breed { get; set; }


        public string WriteDogs()
        {
            return String.Format("Here are your dogs{0} {1} {2}", Name, Age, Breed);
        }
    }   
}
