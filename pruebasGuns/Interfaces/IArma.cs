using System;
using System.Collections.Generic;
using System.Text;

namespace pruebasGuns
{
    interface IArma
    {
        public string Nombre { get; set; }
        string Disparar();
    }
}
