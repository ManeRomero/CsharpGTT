using System;

namespace registerComputer
{
    public class Computer
    {
        private RamMemory ramUnit;
        private Processor processorUnit;
        private Storage memoryUnit;
        // private BrandModel modelUnit;

        public Computer()
        {
            Console.WriteLine("VAMOS A CREAR TU ORDENADOR");
            makeMyPC();
        }

        private void makeMyPC()
        {
            this.ramUnit = new RamMemory();
            this.processorUnit = new Processor();
        }
    }
}