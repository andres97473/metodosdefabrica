using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metodos_de_Frabrica
{
    abstract class FabricaAutos
    {
        public abstract Auto factoryMethod(int tipo);
    }
}
