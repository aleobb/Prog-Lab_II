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

namespace Ejercicio_62
{
    public partial class Form1 : Form
    {
        Thread t=null;
        Temporizador temp=null;

        public Form1()
        {
            InitializeComponent();
            
            // lblHora.Text = new Hora().AsignarHora();
        }


        private void label1_Click(object sender, EventArgs e)
        {
            lblHora.Text = new Hora().AsignarHora();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            temp = new Temporizador();
            temp.EventoTiempo += Temp_EventoTiempo;

         //   t = new Thread(actualizarHora);
         //   t.Start();
            
            //contarUnSegundo();
        }


        private void Temp_EventoTiempo(object sender, EventArgs e)
        {
            actualizarHora();
        }


        public void actualizarHora()
        {
        //    while (true)
        //    {
                if (lblHora.InvokeRequired)
                {
                    lblHora.BeginInvoke(
                        (MethodInvoker)delegate()
                        { lblHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"); }
                        );
                }
                else
                {
                    lblHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                }
       //         Thread.Sleep(1000);
       //     }

            
            /*
            DateTime h = DateTime.Now;
            long i=0;
            while (i<10000000000000000)
            {
                if((DateTime.Now-h).TotalMilliseconds > 1000 )
                {
                    lblHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    h=DateTime.Now;
                }

                i++;
            }  */

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Para utilizar el tick hay que agregarle el objeto Timer al Formulario, modifiers public, behivor enabled true y aumentar a 1000 miliseg
            // y luego para usarlo con threads hay que cambiar enabled a false
            lblHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }



        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            /*if ( !object.ReferenceEquals(t,null) && t.IsAlive)
            {
                t.Abort();
            }*/
            temp.matarHilo();
        }
    }
}
