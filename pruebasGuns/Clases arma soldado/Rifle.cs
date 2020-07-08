using System;
using System.Collections.Generic;
using System.Text;

namespace pruebasGuns
{
    class Rifle: IArma // Interface armas
    {
        public string Nombre { get; set; }
        public Rifle()
        {
            Nombre = "rifle";
        }
        public string Disparar()
        {
            return "Pum pum pum pum pum ..";
        }        
    }
}
