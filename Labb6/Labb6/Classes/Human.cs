using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb6.Interfaces;

namespace Labb6.Classes
{
   abstract class Human : INonPlayerCharacter
    {
        public string Name { get; set; }

        public virtual string Observe()
        {
            return "You see a person";
        }
        public virtual bool Talk()
        {
            Console.WriteLine("{0}: Hi!", Name);
            return false;
        }
    }
}
