using System;
using System.Collections.Generic;
using System.Text;

namespace pruebasGuns.Interfaces
{
    interface IAviso
    {
        void Informar(string tipo, string nombre, IArma arma);
        
    }
}
