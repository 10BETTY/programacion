using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Practica_herencia
{
    public partial class Form1 : Form
    {
        Cliente a = new Cliente();
        Encargo b = new Encargo();
        Producto c = new Producto();
        Cliente_Particular d = new Cliente_Particular();
        Cliente_Corporativo e = new Cliente_Corporativo();
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a.Nombre = (this.txtnombre.Text);
            a.Direccion = (this.txtdireccion.Text);

            b.EncargoId.ToString(this.txtencargo.Text);
            b.Fecha = (this.txtfecha.Text); 
            b.Valor.ToString(this.txtvalor.Text);

            c.ID1.ToString(this.txtid.Text);
            c.Coste = (this.txtcoste.Text);

            d.TarjetaNmr = (this.txttarjeta.Text);

           

         


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            MessageBox.Show(b.EncargoId.ToString());
            MessageBox.Show(b.Fecha.ToString());
            MessageBox.Show(b.Valor.ToString());


        } 
    }
}
