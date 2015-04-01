using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metodos_de_Frabrica
{
    class ConvertibleAlemania : Auto
    {
        public ConvertibleAlemania()
        {
            nombre = "Convertible Alemania";
        }

        public override string darNombre()
        {
            return nombre;
        }
    }
}
