using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        private string _color {get; set;}

        static void Main(string[] args)
        {


            List<string> peces = new List<string>{
                "nemo",
                "bob Esponga"
            };

            foreach (var pez in peces)
            {
                Console.WriteLine("CONCEPTO: " + pez);

            }
                Console.WriteLine("COUNT : " + peces.Capacity);
                Console.WriteLine("CAPACITY: " + peces.Count);
        }
    }
}
