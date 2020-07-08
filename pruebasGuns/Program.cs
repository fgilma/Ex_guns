using System;
using pruebasGuns.Clases_arma_tanque;


namespace pruebasGuns
{
    class Program
    {
        static void Main(string[] args)
        {
            //soldado con una arma
            Console.WriteLine("Soldado con una arma:");
            Soldado soldado1 = new Soldado(new Rifle());
            soldado1.Disparar();

            //soldado con dos armas
            Console.WriteLine("\nSoldado con dos armas:");
            Soldado soldado2 = new Soldado(new Rifle(),new Escopeta());
            soldado2.Disparar2();

            //tanque con una arma
            Console.WriteLine("\nTanque con una arma:");
            Tanque tanque1 = new Tanque(new Obus());
            tanque1.Disparar();

            //tanque con dos armas
            Console.WriteLine("\nTanque con dos armas:");
            Tanque tanque2 = new Tanque(new Obus(), new Laser());
            tanque2.Disparar2();

            //Tanque con Aviso
            Console.WriteLine("\nTanque con una arma y aviso:");
            Aviso aviso1 = new Aviso();
            Tanque tanque3 = new Tanque("El rompemuros", new Laser(),aviso1);
            tanque3.Disparar();
            tanque3.cambioArma(new Obus());
            tanque3.Disparar();
            tanque3.cambioArma(new Metralleta());
            tanque3.Disparar();

            //Soldado con aviso
            Console.WriteLine("\nSoldado con una arma y aviso:");
            Soldado soldado3 = new Soldado("Ryan", new Metralleta(), aviso1);
            soldado3.Disparar();
            soldado3.cambioArma(new Obus());
            soldado3.Disparar();
            soldado3.cambioArma(new Laser());
            soldado3.Disparar();
        }
    }
}
