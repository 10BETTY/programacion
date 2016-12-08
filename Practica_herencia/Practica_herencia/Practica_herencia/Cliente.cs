using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practica_herencia
{
    public class Cliente:Encargo
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        //referencia
        public void pago()
        {
        }
        public Cliente (string c_nombre,string c_direccion)
        {
            nombre=c_nombre;
            direccion =c_direccion;
        }


    }
}
