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
            String sNombreUsuario = txtNombreUsuario.Text;
            String sContraseña = txtContrasenia.Text;

            Usuario usuario1 = new Usuario("a","a",1,"Zapaneitor Juan",1);
            List<Usuario> lUsuarios = new List<Usuario>();
            lUsuarios.Add(usuario1);
            foreach (Usuario u in lUsuarios)
            {
                if (u.Usu_NombreUsuario == sNombreUsuario && u.Usu_Contraseña == sContraseña)
                {
                    MessageBox.Show("Bienvanido Usuario: " + u.Usu_ApellidoNombre + 
                                    "\nRol: " + u.Rol_Codigo);
                    FrmLogin.ActiveForm.Hide();
                    FrmMain fInicio = new FrmMain();
                    fInicio.Show();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Usuario Inexistente");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FrmLogin.ActiveForm.Close();
            Application.Exit();
        }

        private void btnCancelar_MouseHover(object sender, EventArgs e)
        {
            btnCancelar.BackColor = Color.AntiqueWhite;
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btnCancelar.BackColor = Color.Empty;
        }

        private void lblContrasenia_Click(object sender, EventArgs e) {

        }

        private void lblNombreUsuario_Click(object sender, EventArgs e) {

        }

        private void FrmLogin_Load(object sender, EventArgs e) {

        }

        private void btnIngresar_Click(object sender, EventArgs e) {

            bool usuarioLogin = TrabajarLogin.login(txtNombreUsuario.Text,txtContrasenia.Text);
            if (usuarioLogin)
            {
                
                MessageBox.Show("Bienvenido/a " + UserLogin.usuLog_FullName + "\nRol: " + UserLogin.rolLog_Codigo);
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
    }
}
