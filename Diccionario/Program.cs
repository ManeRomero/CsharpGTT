using System;
using System.Collections.Generic;
using System.IO;

namespace diccionario
{
    class Program
    {
        static void Main(string[] args)
        {
            bool checkSelection = false;
            SortedDictionary<string, string> wordDictionary = new SortedDictionary<string, string>();

            while (!checkSelection)
            {
                Console.Write("Escoge OPCIÓN:\n1) INSertar\n2) BUScar\n3) SALir:\n[número o MAYÚSCULAS] ");
                string selection = Console.ReadLine().ToLower();

                if (selection.Contains("ins") || selection.Contains("1"))
                {
                    Console.Write("1) INTRODUCE PALABRA: ");                    
                    insertWord(Console.ReadLine());
                }
                else if (selection.Contains("bus") || selection.Contains("2"))
                {
                    Console.WriteLine("HAS ELEGIDO BUS O 2");
                }
                else if (selection.Contains("sal") || selection.Contains("3"))
                {
                    Console.WriteLine("GRACIAS POR UTILIZAR NUESTRO DICCIONARIO");
                    checkSelection = true;
                }
                else
                {
                    Console.WriteLine("SELECCIÓN ERRÓNEA. ELIGA DE NUEVO.");
                }                
            }
            
            void insertWord(string word) {
                if (word.Length == 0 || hasNumbers(word)) {
                    Console.WriteLine("PALABRA MAL INTRODUCIDA");
                } else {
                    Console.WriteLine("PALABRA INTRODUCIDA CORRECTAMENTE");
                    
                }
            }

            bool hasNumbers(string word) {
                string forbidden = "0123456789";
                bool result = false;
                int i = 0;

                while (i < forbidden.Length && result == false)
                {
                    if (word.Contains(forbidden[i])) {
                        result = true;
                    }                    
                    i++;
                }
                return result;
            }
        }
    }
}