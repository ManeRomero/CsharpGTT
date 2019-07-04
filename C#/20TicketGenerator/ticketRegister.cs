using System;

namespace _20ticketgenerator
{
    public class ticketEntry {
        private string productName;
        private double priceByUnit;
        private int productTaxes;
        private int amount;

        private bool entryCheck = true;
        private int counter = 0;

        public ticketEntry () {
            Console.WriteLine("VAMOS A CREAR REGISTROS EN TICKET");
            entry();
        }

        private void entry () {
            while (entryCheck && counter < 10)
            {
                this.counter++;
                Console.Write("ARTÍCULO #" + counter + "\n#########\n");
                Console.Write("Nombre de producto: ");
                this.setProductName(Console.ReadLine());          

                Console.Write("Precio Mayorista: ");
                this.setPriceByUnit(Convert.ToDouble(Console.ReadLine()));

                Console.Write("I.V.A.: ");
                this.setProductTaxes(Convert.ToInt16(Console.ReadLine()));

                Console.Write("Número de Unidades: ");
                this.setAmount(Convert.ToInt16(Console.ReadLine()));

                Console.Write("Desea añadir otro artículo? Y/N: ");
                this.setEntryCheck(Console.ReadLine().ToUpper());
            }
        }

        private void setProductName(string name) {
            if (name.Length < 3 || name.Length > 20) {
                Console.Write("Longitud inadecuada (3 a 20)");
                this.setProductName(Console.ReadLine());
            } else {
                this.productName = name;
            }
        }

        private void setPriceByUnit(double price) {            
            if (price < 0 || price > 100) {
                Console.Write("Precio no válido (0 - 100€): ");
                this.setPriceByUnit(Convert.ToDouble(Console.ReadLine()));
            } else {
                this.priceByUnit = price;
            }
        }

        private void setProductTaxes (int taxes) {
            if (taxes < 0 || taxes > 25) {
                Console.Write("I.V.A. no válido (0 - 25%: ");
                this.setProductTaxes(Convert.ToInt16(Console.ReadLine()));
            } else {
                this.productTaxes = taxes;
            }
        }

        private void setAmount (int amount) {
            if (amount < 1 || amount > 50){
                Console.Write("Cantidad errónea (1 - 50 ud.)");
            } else {
                this.amount = amount;
            }
        }

        private void setEntryCheck (string response) {
            if (response.Length != 1) {
                Console.Write("Respuesta errónea. Formato Y-N");
                this.setEntryCheck(Console.ReadLine());
            } else {
                if (response[0] == 'Y')  {
                    Console.WriteLine(">>>>>>>");
                } else if (response[0] == 'N') {
                    Console.WriteLine(this.counter + " productos introducidos");
                    Console.WriteLine("Gracias por introducir su compra");
                    this.entryCheck = false;
                } else {
                    Console.Write("Respuesta errónea. Formato Y-N");
                    this.setEntryCheck(Console.ReadLine());             
                }
            }
        }
    }
}              