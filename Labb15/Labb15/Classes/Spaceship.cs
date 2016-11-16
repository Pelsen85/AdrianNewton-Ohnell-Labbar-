using Labb15.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb15.Classes
{
    class Spaceship : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Hyperthrusters starting");
        }
        public void Stop()
        {
            Console.WriteLine("Hyperthrusters stopping");
        }

        public void Lock()
        {
            Console.WriteLine("Locking spacelock");
        }

        public void Unlock()
        {
            Console.WriteLine("Unlocking spacelock");
        }
    }
}
