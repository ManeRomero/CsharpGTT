using System;

namespace _20ticketgenerator
{
    public class Ticket {
        private string date, superMarket;
        private ticketEntry ticketRegister;

        public void generator () {
            Console.WriteLine("TICKET GENERATOR:\nIntroduce Fecha DD-MM-YYYY");
            this.setDate(Console.ReadLine());

            Console.WriteLine("¿En qué Supermercado?");
            this.setSuperMarket(Console.ReadLine());

            this.ticketRegister = new ticketEntry();
        }

        private void setDate(string date) {
            if (date.Length != 10 || date[2] != '-' || date[5] != '-') {
                Console.WriteLine("FECHA DEBE CONSISTIR EN DD-MM-YYYY");
                this.setDate(Console.ReadLine());
            } else {
                this.date = date;
            }
        }
        
        private string getDate() {
            return this.date;
        }

        private void setSuperMarket(string brand) {
            if (brand.Length < 3 || brand.Length > 20) {
                Console.WriteLine("INTRODUZCA SUPER MERCADO (longitud 3 a 20)");
                this.setSuperMarket(Console.ReadLine());
            } else {
                this.superMarket = brand;
            }
        }

        private string getSuperMarket() {
            return this.superMarket;
        }
    }
}