using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4.Models.Vehicles
{
    abstract class Vehicle
    {
       
        public int Price { get; set; }


        public string Brand { get; set; }


        public string Model { get; set; }

    }
}