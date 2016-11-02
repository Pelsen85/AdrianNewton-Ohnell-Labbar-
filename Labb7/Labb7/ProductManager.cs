using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7
{
    class ProductManager
    {
        public List<Electronics> Electronics { get; set; }
        public List<Food> Foods { get; set; }
        public List<Toys> Toys { get; set; }

        public ProductManager()
        {
            Electronics = new List<Electronics>()
            {
                new Electronics { Price = 300, ProductInformation = "Speaker" },
                new Electronics { Price = 200, ProductInformation = "TV" },
            };

            Foods = new List<Food>()
            {
              new Food { Price = 10, ProductInformation = "Banana" },
              new Food { Price = 40, ProductInformation = "Coffee" },
            };

            Toys = new List<Toys>()
            {
                new Toys {Price = 9000, ProductInformation = "Racecar" },
                new Toys {Price = 750, ProductInformation = "Lego" },
            };
        }

        public void ShowElectronics()
        {
            foreach (var electronic in Electronics)
            {
                Console.WriteLine("Price: " + electronic.Price + ", " + "Productinformation: " + electronic.ProductInformation + ", ");
                
            }
            Console.WriteLine();
            Console.WriteLine("Press Enter to return to the main menu...");
        }

        public void ShowFood()
        {
            foreach (var food in Foods)
            {
                Console.WriteLine("Price: " + food.Price + ", " + "Productinformation: " + food.ProductInformation + ", ");

            }
            Console.WriteLine();
            Console.WriteLine("Press Enter to return to the main menu...");
        }

        public void ShowToys()
        {
            foreach (var toy in Toys)
            {
                Console.WriteLine("Price: " + toy.Price + ", " + "Productinformation: " + toy.ProductInformation + ", ");

            }
            Console.WriteLine();
            Console.WriteLine("Press Enter to return to the main menu...");
        }
    }
}
