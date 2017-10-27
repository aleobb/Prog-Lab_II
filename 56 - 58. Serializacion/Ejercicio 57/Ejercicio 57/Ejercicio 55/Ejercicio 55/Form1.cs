using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;  // NO OLVIDARSE DE AGREGAR ESTE USING

namespace Ejercicio_55
{
    public partial class Form1 : Form
    {
        string pathAndNameOfFile=null;

        public Form1()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "";

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog a = new OpenFileDialog();

            if (a.ShowDialog() == DialogResult.OK)
            {
                pathAndNameOfFile = a.FileName;
                StreamReader file = new StreamReader(pathAndNameOfFile);

                richTextBox1.Text = file.ReadToEnd();

                file.Close();
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(pathAndNameOfFile != null)
            {
                guardarArch();
            }
            else
            {
                guardarComoToolStripMenuItem_Click(sender, e);
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog g = new SaveFileDialog();

            if (g.ShowDialog() == DialogResult.OK)
            {
                try
                { 
                    pathAndNameOfFile = g.FileName;
                    if (File.Exists(pathAndNameOfFile))
                    {
                        MessageBox.Show("Archivo no guardado!! Reingrese un nombre de archivo no existente o cancele.");
                        guardarComoToolStripMenuItem_Click(sender, e);
                    }
                    else
                    {
                        guardarArch();
                    }
                }
                catch(Exception exc)
                {
                    throw exc;
                }
            }
        }

        private void guardarArch()
        {
            StreamWriter file = new StreamWriter(pathAndNameOfFile);
            file.WriteLine(richTextBox1.Text);
            file.Close();
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Cantidad de caracteres: " + richTextBox1.Text.Length.ToString();
        }

        private void statusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
