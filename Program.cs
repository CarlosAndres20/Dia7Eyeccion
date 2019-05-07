using System;

namespace Dia7Eyeccion
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Diaz";
            
            Soldado soldado = new Soldado();
            soldado.DispararEscopeta(nombre);
            soldado.DispararMetralleta(nombre);
            soldado.DispararRifle(nombre);

            Console.ReadKey();
        }
    }
}
