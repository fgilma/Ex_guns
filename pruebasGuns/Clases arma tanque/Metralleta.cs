using System;
using System.Collections.Generic;
using System.Text;

namespace pruebasGuns.Clases_arma_tanque
{
    class Metralleta: IArma // Interface armas
    {
        public string Nombre { get; set; }
        public Metralleta()
        {
            Nombre = "metralleta";
        }
        public string Disparar()
        {
            return "sssssssss  plafff!! ..";
        }        
    }
}
