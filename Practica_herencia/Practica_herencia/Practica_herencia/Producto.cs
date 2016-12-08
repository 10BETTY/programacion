using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practica_herencia
{
  public  class Producto:Encargo
    {
        private int ID;

        public int ID1
        {
            get { return ID; }
            set { ID = value; }
        }
        private string coste;

        public string Coste
        {
            get { return coste; }
            set { coste = value; }
        }

    }
}
