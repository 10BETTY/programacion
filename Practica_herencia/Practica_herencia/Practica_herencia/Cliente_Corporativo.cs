using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practica_herencia
{
   public class Cliente_Corporativo:Cliente
    {
        private string cuenta;

        public string Cuenta
        {
            get { return cuenta; }
            set { cuenta = value; }
        }

        // referencia
        public void pago()
        {
        }

    }
}
