using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4
{
    class Menus
    {
        
        public static void PrintMainMenu()
        {
            Console.WriteLine("Welcome to Bosses Carshop!");
            Console.WriteLine("--------------------------");
            Console.WriteLine("1. Buy a vehicle ");
            Console.WriteLine("2. Sell a vehicle");
            Console.WriteLine("3. Show all vehicles ");
            Console.WriteLine("4. Exit");
        }

        public static void PrintMenuChoice()
        {
            Console.WriteLine("What kind of vehicles do you want to see Bosse?");
            Console.WriteLine("1. New Cars");
            Console.WriteLine("2. Used Cars");
            Console.WriteLine("3. New Motorcycles");
            Console.WriteLine("4. Used Motocycles");
        }

        public static void PrintAddVehicle()
        {
            Console.WriteLine("What kind of vehicle do you want to add Boose?");
            Console.WriteLine("1. New Car");
            Console.WriteLine("2. Used Car");
            Console.WriteLine("3. New Motorcycle");
            Console.WriteLine("4. Used Motocycle");
        }

        public static void PrintRemoveVehicle()
        {
            Console.WriteLine("What kind of vehicle do you want to remove Bosse?");
            Console.WriteLine("1. New Car");
            Console.WriteLine("2. Used Car");
            Console.WriteLine("3. New Motorcycle");
            Console.WriteLine("4. Used Motocycle");
        }
       
    }
}
