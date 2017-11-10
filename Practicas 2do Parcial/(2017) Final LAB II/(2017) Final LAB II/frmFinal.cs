using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Sanatorio;
using System.Threading;

namespace _2017__Final_LAB_II
{
    public partial class frmFinal : Form
    {
        private MEspecialista medicoEspecialista;
        private MGeneral medicoGeneral;
        private Thread mocker;
        private Queue<Paciente> pacientesEnEspera;

        public frmFinal()
        {
            InitializeComponent();

            this.medicoGeneral = new MGeneral("Luis", "Salinas");
            this.medicoEspecialista = new MEspecialista("Jorge", "Iglesias",MEspecialista.Especialidad.Traumatologo);
        }

        private void AtenderPacientes(IMedico iMedico)
        { }

        private void frmFinal_Load(object sender, EventArgs e)
        {

        }


    }
}
