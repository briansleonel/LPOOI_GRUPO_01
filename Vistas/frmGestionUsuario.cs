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

        //borrar luego
        private void btnNuevoUsuario_Click(object sender, EventArgs e) {
            frmAltaUsuario altaUsuario = new frmAltaUsuario();
            altaUsuario.Show();
        }

        private void cargarComboRoles() {
            cmbAddRol.DisplayMember = "rol_descripcion";
            cmbAddRol.ValueMember = "rol_codigo";
            cmbAddRol.DataSource = TrabajarUsuario.listarRoles();
            cmbModRol.DisplayMember = "rol_descripcion";
            cmbModRol.ValueMember = "rol_codigo";
            cmbModRol.DataSource = TrabajarUsuario.listarRoles();
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

        private void dgwUsuarios_CurrentCellChanged(object sender, EventArgs e) {
            if (dgwUsuarios.CurrentRow != null) {

                //Panel Modificar
                cmbModRol.SelectedValue = dgwUsuarios.CurrentRow.Cells["ID Rol"].Value.ToString();

                txtModId.Text = dgwUsuarios.CurrentRow.Cells["ID"].Value.ToString();
                txtModUsername.Text = dgwUsuarios.CurrentRow.Cells["Username"].Value.ToString();
                txtModPasswrod.Text = dgwUsuarios.CurrentRow.Cells["Contraseña"].Value.ToString();
                txtModFullname.Text = dgwUsuarios.CurrentRow.Cells["Apellido y nombre"].Value.ToString();
            }
        }

        /*
         * --------------------- BUTTONS GUARDAR -----------------------------
         */

        private void btnAddSaveUser_Click(object sender, EventArgs e) {
            if (validarTextBoxAddUser()) {
                if (txtAddPassword.Text == txtAddRepeatPassword.Text) {
                    Usuario oUser = new Usuario();

                    oUser.Usu_NombreUsuario = txtAddUsername.Text;
                    oUser.Usu_Contraseña = txtAddPassword.Text;
                    oUser.Usu_ApellidoNombre = txtAddFullname.Text;
                    oUser.Rol_Codigo = Convert.ToInt32(cmbAddRol.SelectedValue);

                    TrabajarUsuario.addUsuario(oUser);

                    MessageBox.Show("Usuario Agregado con éxito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cleanTextBox(tabNewUser);
                    cargarUsuarios();
                } else
                    MessageBox.Show("Las contraseñas no coinciden", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModSave_Click(object sender, EventArgs e) {
            if (validarTextBoxModificarUser()) {
                if (txtModPasswrod.Text == txtModRepeatPassword.Text) {
                    DialogResult rta = MessageBox.Show("¿Esta seguro que desea modificar los datos del usuario?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (rta == DialogResult.Yes) {
                        Usuario oUser = new Usuario();

                        oUser.Usu_ID = Convert.ToInt32(txtModId.Text);
                        oUser.Usu_NombreUsuario = txtModUsername.Text;
                        oUser.Usu_Contraseña = txtModPasswrod.Text;
                        oUser.Usu_ApellidoNombre = txtModFullname.Text;
                        oUser.Rol_Codigo = Convert.ToInt32(cmbModRol.SelectedValue);

                        TrabajarUsuario.updateUsuario(oUser);

                        MessageBox.Show("Usuario modificado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cleanTextBox(tabModificar);
                        cargarUsuarios();
                    }
                } else
                    MessageBox.Show("Las contraseñas no coinciden", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*
         * ------------------- VALIDACIONES DE CAMPOS -----------------------
         */

        private bool validarTextBoxAddUser() {
            if (txtAddUsername.Text == "") {
                MessageBox.Show("Debe ingresar el NOMBRE DE USUARIO", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else if (txtAddPassword.Text == "") {
                MessageBox.Show("Debe ingresar la CONTRASEÑA", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else if (txtAddRepeatPassword.Text == "") {
                MessageBox.Show("Debe ingresar la CONTRASEÑA NUEVAMENTE", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else if (txtAddFullname.Text == "") {
                MessageBox.Show("Debe ingresar su APELLIDO y NOMBRE", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                return true;
            }
            return false;
        }

        private bool validarTextBoxModificarUser() {
            if (txtModUsername.Text == "") {
                MessageBox.Show("Debe ingresar el NOMBRE DE USUARIO", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else if (txtModPasswrod.Text == "") {
                MessageBox.Show("Debe ingresar la CONTRASEÑA", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else if (txtModRepeatPassword.Text == "") {
                MessageBox.Show("Debe ingresar la CONTRASEÑA NUEVAMENTE", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else if (txtModFullname.Text == "") {
                MessageBox.Show("Debe ingresar su APELLIDO y NOMBRE", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                return true;
            }
            return false;
        }

        /*
         * ---------------- LIMPIEZA DE CAMPOS -----------------------------
         */

        private void cleanTextBox(TabPage tPage) {
            foreach (Control oControls in tPage.Controls) {
                if (oControls is TextBox) {
                    TextBox textBox = oControls as TextBox;
                    textBox.Text = string.Empty;
                }
            }
        }

    }
}
