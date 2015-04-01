using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metodos_de_Frabrica
{
    class FabricaAutosColombia : FabricaAutos
    {
        public override Auto factoryMethod(int tipo)
        {
            Auto miAuto;
            if (tipo == 1) miAuto = new SedanColombia();
            if (tipo == 2) miAuto = new TodoterrenoColombia();
            if (tipo == 3) miAuto = new ConvertibleColombia();
            if (tipo == 4) miAuto = new FurgonetaColombia();
            else miAuto = null;
            return miAuto;
        }
    }
}
