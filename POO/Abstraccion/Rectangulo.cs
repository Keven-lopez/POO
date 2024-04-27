using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Abstraccion
{
    internal class Rectangulo : Forma
    {
        private double length;
        private double width;

        public Rectangulo(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public override double calcularArea()
        {
            return length * width;
        }

        public override void dibujar()
        {
            Console.WriteLine("Dibujando rectangulo");
        }
    }
}
