﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Polimorfismo
{
    public class Rectangulo : Forma
    {
        public override void Dibujar()
        {
            Console.WriteLine("Dibujando un rectangulo.");
        }
    }
}
