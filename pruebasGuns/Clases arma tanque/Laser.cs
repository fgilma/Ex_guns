using System;
using System.Collections.Generic;
using System.Text;

namespace pruebasGuns.Clases_arma_tanque
{
    class Laser: IArma // Interface armas

    {
        public string Nombre { get; set; }
        public Laser()
        {
            Nombre = "laser";
        }
        public string Disparar()
        {
            return "Zzzzzzziuuuuu Zzzzzziuuuuu !! ..";
        }
        
    }
}
