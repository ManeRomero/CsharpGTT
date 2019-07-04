using System;

namespace registerComputer
{
    public class RamMemory
    {
        private int kylobytes;
        
        public RamMemory()
        {
            Console.WriteLine("Cuántos KBs de RAM? ");
            setKylobytes(Convert.ToInt32(Console.ReadLine()));
        }

        private void setKylobytes(int kylobytes)
        {
            if (kylobytes < 0) {
                Console.Write("No es posible datos negativos: ");
                this.setKylobytes(Convert.ToInt32(Console.ReadLine()));
            } else {
                this.kylobytes = kylobytes;
                toMB(this.kylobytes);
            }
        }

        private void toMB(int kylobytes)
        {
            int megabytes = kylobytes / 1024;
            Console.WriteLine("MBs RAM: " + megabytes);
        }
    }
}