using System;
using System.IO;

namespace directories
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Directory.Exists(@"c:/tests/"))
            {
                Console.WriteLine("El directorio existe");
            }
            else
            {
                Directory.CreateDirectory(@"c:/tests/");
            }
            try
            {
            string[] directories = Directory.GetDirectories("c:/");
            foreach (string dir in directories)
            {
                Console.WriteLine("DIRECTORIO: " + dir + "\n __________");
                try
                {
                    string[] files = Directory.GetFiles(dir);

                    foreach (string file in files)
                    {
                        try
                        {
                            Console.WriteLine(">>> ARCHIVO: " + file);
                        }
                        catch (UnauthorizedAccessException)
                        {
                            Console.Write("Excepción por acceso denegado");
                        }
                        catch (IOException)
                        {
                            Console.Write("Excepción por error en entrada y salida de datos");
                        }
                        catch (NullReferenceException)
                        {
                            Console.Write("Excepción por referencia a variable nula");
                        }
                    }
                }
                catch (UnauthorizedAccessException)
                {
                        Console.Write("Excepción por referencia a variable nula");
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.Write("Excepción por referencia a variable nula");
            }
        }

    }
}
