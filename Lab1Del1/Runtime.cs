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

           

            

            bool loop = false;
            do
            {
                loop = false;
                Console.WriteLine("Welcome to your dog collection");
                Console.WriteLine("------------------------------");
                Console.WriteLine("1: Add new");
                Console.WriteLine("2: Remove");
                Console.WriteLine("3: Show info");
                Console.WriteLine("4: Exit");
                int input = int.Parse(Console.ReadLine());


                switch (input)
                {
                    case 1:

                        Console.WriteLine("Name: ");
                        string name = Console.ReadLine();

                        Console.WriteLine("Age: ");
                        int age = int.Parse(Console.ReadLine());

                        Console.WriteLine("Breed: ");
                        string breed = Console.ReadLine();

                        Dog newDog = new Dog
                        {
                            Name = name,
                            Age = age,
                            Breed = breed,
                        };
                        break;

                    case 2:

                    case 3:

                        foreach (var dog in dogs)
                        {
                            Console.WriteLine(dog.Name + " " + dog.Age + " " + dog.Breed);
                        }
                        break;

                    case 4:
                        Environment.Exit(0);
                        break;




                }
            } while (loop);
        }

    }
}
