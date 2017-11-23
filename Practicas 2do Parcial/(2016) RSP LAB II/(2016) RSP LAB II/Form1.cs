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

namespace _2016__RSP_LAB_II
{
    public partial class Form1 : Form
    {
        //Tengo que volver a declarar el delegado acá!?!?

        private List<Persona> corredores;
        private List<Thread> corredoresActivos;
        private bool hayGanador;

        public delegate void CorrenCallback(int avance, Corredor corredor); //<= si uso el de la clase persona está bien también
       // public delegate void CorrenCallBack;

        public Form1()
        {
            InitializeComponent();

            this.corredores = new List<Persona>();
            this.corredoresActivos = new List<Thread>();
            this.corredores.Add(new Persona("Fernando", 9, Corredor.Carril.Carril_1));
            this.corredores.Add(new Persona("Fernando", 15, Corredor.Carril.Carril_2));
            this.hayGanador = false;

            pgbCarril1.Maximum = 100;
            pgbCarril2.Maximum = 100;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        void LimpiarCarriles()
        {
            pgbCarril1.Value = 0;
            pgbCarril2.Value = 0;
        }

        void HayGanador(Corredor corredor)
        {
            // Conviene hacerlo con un thread ???????????
            // Thread guardar = new Thread( new ParameterizedThreadStart( corredor.Guardar ) );
            // guardar.Start("ganadores.txt");
            corredor.Guardar("ganadores.txt");
            foreach (Thread t in this.corredoresActivos)
                t.Abort();
            this.corredoresActivos.Clear();
        }

        private void btnCorrer_Click(object sender, EventArgs e)
        {
            corredores.ElementAt(0).Corriendo += PersonaCorriendo;
            corredores.ElementAt(1).Corriendo += PersonaCorriendo; 

            

            Thread t = new Thread(PersonaCorriendo);

        }

        void PersonaCorriendo(int avance, Corredor corredor)
        {
            if (pgbCarril1.InvokeRequired || pgbCarril2.InvokeRequired)
            {
                CorrenCallback d = new CorrenCallback(PersonaCorriendo);  // Qué carajos es esto?????? instanciamiento de un delegado ???
                this.Invoke(d, new object[] { avance, corredor });
            }
            else
            {
                if (!this.hayGanador)
                {
                    if (corredor.CarrilElegido == Corredor.Carril.Carril_1)
                        this.AnalizaCarrera(pgbCarril1, avance, corredor);
                    else
                        this.AnalizaCarrera(pgbCarril2, avance, corredor);
                }
            }
        }

        void AnalizaCarrera(ProgressBar carril, int avance, Corredor corredor)
        {
            if( avance + carril.Value < pgbCarril1.Maximum )  // hago una sola evaluacion porque pgbCarril1.Maximum es igual a pgbCarril2.Maximum
            {
                carril.Value += avance;
            }
            HayGanador(corredor);
        }

    }
}
