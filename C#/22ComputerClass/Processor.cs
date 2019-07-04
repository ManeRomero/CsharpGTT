using System;

namespace registerComputer
{
    public class Processor
    {
        private int socket;
        private string name;
        private int megaherzs;

        public Processor()
        {
            setProcessor();
        }

        private void setProcessor() 
        {
            Console.Write("Procesador > NÚM SOCKET (3 CIFRAS) ");
            setSocket(Convert.ToInt16(Console.ReadLine()));
        }

        private void setSocket (int socket) {
            if (socket < 0 || socket >= 1000) {
                Console.Write("Introduce un número de 3 cifras: ");
                this.setSocket(Convert.ToInt16(Console.ReadLine()));
            }
        }
    }
}