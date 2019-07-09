using System;
using System.Collections.Generic;

namespace Listas
{
    class Pez : IEquatable<Pez>
    {
        public string color { get; set; }
        public string nombre { get; set; }
        public bool Equals(Pez other)
        {
            return this.color == other.color && this.nombre == other.nombre;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pez fishReflection;

            List<string> fishes = new List<string> {"Congrio", "Sargo"};
            Pez pezPayaso = new Pez() { nombre = "Pez Krusty", color = "Micolor" };
            Pez pezCebra = new Pez() { nombre = "Pez Cebra", color = "Añil" };
            List<Pez> listaPeces = new List<Pez>();
            listaPeces.Add(pezPayaso);
            listaPeces.Add(pezCebra);

            Console.WriteLine("LISTAS:");
            foreach(Pez p in listaPeces)
            {
                Console.WriteLine(p.nombre);
                Console.WriteLine(p.color);
            }

            Dictionary<string, Pez> fishDictionary = new Dictionary<string, Pez>();

            fishDictionary.Add("tronchi", new Pez() { nombre = "pezPayaso", color = "muchos colores" });
            fishDictionary.Add("winki", new Pez() { nombre = "pezPayaso", color = "mogo´llón de colores" });

            Console.WriteLine("DICTIONARIES");

            foreach (var fish in fishDictionary)
            {
                Console.WriteLine(fish.Key);
                Console.WriteLine(fish.Value.nombre);
                Console.WriteLine(fish.Value.color);
            }

            bool found = fishDictionary.TryGetValue("wiki", out fishReflection);

            if (found)
            {
                Console.WriteLine("ENCONTRADO, CORRECTO: " + found);
            } else
            {
                Console.WriteLine("NO ENCONTRADO, INCORRECTO: " + found);
            }
        }
    }
}
