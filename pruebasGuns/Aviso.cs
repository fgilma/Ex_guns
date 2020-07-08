using System;
using System.Collections.Generic;
using System.Text;
using pruebasGuns.Interfaces;

namespace pruebasGuns
{
    class Aviso:IAviso
    {
        public void Informar(string tipo,string nombre, IArma arma)
        {
            Console.WriteLine("\nAVISO!!!! El " + tipo + " \"" + nombre + "\" ha cambiado a " + arma.Nombre + "\n");
        }
    }
}
