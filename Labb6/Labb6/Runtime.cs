using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb6.Interfaces;

namespace Labb6
{
    class Runtime
    {

        public void Start()
        {
            bool loop = true;

            while (loop)
            { 
            Menus.Introduction();
            var input = Console.ReadKey(true).Key;



                switch (input)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:

                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        Menus.HowTo();
                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Please choose a valid number");
                        Console.ReadLine();
                        break;
                }     
            }
        }

        private void CreateEnvironment()
        {
            IEnvironment newEnvironment = new Yard("You are standing in a yard and you see a cat sitting in the corner of the yard");
        }
        

    }
}
