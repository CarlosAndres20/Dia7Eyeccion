using System;
using System.Collections.Generic;
using System.Text;

namespace Dia7Eyeccion
{
    class Rifle
    {
        public virtual void Disparar(string nombre)
        {
            Console.WriteLine($"Es hora de disparar el Rifle soy el soldado {nombre}");
        }
    }
}
