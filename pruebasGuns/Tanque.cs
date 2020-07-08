using System;
using System.Collections.Generic;
using System.Text;
using pruebasGuns.Interfaces;

namespace pruebasGuns
{
    class Tanque
    {
        protected IArma arma, arma2;
        protected IAviso aviso;
        private string tipo; // Tipo: soldado o tanque
        private string nombre; //Nombre del soldado o tanque

        // Primer Constructor: una arma
        public Tanque(IArma _arma)
        {
            this.tipo = "tanque";
            this.arma = _arma;
        }

        // Segundo Constructor: dos armas
        public Tanque(IArma _arma, IArma _arma2)
        {
            this.tipo = "tanque";
            this.arma = _arma;
            this.arma2 = _arma2;
        }

        // Tercer Constructor: tipo, nombre, arma y aviso
        public Tanque(string nombre,IArma arma, IAviso aviso)
        {
            this.tipo = "tanque";
            this.nombre = nombre;
            this.arma = arma;
            this.aviso = aviso;
        }

        // Método disparar un arma
        public void Disparar()
        {

            Console.WriteLine("Cuidado!!!, lleva un arma!!!!");
            Console.WriteLine(this.arma.Disparar());
        }

        // Método disparar dos armas
        public void Disparar2()
        {
            string[] dosArmas = { this.arma.Disparar(), this.arma2.Disparar() };
            Console.WriteLine("Cuidado!!!, lleva dos armas!!!!");
            foreach (var i in dosArmas)
            {
                Console.WriteLine(i);
            }
        }

        // Método cambiar de arma
        public void cambioArma(IArma armaletal)
        {
            aviso.Informar(this.tipo, this.nombre,armaletal);
        }
    }
}
