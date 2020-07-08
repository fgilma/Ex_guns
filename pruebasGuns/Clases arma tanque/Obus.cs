using System;
using System.Collections.Generic;
using System.Text;

namespace pruebasGuns.Clases_arma_tanque
{
    class Obus: IArma // Interface armas
    {
        public string Nombre { get; set; }
        public Obus()
        {
            Nombre = "obus";
        }
        public string Disparar()
        {
            return "BOOOOOooooooMMMMmmmmm !! ..";
        }
       
    }
}
