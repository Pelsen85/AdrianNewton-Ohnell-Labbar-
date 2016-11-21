
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb6.Interfaces;


namespace Labb6
{
    class Animal : INonPlayerCharacter
    {
        public string Name { get; set; }

        public Animal( string name)
        {
            Name = name;
        }

        public virtual string Observe()
        {
            return "You see an animal";
        }

        public virtual bool Talk()
        {
            Console.WriteLine("The {0} looks at you but doesn't care", Name.ToLower());
            return false;
        }
    }
}
