using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using EntidadesPP;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public List<Base> listaElementos;

        public Form1()
        {
            InitializeComponent();
            listaElementos = new List<Base>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Name = "Final - Ben Alejandro";
            this.Text = this.Name;

        }

        private void btnPunto1_Click(object sender, EventArgs e)
        {
            Base derUno1 = new DerivadaUno(10, 11, 12);
            DerivadaUno derUno2 = new DerivadaUno(1, 2, 3);
            Base derDos1 = new DerivadaDos();

            listaElementos.Add(derUno1);
            listaElementos.Add(derUno2);
            listaElementos.Add(derDos1);

            StringBuilder auxiliar = new StringBuilder();
            foreach (Base b in listaElementos)
            {
                auxiliar.AppendLine(b.Version);
            }
            /*
            Thread t = new Thread(new ParameterizedThreadStart(CargarRichTextBox));
            t.Start(auxiliar.ToString());
             */
            CargarRichTextBox(auxiliar.ToString()); 
        }

        private void btnPunto2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para primer parcial", "Para primer parcial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnPunto3_Click(object sender, EventArgs e)
        {

        }

        private void btnPunto4_Click(object sender, EventArgs e)
        {

        }

        private void btnPunto5_Click(object sender, EventArgs e)
        {

        }

        delegate void CargarRichTextBoxCallback(string datos);
        private void CargarRichTextBox(string datos)
        {
            if (rtbTextoSalida.InvokeRequired)
            {
                CargarRichTextBoxCallback d = new CargarRichTextBoxCallback(CargarRichTextBox);
                this.Invoke(d, new object[] { datos });
            }
            else
            {
                rtbTextoSalida.Text = datos;
            }
        }

        private void rtbTextoSalida_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
