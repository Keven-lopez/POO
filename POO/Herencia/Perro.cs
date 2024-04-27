using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Herencia
{
    internal class Perro : Animal
    {
        public void Ladrar()
        {
            Console.WriteLine($"{Nombre} esta ladrando");
        }
    }
}
