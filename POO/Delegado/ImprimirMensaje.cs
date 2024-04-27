using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Delegado
{
    public delegate void mostrarMensajeDelagado(string mensaje);
    public class ImprimirMensaje
    {
        public void imprimirMensaje(string mensaje)
        {
            Console.WriteLine($"Mensaje: {mensaje}");
        }

        public void imprimirMayus(string mensaje)
        {
            Console.WriteLine($"Mensaje en Mayuscula: {mensaje.ToUpper()}");
        }
    }
}
