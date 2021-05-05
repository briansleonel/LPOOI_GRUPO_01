﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Vistas
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FrmLogin oFrmLogin = new FrmLogin();
            oFrmLogin.Show();
            //oFrmLogin.FormClosed += MainForm_Closed;
            //frmGestionAlquiler a = new frmGestionAlquiler();
            //frmGestionInquilino a = new frmGestionInquilino();
            //frmGestionUsuario a = new frmGestionUsuario();
            //a.Show();

            Application.Run();
        }


        private static void MainForm_Closed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= MainForm_Closed;

            if (Application.OpenForms.Count == 0)
            {
                Application.ExitThread();
            }
            else
            {
                Application.OpenForms[0].FormClosed += MainForm_Closed;
            }
        }
    }
}
