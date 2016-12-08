using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practica_herencia
{
    public class Cliente_Particular:Cliente
    {
        private string tarjetaNmr;

        public string TarjetaNmr
        {
            get { return tarjetaNmr; }
            set { tarjetaNmr = value; }
        }

        // referencia
        public void pago()
        {
        }

    }
}
