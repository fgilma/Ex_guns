using System;
using System.Collections.Generic;
using System.Text;

namespace pruebasGuns
{
    class Escopeta:IArma // Interface armas
    {
        public string Nombre { get; set; }
        public Escopeta()
        {
            Nombre = "escopeta";
        }
        public string Disparar()
        {
            return "pum PUMMM !! ..";
        }
        
    }
}
