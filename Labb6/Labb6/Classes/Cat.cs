using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6
{
    class Cat : Animal
    {
        public Cat(string name = "Hans") : base (name)
        {

        }

        public override bool Talk()
        {
            Console.WriteLine("bla bla");

            return false;
        }
    }
}
