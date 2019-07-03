using System;
using System.Reflection;

namespace VehiclesClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle patinete = new Vehicle();
            // Vehicle motoneta = new Vehicle(180, true);
            patinete.arrancar();
            patinete.arrancar();
            
            Console.WriteLine("INTRODUZCA COLOR (formato hexadecimal)");
            patinete.setColor(Console.ReadLine());

            Console.WriteLine("INTRODUZCA NUM RUEDAS");
            patinete.setNumRuedas(Convert.ToByte(Console.ReadLine()));

            Console.WriteLine("INTRODUZCA NUM PASAJEROS");
            patinete.setNumPasajeros(Convert.ToByte(Console.ReadLine()));

            Console.WriteLine("INTRODUZCA NUM PUERTAS");
            patinete.setNumPuertas(Convert.ToByte(Console.ReadLine()));

            Console.WriteLine("INTRODUZCA NÚMERO DE BASTIDOR");
            Console.WriteLine(patinete.compareBastidorNumber(Console.ReadLine()) ? "VERDADERO: EL NÚMERO COINCIDE" : "FALSO: EL NÚMERO NO COINCIDE");

            Console.WriteLine("Tiene marchas automáticas?");
            Console.Write("y/n: ");
            patinete.setEsAutomatico(Convert.ToChar(Console.ReadKey()));

            patinete.allGetters();        
            /*
            LA SIGUIENTE ESTRUCTURA NOS DA LA LISTA DE PROPS PÚBLICAS

                PropertyInfo[] results = patinete.GetType().GetProperties();
                System.Console.WriteLine(results.Length + "co nos osdodf");
                foreach (PropertyInfo item in results) {
                    Console.WriteLine("Props: " + item.Name);
                    Console.WriteLine(item.GetValue(patinete, null));
                }
            */
        }
    }
}
