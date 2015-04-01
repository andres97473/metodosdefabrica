using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metodos_de_Frabrica
{
    class SedanColombia : Auto
    {
         public SedanColombia()
        {
            nombre = "Sedan Colombia";
        }

        public override string darNombre()
        {
            return nombre;
        }
    }
    
}
