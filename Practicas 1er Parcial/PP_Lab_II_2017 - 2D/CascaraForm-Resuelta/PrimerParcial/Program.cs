﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PP_Lab_II_2017___2D;

namespace PrimerParcial
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPrincipal());
        }
    }
}
