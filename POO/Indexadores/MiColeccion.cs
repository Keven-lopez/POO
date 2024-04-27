using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace POO.Indexadores
{
    internal class MiColeccion
    {
        private string[] datos = new string[5];
        public string this[int indice]
        {
            get
            {
                if (indice >= 0 && indice < datos.Length)
                    return datos[indice];
                else
                    throw new IndexOutOfRangeException("El índice está fuera del rango.");
            }
            set
            {
                if (indice >= 0 && indice < datos.Length)
                    datos[indice] = value;
                else
                    throw new IndexOutOfRangeException("El índice está fuera del rango.");
            }
        }
    }
}
