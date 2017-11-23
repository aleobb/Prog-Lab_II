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
using Entidades;

namespace _2017__RSP_LAB_II_Archivo
{
    public partial class Form1 : Form
    {
        private LosHilos hilos;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Esto lo ponemos aca o en el constructor debajo de InitializeComponent ?? => puede ir en cualquiera de los 2 lados
            hilos = new LosHilos();
            hilos.AvisoFin += MostrarMensajeFin;
        }

        private void btnLanzar_Click(object sender, EventArgs e)
        {
            try
            { 
                hilos += (new Random()).Next(0,5);
            }
            catch(CantidadInvalidaException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
            MessageBox.Show(hilos.Bitacora);
        }

        public void MostrarMensajeFin(string mensaje)
        {
            MessageBox.Show(mensaje);
        }


    }
}
