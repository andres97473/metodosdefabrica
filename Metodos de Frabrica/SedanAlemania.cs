using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metodos_de_Frabrica
{
    class SedanAlemania : Auto
    {
         public SedanAlemania()
        {
            nombre = "Sedan Alemania";
        }

        public override string darNombre()
        {
            return nombre;
        }
    }
    
}
