﻿using System;
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
            this.medicoEspecialista = new MEspecialista("Jorge", "Iglesias", MEspecialista.Especialidad.Traumatologo);

            this.medicoEspecialista.AtencionFinalizada += FinAtencion;
            this.medicoGeneral.AtencionFinalizada += FinAtencion;

            this.pacientesEnEspera = new Queue<Paciente>();
        }

        private void FinAtencion(Paciente p, Medico m)
        {
            StringBuilder sb = new StringBuilder();
            if (!object.ReferenceEquals(p, null) && !object.ReferenceEquals(m, null))
                sb.AppendFormat("Finalizó la atención de {0} por {1}!", p.ToString(), m.ToString());
            else
                sb.AppendFormat("no se puedo atender");

            MessageBox.Show(sb.ToString());

        }

        private void AtenderPacientes(IMedico iMedico)
        {
            //((Medico)iMedico).AtenderA = pacientesEnEspera.Dequeue(); <= lo agregue en iniciar atencion
            if(this.pacientesEnEspera.Count>0)
                iMedico.IniciarAtencion(this.pacientesEnEspera.Dequeue());
            else
                MessageBox.Show("No hay pacientes que atender");
        }

    //    private void MensajeNoHayPacientes(string s)
    //    { }

        private void frmFinal_Load(object sender, EventArgs e)
        {
            mocker = new Thread(this.MockPacientes);
            mocker.Start();
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            this.AtenderPacientes(this.medicoGeneral); 
            //**********
        }

        private void btnEspecialista_Click(object sender, EventArgs e)
        {
            this.AtenderPacientes(this.medicoEspecialista);
            //************
        }


        private void frmFinal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!object.ReferenceEquals(this.mocker, null) && this.mocker.IsAlive)
                this.mocker.Abort();
        }

        private void MockPacientes()
        {
            for (int i = 0; i < 1000; i++)
            {
                Paciente p = new Paciente("paciente " + (i + 1), "lastname");
                this.pacientesEnEspera.Enqueue(p);
                MessageBox.Show(p.ToString());
                Thread.Sleep(5000);
            }
            
        }
    }
}
