using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClaseBase;
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
            frmGestionInquilino oGestionInquilino = new frmGestionInquilino();
            oGestionInquilino.Show();
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
            lblUserlogin.Text = UserLogin.usuLog_FullName + " Rol: " +UserLogin.rolLog_Descripcion;
            autorizarUsuario ();
        }

        private void btnGestionarUsuarios_Click(object sender, EventArgs e) {
            frmGestionUsuario a = new frmGestionUsuario();
            a.Show();
        }

        private void btnAltaAlquiler_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGestionAlquiler oGestionAlquiler = new frmGestionAlquiler();
            oGestionAlquiler.Show();
            this.Close();
        }
        private void autorizarUsuario ()
        {
            if (UserLogin.rolLog_Codigo == 1)
            {
                tbInquilino.Enabled = false;
                tbAlquiler.Enabled = false;
                
                
            }
            else
            {
                if (UserLogin.rolLog_Codigo == 2)
                {
                    lblAcesoUsuario.Text = "Sin Permiso Suficiente!!!!!!!";
                    tbUsuario.Enabled = false;
                    tbEdificio.Enabled = false;
                    tbDepartamento.Enabled = false;
                }
            }
        }
        
        
    }
}
