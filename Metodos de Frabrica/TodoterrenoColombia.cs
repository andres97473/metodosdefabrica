using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metodos_de_Frabrica
{
    class TodoterrenoColombia : Auto
    {
        public TodoterrenoColombia()
        {
            nombre = "Todoterreno Colombia";
        }

        public override string darNombre()
        {
            return nombre;
        }
    }
}
