using System;

namespace registerComputer
{
    public class Computer
    {
        private RamMemory ramUnit;
        private Processor processorUnit;
        private Storage memoryUnit;
        private BrandModel modelUnit;

        Computer()
        {
            Console.WriteLine("Ordenador CreaDo");
        }
    }
}