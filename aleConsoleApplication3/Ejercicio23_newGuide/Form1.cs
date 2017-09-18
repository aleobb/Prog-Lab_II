using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Ejercicio20_newGuide;

namespace Ejercicio23_newGuide
{
    public partial class Form1 : Form
    {
        Peso pesos;
        Euro euros;
        Dolar dolares;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertEuro_Click(object sender, EventArgs e)
        {
            euros = new Euro(txtEuro.Text);

            txtEuroADolar.Text = ((Dolar)euros).getCantidad().ToString();
            txtEuroAPesos.Text = ((Peso)euros).getCantidad().ToString();
            txtEuroAEuro.Text = txtEuro.Text; 
        }

        private void btnConvertDolar_Click(object sender, EventArgs e)
        {
            dolares = new Dolar(txtDolar.Text);

            txtDolarADolar.Text = txtDolar.Text;
            txtDolarAPesos.Text = ((Peso)dolares).getCantidad().ToString();
            txtDolarAEuro.Text = ((Euro)dolares).getCantidad().ToString();
        }

        private void btnConvertPesos_Click(object sender, EventArgs e)
        {
            pesos = new Peso(txtPesos.Text);

            txtPesosADolar.Text = ((Dolar)pesos).getCantidad().ToString();
            txtPesosAPesos.Text = txtPesos.Text;
            txtPesosAEuro.Text = ((Euro)pesos).getCantidad().ToString();
        }
    }
}
