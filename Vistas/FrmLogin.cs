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
        }

        private void btnAceptar_MouseHover(object sender, EventArgs e)
        {
            btnAceptar.BackColor = Color.Azure;
        }

        private void btnAceptar_MouseLeave(object sender, EventArgs e)
        {
            btnAceptar.BackColor = Color.Empty;
        }

        private void btnCancelar_MouseHover(object sender, EventArgs e)
        {
            btnCancelar.BackColor = Color.AntiqueWhite;
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btnCancelar.BackColor = Color.Empty;
        }
    }
}
