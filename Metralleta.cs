using System;
using System.Collections.Generic;
using System.Text;

namespace Dia7Eyeccion
{
    class Metralleta
    {
        public virtual void Disparar(string nombre)
        {
            Console.WriteLine($"Es hora de disparar la Metralleta soy el soldado {nombre}");
        }
    }
}
