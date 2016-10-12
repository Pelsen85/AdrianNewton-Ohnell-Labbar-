using System;
using System.Collections;
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
                dog3,
                

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

                        dogs.Add(newDog);


                        break;

                    case 2:

                        Console.WriteLine("What dog do you want to remove? 1, 2or 3?");
                        int index = int.Parse(Console.ReadLine());
                        index = index - 1;
                        dogs.RemoveAt(index);
                        break;
                    case 3:

                        Console.WriteLine("Showing all your dogs!");

                        foreach (var dog in dogs)
                        {
                            Console.WriteLine(dog.Name + " " + dog.Age + " " + dog.Breed);
                        }

                        Console.ReadKey();

                        break;

                    case 4:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Please choose from 1-4");
                        break;




                }
            } while (true);
        }

    }
}
