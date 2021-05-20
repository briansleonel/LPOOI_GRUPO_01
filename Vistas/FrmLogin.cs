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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        
        private void btnAceptar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FrmLogin.ActiveForm.Close();
            Application.Exit();
        }


        private void FrmLogin_Load(object sender, EventArgs e) {

        }

        private void btnIngresar_Click(object sender, EventArgs e) {

            bool usuarioLogin = TrabajarLogin.login(txtNombreUsuario.Text,Encrypt.GetSHA256(txtContrasenia.Text));
            if (usuarioLogin)
            {
                
                //MessageBox.Show("Bienvenido/a " + UserLogin.usuLog_FullName + "\nRol: " + UserLogin.rolLog_Descripcion);
                FrmLogin.ActiveForm.Hide();
                FrmPrincipal fInicio = new FrmPrincipal();
                fInicio.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos");
            }


            //DataTable dt = TrabajarUsuario.findUsuarioByUsername(txtNombreUsuario.Text);
            //if (dt.Rows.Count == 1 && dt.Rows[0][1].ToString() == txtNombreUsuario.Text && dt.Rows[0][2].ToString() == txtContrasenia.Text) {
            //    //MessageBox.Show("Usuario y contraseña correctos\nRol: " + dt.Rows[0][6].ToString());    //Posicion 5 y 6 representa el id de rol
            //    MessageBox.Show("Bienvenido/a " + dt.Rows[0][1].ToString() + "\nRol: " + dt.Rows[0][6].ToString());
            //    FrmLogin.ActiveForm.Hide();
            //    FrmMain fInicio = new FrmMain();
            //    fInicio.Show();
            //    this.Close();
            //} else {
            //    MessageBox.Show("Usuario y/o contraseña incorrectos");
            //}
        }

        private void btnLoginCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLoginMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
