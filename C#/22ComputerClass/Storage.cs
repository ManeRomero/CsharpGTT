using System;

namespace registerComputer
{
    public class Storage
    {
        enum storeList { hdd = 1, ssd };
        private string storeType;

        public Storage()
        {
            setStorage();
        }

        private void setStorage()
        {
            Console.Write("Tipo de memoria? 1 - HDD · 2 - SDD: ");
            int selection = Convert.ToInt16(Console.ReadLine());

            if(selection != 1 || selection != 2) {
                Console.Write("Valor mal introducido.");
                this.setStorage();
            }
        }
    }
}