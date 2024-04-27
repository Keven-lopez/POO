using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Herencia
{
    internal class Animal
    {
        public string Nombre { get; set; }
        public int Edad {  get; set; }
        public void Comer()
        {
            Console.WriteLine($"{Nombre} esta comiendo.");
        }
        public void Dormir()
        {
            Console.WriteLine($"{Nombre} esta dormiendo.");
        }
    }
}
