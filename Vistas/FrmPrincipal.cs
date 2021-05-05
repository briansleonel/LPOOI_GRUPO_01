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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnGestionarUsuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGestionUsuario a = new frmGestionUsuario();
            a.Show();
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

        private void btnGestionEdificio_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAltaEdificio oAltaEdif = new FrmAltaEdificio();
            oAltaEdif.Show();
            this.Close();
        }

        private void btnGestionAlquiler_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGestionAlquiler oGestionAlquiler = new frmGestionAlquiler();
            oGestionAlquiler.Show();
            this.Close();
        }

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

        private void autorizarUsuario()
        {
            if (UserLogin.rolLog_Codigo == 1)
            {
                btnGestionAlquiler.Enabled = false;
                btnGestionInquilino.Enabled = false;
                


            }
            else
            {
                if (UserLogin.rolLog_Codigo == 2)
                {
                    btnGestionarUsuarios.Enabled = false;
                    btnGestionEdificio.Enabled = false;
                    btnGestionDepartamento.Enabled = false;

                }
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            lblOperador.Text = UserLogin.usuLog_FullName;
            autorizarUsuario();
        }
    }
}
