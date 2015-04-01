using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metodos_de_Frabrica
{
    class FurgonetaColombia : Auto
    {
        public FurgonetaColombia()
        {
            nombre = "Furgoneta Colombia";
        }

        public override string darNombre()
        {
            return nombre;
        }
    }
}
