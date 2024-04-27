using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Interfaz
{
    internal class Circulo : Forma
    {
        private double radio;

        public Circulo(double radio)
        {
            this.radio = radio;
        }

        public double calcularArea()
        {
            return Math.PI * radio * radio;
        }

        public void mostrar()
        {
            Console.WriteLine($"Circulo - Radio: {radio}, Area: {calcularArea()}");
        }
    }
}
