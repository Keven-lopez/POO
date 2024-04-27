using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Abstraccion
{
    public class Circulo : Forma
    {
        private double radius;

        public Circulo(double radius)
        {
            this.radius = radius;
        }

        public override double calcularArea()
        {
            return Math.PI * radius * radius;
        }

        public override void dibujar()
        {
            Console.WriteLine("Dibujando circulo");
        }
    }
}
