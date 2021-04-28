using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ClaseBase;

namespace Vistas {
    public partial class frmGestionUsuario : Form {
        public frmGestionUsuario() {
            InitializeComponent();
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e) {
            frmAltaUsuario altaUsuario = new frmAltaUsuario();
            altaUsuario.Show();
        }

        private void btnSaveUser_Click(object sender, EventArgs e) {
            if (validarTextBox()) {

                if (txtPassword.Text == txtRepeatPassword.Text) {
                    Usuario oUser = new Usuario();

                    oUser.Usu_NombreUsuario = txtUsername.Text;
                    oUser.Usu_Contraseña = txtPassword.Text;
                    oUser.Usu_ApellidoNombre = txtApellidoNombre.Text;
                    oUser.Rol_Codigo = Convert.ToInt32(cmbRol.SelectedValue);

                    TrabajarUsuario.addUsuario(oUser);

                    MessageBox.Show("Usuario Agregado con éxito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cleanTextBox();
                    cargarUsuarios();
                } else
                    MessageBox.Show("Las contraseñas no coinciden", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarComboRoles() {
            cmbRol.DisplayMember = "rol_descripcion";
            cmbRol.ValueMember = "rol_codigo";
            cmbRol.DataSource = TrabajarUsuario.listarRoles();
        }

        private bool validarTextBox() {
            if (txtUsername.Text == "") {
                MessageBox.Show("Debe ingresar el NOMBRE DE USUARIO", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else if (txtPassword.Text == "") {
                MessageBox.Show("Debe ingresar la CONTRASEÑA", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else if (txtRepeatPassword.Text == "") {
                MessageBox.Show("Debe ingresar la CONTRASEÑA NUEVAMENTE", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else if (txtApellidoNombre.Text == "") {
                MessageBox.Show("Debe ingresar su APELLIDO y NOMBRE", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                return true;
            }
            return false;
        }

        private void cleanTextBox() {
            foreach (Control oControls in pnlAddUser.Controls) {
                if (oControls is TextBox) {
                    TextBox textBox = oControls as TextBox;
                    textBox.Text = string.Empty;
                }
            }
            MessageBox.Show("Campos limpios");
        }

        private void frmGestionUsuario_Load(object sender, EventArgs e) {
            cargarComboRoles();
            cargarUsuarios();
        }

        private void cargarUsuarios() {
            dgwUsuarios.DataSource = TrabajarUsuario.listarUsuarios();
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            if (txtPatternSearch.Text != "")
                dgwUsuarios.DataSource = TrabajarUsuario.buscarUsuarios(txtPatternSearch.Text);
            else {
                MessageBox.Show("Debe ingresar un patrón de búsqueda", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarUsuarios();
            }
                
        }
    }
}
