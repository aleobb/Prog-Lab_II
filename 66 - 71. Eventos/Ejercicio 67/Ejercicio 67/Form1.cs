using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ClassLibrary1;

namespace Ejercicio_67
{
    public partial class Form1 : Form
    {
        private Persona p=null;
        private event DelegadoString eventoForm;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            eventoForm += NotificarCambio;
        }

        private static void NotificarCambio(string msg)
        {
            MessageBox.Show(msg);
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (object.ReferenceEquals(p, null))
            {
                p = new Persona(txtNombre.Text, txtApellido.Text);
                eventoForm.Invoke("Persona " + p.Mostrar() + " creada correctamente!");
            }
            else
            {
                if(txtApellido.Text != p.Apellido)
                    p.Apellido = txtApellido.Text;
                if(txtNombre.Text != p.Nombre)
                    p.Nombre = txtNombre.Text;
                eventoForm.Invoke("Persona " + p.Mostrar() + " modificada correctamente!");
            }
        }
    }
}
