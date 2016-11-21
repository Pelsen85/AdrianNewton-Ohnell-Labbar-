using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb6.Interfaces;

namespace Labb6
{
    class Yard : IEnvironment
    {
        public string Description { get; private set; }

        List<INonPlayerCharacter> nonPlayerCharacters;
        public List<INonPlayerCharacter> NonPlayerCharacters
        {
            get
            {
                if (nonPlayerCharacters == null) nonPlayerCharacters = new List<INonPlayerCharacter>();
                return nonPlayerCharacters;
            }
        }

        public Yard (string description)
        {
            Description = description;
        }

        public void Observe()
        {
            foreach (var nonPlayerCharacter in NonPlayerCharacters)
            {
                Console.Write("You see a ");
            }
        }
    }
}
