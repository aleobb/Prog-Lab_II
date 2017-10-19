using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_55_Archivos_WF
{
    public partial class Form1 : Form
    {
        string ruta;
        public Form1()
        {
            InitializeComponent();
        }

        private void archivosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog pf = new OpenFileDialog();
            pf.ShowDialog();
            ruta = pf.FileName;
            using(StreamReader sr = new StreamReader(ruta))
            {
              formulario.Text=  sr.ReadToEnd();
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OpenFileDialog pf = new OpenFileDialog();

            if (ruta == null) //Si la ruta està vacìa, osea que lo que se escribe serà nuevo
            {
                SaveFileDialog save = new SaveFileDialog(); // Si el texto es nuevo y el archivo nunca se abriò, doy la posibilidad de guaedar en una ruta nueva
                save.ShowDialog();

                try
                {
                    using (StreamWriter sw = new StreamWriter(save.FileName))
                    {
                        sw.WriteLine(formulario.Text);
                        
                        MessageBox.Show("Se guardò el archivo con exito !");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al guardar en el archivo " + ex.Message);
                }
                
            }
            else // Si se trata de sobreescribir el archivo ya abierto, solo lo sobreescribo
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(ruta))
                    {
                        sw.WriteLine(formulario.Text);
                        MessageBox.Show("Se guardò el archivo con exito !");
                    }
                }
                catch (IOException ex)
                {
                    
                    MessageBox.Show("Se produjo un error de escritura en el archivo " + ex.Message);

                }
                
            }
           
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void formulario_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = formulario.Text.Length.ToString() + " caracteres";
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ruta == null) //Si la ruta està vacìa, osea que lo que se escribe serà nuevo
            {
                SaveFileDialog save = new SaveFileDialog(); // Si el texto es nuevo y el archivo nunca se abriò, doy la posibilidad de guaedar en una ruta nueva
                save.ShowDialog();

                try
                {
                    using (StreamWriter sw = new StreamWriter(save.FileName))
                    {
                        sw.WriteLine(formulario.Text);

                        MessageBox.Show("Se guardò el archivo con exito !");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al guardar en el archivo " + ex.Message);
                }

            }
            else // Si se trata de sobreescribir el archivo ya abierto, solo lo sobreescribo
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(ruta))
                    {
                        sw.WriteLine(formulario.Text);
                        MessageBox.Show("Se guardò el archivo con exito !");
                    }
                }
                catch (IOException ex)
                {

                    MessageBox.Show("Se produjo un error de escritura en el archivo " + ex.Message);

                }

            }
        }
    }
}
