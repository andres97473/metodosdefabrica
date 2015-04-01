using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metodos_de_Frabrica
{
    class Program
    {
        public static void crearAuto(int tipo)
        {
            FabricaAutos miFabrica = new FabricaAutosAlemania();
            Auto miAuto = miFabrica.factoryMethod(tipo);
            System.Console.WriteLine("tipo: " + miAuto.darNombre());
        }

        static void Main(string[] args)
        {
            crearAuto(2);
        }
    }
}
