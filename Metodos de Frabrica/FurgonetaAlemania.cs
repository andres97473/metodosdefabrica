using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metodos_de_Frabrica
{
    class FurgonetaAlemania : Auto
    {
        public FurgonetaAlemania()
        {
            nombre = "Furgoneta Alemania";
        }

        public override string darNombre()
        {
            return nombre;
        }
    }
}
