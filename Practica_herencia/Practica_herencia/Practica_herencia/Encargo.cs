using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practica_herencia
{
    public class Encargo
    {
        private int encargoId;

        public int EncargoId
        {
            get { return encargoId; }
            set { encargoId = value; }
        }
        private string fecha;

        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private int valor;

        public int Valor
        {
            get { return valor; }
            set { valor = value; }
        }
    }
}
