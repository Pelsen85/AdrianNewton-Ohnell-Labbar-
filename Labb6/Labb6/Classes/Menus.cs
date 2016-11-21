using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6
{
    class Menus
    {

        public static void Introduction()
        {
            Console.WriteLine("Welcome to the adventure game");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("1. Start game");
            Console.WriteLine("2. How to");
            Console.WriteLine("3. Exit");
        }


        public static void HowTo()
        {
            Console.WriteLine("This huge world has two places: Yard and Room. You start the game in the yard, where there is a aniaml.");
            Console.WriteLine("In the Yard you have two options. Talk to the animal or go to the Room. Inside the Room there is an old");
            Console.WriteLine("who might have a riddle for you. If you complete the riddle, you have won the game");
        }

    }
}
