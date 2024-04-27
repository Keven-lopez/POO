using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Encapsulacion
{
    internal class Carro
    {
        private string marca;
        private string modelo;

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public void mostrarInformacion()
        {
            Console.WriteLine($"Modelo: {Modelo}\nMarca: {Marca}");
        }
    }
}
