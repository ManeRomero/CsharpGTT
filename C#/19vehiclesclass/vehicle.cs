using System;

namespace VehiclesClass
{
    public class Vehicle
    {
        public static short volante = 1;
        public string color { get; set; }
        private byte numRuedas;
        private ushort numPasajeros;
        private byte numPuertas;
        private int maxVelocity;
        private bool esAutomatico;
        public static string[] combustible = {"gasolina", "diésel", "eléctrico"};
        private bool arrancado = false;
        private string numeroBastidor;
        public Vehicle () {
            Console.WriteLine("Vehículo Creado!");
            // this(180, true);
            Console.WriteLine("AQUÍ NO LLEGA, HA PASADO DE ESTE CONSTRUCTOR");
            this.setColor("#123");
            Console.WriteLine("NÚM BASTIDOR: #" + numBastidor());
        }
        public Vehicle (int maxVelocity, bool esAutomatico) {
            Console.WriteLine("Vehículo creado a través de POLIMORFISMO.");
            this.maxVelocity = maxVelocity;
            this.esAutomatico = esAutomatico;
        }
        /* GETTERS / SETTERS */
        public string getColor() {
            System.Console.WriteLine("dasdsadsdadsdasasdsdasasd");
            return this.color;
        }
        public void setColor (string color) {
            if (color.StartsWith('#') && color.Length == 4 || color.Length == 7) {
                this.color = color;
            } else {
                Console.WriteLine("COLOR MAL INTRODUCIDO");
            }
        }
        public byte getNumRuedas() {
		    return this.numRuedas;
	    }
	    public void setNumRuedas(byte numRuedas) {
		    if (numRuedas > 0) {
                this.numRuedas = numRuedas;
            } else {
                Console.WriteLine("NUMRUEDAS MAL INTRODUCIDO");
            }
	    }
        public ushort getNumPasajeros() {
            return this.numPasajeros;
        }
        public void setNumPasajeros(ushort numPasajeros) {
            if (numPasajeros > 0) {
                this.numPasajeros = numPasajeros;
            } else {
                Console.WriteLine("NUMPASAJEROS MAL INTRODUCIDO");
            }
        }
        public byte getNumPuertas() {
            return this.numPuertas;
        }
        public void setNumPuertas(byte numPuertas) {
            if (numPuertas >= 0) {
                this.numPuertas = numPuertas;                
            } else {
                Console.WriteLine("NUMPUERTAS MAL INTRODUCIDO");
            }
        }
        public int getMaxVelocity() {
            return this.maxVelocity;
        }
        public void setMaxVelocity(int maxVelocity) {
            if (maxVelocity > 0) {
                this.maxVelocity = maxVelocity;
            }
        }
        public bool getEsAutomatico() {
            return this.esAutomatico;
        }
        public void setEsAutomatico(char esAutomatico) {
            if (esAutomatico == 'N') {
                this.esAutomatico = false;
            } else if (esAutomatico == 'Y') {
                this.esAutomatico = true;
            } else {
                Console.WriteLine("ESAUTOMATICO MAL INTRODUCIDO");
            }
        }
        public void arrancar() {
            if (!arrancado) {
                arrancado = true;
                Console.WriteLine("BRRRUUUMMMMMM");
            }
            else {
                Console.WriteLine("EL COCHE YA ESTABA ARRANCADO");
            }
        }

        private string numBastidor () {
            string possible = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random randomizer = new Random();
            short codeLenght = 10;
            string code = "";

            for (int i = 0; i < codeLenght; i++) {
                int randomPosition = randomizer.Next(0, possible.Length);
                code += possible[randomPosition];
            }

            this.numeroBastidor = code;
            return code;
        }
        public bool compareBastidorNumber (string code) {
            if (code == this.numeroBastidor) {
                return true;
            } else {
                return false;
            }
        }
        public void allGetters() {
            Console.WriteLine("Color: " + this.getColor());
            Console.WriteLine("Número Pasajeros: " + this.getNumPasajeros());
            Console.WriteLine("Número de Puertas: " + this.getNumPuertas());
            Console.WriteLine("Número de Ruedas: " + this.getNumRuedas());
            Console.WriteLine("Velocidad Máxima: " + this.getMaxVelocity());
            Console.WriteLine("Marchas automáticas?: " + this.getEsAutomatico());
        }

    }
}