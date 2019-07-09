using System;
using System.Collections.Generic;
using System.IO;

namespace DictioConsole
{
    class Program
    {
        interface IWord
        {
            string entry
            {
                get;
                set;
            }
            string definition
            {
                get;
                set;
            }
        }
        class Word: IWord
        {
            private string _entry;
            private string _definition;

            public Word (string entry, string definition)
            {
                _entry = entry;
                _definition = definition;

                manageStorage(_entry, _definition);
                
            }

            public string entry
            {
                get
                {
                    return _entry;
                }

                set
                {
                    _entry = value;
                }
            }
            public string definition
            {
                get
                {
                    return _definition;
                }

                set
                {
                    _definition = value;
                }
            }

            private void manageStorage(string entry, string definition)
            {
                if (!Directory.Exists(@"c:\tests\"))
                {
                    Directory.CreateDirectory(@"c:\tests\");
                }

                File.AppendAllText("c:/tests/dictionary.txt", $"\n{entry}:\n{definition}\n_______\n");
                Console.WriteLine("PALABRA INTRODUCIDA EN ARCHIVO");
            }
        }
        static void Main(string[] args)
        {
            SortedDictionary<string, string> wordDictionary = new SortedDictionary<string, string>();
            string entry = "";
            bool checkSelection = false;
            
            while (!checkSelection)
            {
                Console.Write("Escoge OPCIÓN:\n1) INSertar\n2) BUScar\n3) LIStar Diccionario\n4) SALir:\n[número o MAYÚSCULAS] ");
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
                else if (selection.Contains("lis") || selection.Contains("3"))
                {
                    Console.WriteLine("LISTA COMPLETA DE PALABRAS: ");
                    listDictionary();
                }
                else if (selection.Contains("sal") || selection.Contains("4"))
                {
                    Console.WriteLine("GRACIAS POR UTILIZAR NUESTRO DICCIONARIO");
                    checkSelection = true;
                }
                else
                {
                    Console.WriteLine("SELECCIÓN ERRÓNEA. ELIGA DE NUEVO.");
                }
            }

            void insertWord(string word)
            {
                if (word.Length == 0 || hasNumbers(word))
                {
                    Console.WriteLine("PALABRA MAL INTRODUCIDA");
                    insertWord(Console.ReadLine());
                }
                else
                {
                    entry = word;
                    Console.Write("1) INTRODUZCA DEFINICIÓN: ");
                    insertDefinition(Console.ReadLine());
                }
            }

            void insertDefinition(string def)
            {
                if (def.Length == 0 || hasNumbers(def))
                {
                    Console.WriteLine("PALABRA MAL INTRODUCIDA");
                    insertDefinition(Console.ReadLine());
                }
                else
                {
                    Word vocablo = new Word(entry, def);
                    wordDictionary.Add(vocablo.entry, vocablo.definition);
                }
            }

            bool hasNumbers(string word)
            {
                string forbidden = "0123456789";
                bool result = false;
                int i = 0;

                while (i < forbidden.Length && result == false)
                {
                    if (word.Contains(forbidden[i]))
                    {
                        result = true;
                    }
                    i++;
                }
                return result;
            }

            void listDictionary()
            {
                foreach (var subject in wordDictionary)
                {
                    Console.WriteLine(subject);
                }
            }

        }
    }
}