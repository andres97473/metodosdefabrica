using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metodos_de_Frabrica
{
    class FabricaAutosAlemania : FabricaAutos
    {
        public override Auto factoryMethod(int tipo)
        {
            Auto miAuto;
            if (tipo == 1) miAuto = new SedanAlemania();
            if (tipo == 2) miAuto = new TodoTerrenoAlemania();
            if (tipo == 3) miAuto = new ConvertibleAlemania();
            if (tipo == 4) miAuto = new FurgonetaAlemania();
            else miAuto = null;
            return miAuto;
        }
    }
}
