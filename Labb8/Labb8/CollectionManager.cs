using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb8
{
    class CollectionManager
    {
        public string[] MyArray { get; set; }
        public float[] MyCollection { get; set; }

        public CollectionManager()
        {
            MyArray = new string[]
            {
                "Sort",
                "Blå",
                "Rød",
                "Gul",
                "Grøn"
            };

            MyCollection = new float[]
            {
                12.18f,18.54f,19.91f,19.90f,18.25f

            };
        }
        public void Calculator(Func<float, float, float> calcFunc)
        {
            float total = 1;
            foreach (var number in MyCollection)
            {
                total = calcFunc(total, number);
            }
            Console.WriteLine(total);
        }
    }
}
