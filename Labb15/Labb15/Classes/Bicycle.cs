using Labb15.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb15.Classes
{
    class Bicycle : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Step on the pedals");
        }
        public void Stop()
        {
            Console.WriteLine("Stop stepping on the pedals");
        }
        public void Lock()
        {
            Console.WriteLine("Locking bicycle");
        }

        public void Unlock()
        {
            Console.WriteLine("Unlocking bicycle");
        }
    }
}
