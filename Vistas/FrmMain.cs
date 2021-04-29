using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void altaDeEdificiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAltaEdificio oAltaEdif = new FrmAltaEdificio();
            oAltaEdif.Show();
            this.Close();
        }

        /*
         * PRUEBA PARA VER SI FUNCIONA LO DEL BRANCH
        */
        /// <summary>
        /// Salir del programa y volver al inicio de sesión
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Está seguro de cerrar sesión", "Seleccione", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                FrmMain.ActiveForm.Hide();
                FrmLogin login = new FrmLogin();
                login.Activate();
                login.Show();
                this.Close();

            }
        }

        private void btnAltaInquilino_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAltaInquilino oAltaInquilino = new FrmAltaInquilino();
            oAltaInquilino.Show();
            this.Close();
        }

        private void btnAltaDepa_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAltaDepartamento oAltaDepa = new FrmAltaDepartamento();
            oAltaDepa.Show();
            this.Close();
        }

        private void btnAltaEdificio_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAltaEdificio oAltaEdif = new FrmAltaEdificio();
            oAltaEdif.Show();
            this.Close();
        }

        private void FrmMain_Load(object sender, EventArgs e) {

        }
    }
}
