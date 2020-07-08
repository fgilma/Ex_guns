using System;
using System.Collections.Generic;
using System.Text;

namespace pruebasGuns
{
    class Revolver: IArma // Interface armas
    {
        public string Nombre { get; set; }
        public Revolver()
        {
            Nombre = "revolver";
        }
        public string Disparar()
        {
            return "Pum Pum ..";
        }        
    }
}
