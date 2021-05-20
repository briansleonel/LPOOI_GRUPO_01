using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
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
            a.ShowDialog();
            this.Show();
        }

        private void btnAltaInquilino_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGestionInquilino oGestionInquilino = new frmGestionInquilino();
            oGestionInquilino.ShowDialog();
            this.Show();
        }

        private void btnAltaDepa_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGestionDepartamento oGestionDepartamento = new FrmGestionDepartamento();
            oGestionDepartamento.ShowDialog();
            this.Show();
        }

        private void btnGestionEdificio_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGestionEdificio oGestionEdificio = new FrmGestionEdificio();
            oGestionEdificio.ShowDialog();
            this.Show();
            //this.Close();
        }

        private void btnGestionAlquiler_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGestionAlquiler oGestionAlquiler = new frmGestionAlquiler();
            oGestionAlquiler.ShowDialog();
            this.Show();
            //this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            
            var resultado = MessageBox.Show("Está seguro de cerrar sesión", "Seleccione", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                //FrmMain.ActiveForm.Hide();
                FrmLogin login = new FrmLogin();
                login.Activate();
                this.Close();
                login.Show();
                

            }
        }

        private void autorizarUsuario()
        {
            if (UserLogin.rolLog_Codigo == 1)
            {
                btnseparador5.Visible = false;
                btnGestionAlquiler.Visible = false;
                btnseparador2.Visible = false;
                btnGestionInquilino.Visible = false;
                
                


            }
            else
            {
                if (UserLogin.rolLog_Codigo == 2)
                {
                    //btnGestionarUsuarios.Enabled = false;
                    btnseparador1.Visible = false;
                    btnGestionarUsuarios.Visible = false;
                    btnseparador4.Visible = false;
                    btnGestionEdificio.Visible = false;
                    btnseparador3.Visible = false;
                    btnGestionDepartamento.Visible = false;

                }
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            lblOperador.Text = UserLogin.usuLog_FullName;
            autorizarUsuario();
        }

        private void btnLoginCerrar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Está seguro de cerrar sesión", "Seleccione", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                //FrmMain.ActiveForm.Hide();
                FrmLogin login = new FrmLogin();
                login.Activate();
                this.Close();
                login.Show();
                

            }
        }

        private void btnLoginMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnPrincipalMaximixar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnPrincipalRestaurar.Visible = true;
            btnPrincipalMaximixar.Visible = false;
        }

        private void btnPrincipalRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnPrincipalRestaurar.Visible = false;
            btnPrincipalMaximixar.Visible = true;
            
        }
        
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

     }
}
