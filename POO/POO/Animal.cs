using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.POO
{
    public class Animal
    {
        public string Raza { get; set; }
        public int numero_patas { get; set; }
        public string mostrarInformacion()
        {
            return $"Raza: {Raza}\nNumero de Patas: {numero_patas}";
        }
    }
}
