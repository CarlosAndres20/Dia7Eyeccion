using System;
using System.Collections.Generic;
using System.Text;

namespace Dia7Eyeccion
{
    class Soldado
    {
        public string Antiguedad { get; set; }
        public string Nombre { get; set; }
        public string NombreBatallon { get; set; }

        Escopeta esc=new Escopeta();
        Metralleta met=new Metralleta();
        Rifle rif=new Rifle();
        public void DispararEscopeta(string nombre)
        {
            esc.Disparar(nombre);
        }
        public void DispararMetralleta(string nombre)
        {
            met.Disparar(nombre);
        }
        public void DispararRifle(string nombre)
        {
            rif.Disparar(nombre);
        }
    }
}
