using System;
using System.Collections.Generic;
using System.Text;

namespace Dia7Eyeccion
{
    class Escopeta
    {
        public virtual void Disparar(string nombre)
        {
            Console.WriteLine($"Es hora de disparar la escopeta soy el soldado {nombre}");
        }
    }
}
