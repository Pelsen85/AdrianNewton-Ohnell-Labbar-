using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Del1
{
    class Runtime
    {
        public void Start()
        {
            Dog dog1 = new Dog
            {
                Name = "Fido",
                Age = 4,
                Breed = "Labrador"
            };

            Dog dog2 = new Dog
            {
                Name = "Spot",
                Age = 2,
                Breed = "Rottweiler"
            };

            Dog dog3 = new Dog
            {
                Name = "King",
                Age = 5,
                Breed = "Grand Danois"
            };

            List<Dog> dogs = new List<Dog>()
            {
                dog1,
                dog2,
                dog3
            };
        }
    }
}
