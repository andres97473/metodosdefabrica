using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metodos_de_Frabrica
{
    class TodoTerrenoAlemania : Auto
    {
        public TodoTerrenoAlemania()
        {
            nombre = "Todo terreno Alemania";
        }

        public override string darNombre()
        {
            return nombre;
        }
    }
}
