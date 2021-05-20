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
    public partial class frmGestionUsuario : Form
    {
        public frmGestionUsuario()
        {
            InitializeComponent();
        }

        private void frmGestionUsuario_Load(object sender, EventArgs e)
        {
            cargarComboRoles();
            cargarUsuarios();
            lblOperador.Text = UserLogin.usuLog_FullName;
            txtPatternSearch.Text = "Buscar Por Usuario";
            txtPatternSearch.LostFocus += new EventHandler(this.TextLostFocus);
            txtPatternSearch.GotFocus += new EventHandler(this.TextGotFocus);


        }

        private void cargarComboRoles()
        {
            cmbAddRol.DisplayMember = "rol_descripcion";
            cmbAddRol.ValueMember = "rol_codigo";
            cmbAddRol.DataSource = TrabajarUsuario.listarRoles();
            cmbModRol.DisplayMember = "rol_descripcion";
            cmbModRol.ValueMember = "rol_codigo";
            cmbModRol.DataSource = TrabajarUsuario.listarRoles();
        }


        public void TextGotFocus(object sender, EventArgs e)
        {

            if (txtPatternSearch.Text == "Buscar Por Usuario")
            {
                txtPatternSearch.Text = "";
                txtPatternSearch.ForeColor = Color.Black;
            }
        }

        public void TextLostFocus(object sender, EventArgs e)
        {

            if (txtPatternSearch.Text == "")
            {
                txtPatternSearch.Text = "Buscar Por Usuario";
                txtPatternSearch.ForeColor = Color.DarkGray;
            }
        }


        private void cargarUsuarios()
        {
            dgwUsuarios.DataSource = TrabajarUsuario.listarUsuarios();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            cargarUsuarios();
            txtPatternSearch.Text = "Buscar Por Usuario";
            txtPatternSearch.ForeColor = Color.DarkGray;
        }

        private void dgwUsuarios_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgwUsuarios.CurrentRow != null)
            {

                //Panel Modificar
                cmbModRol.SelectedValue = dgwUsuarios.CurrentRow.Cells["ID Rol"].Value.ToString();

                txtModId.Text = dgwUsuarios.CurrentRow.Cells["ID"].Value.ToString();
                txtModUsername.Text = dgwUsuarios.CurrentRow.Cells["Username"].Value.ToString();
                //txtModPasswrod.Text = dgwUsuarios.CurrentRow.Cells["Contraseña"].Value.ToString();
                txtModFullname.Text = dgwUsuarios.CurrentRow.Cells["Apellido y Nombre"].Value.ToString();

                //Panel delete
                txtEliminarRol.Text = dgwUsuarios.CurrentRow.Cells["Rol"].Value.ToString();
                txtDelId.Text = dgwUsuarios.CurrentRow.Cells["ID"].Value.ToString();
                txtDelUsername.Text = dgwUsuarios.CurrentRow.Cells["Username"].Value.ToString();
                txtDelFullname.Text = dgwUsuarios.CurrentRow.Cells["Apellido y Nombre"].Value.ToString();
            }
        }

        /*
         * --------------------- BUTTONS GUARDAR -----------------------------
         */

        private void btnAddSaveUser_Click(object sender, EventArgs e)
        {
            if (ValidarUtil.validarTextBox(tabNewUser))
            {
                if (txtAddPassword.Text == txtAddRepeatPassword.Text)
                {
                    DialogResult rta = MessageBox.Show("¿Desea agregar el usuario?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rta == DialogResult.Yes)
                    {
                        Usuario oUser = new Usuario();

                        oUser.Usu_NombreUsuario = txtAddUsername.Text;
                        oUser.Usu_Contraseña = Encrypt.GetSHA256(txtAddPassword.Text);
                        oUser.Usu_ApellidoNombre = txtAddFullname.Text;
                        oUser.Rol_Codigo = Convert.ToInt32(cmbAddRol.SelectedValue);

                        TrabajarUsuario.addUsuario(oUser);

                        MessageBox.Show("Usuario Agregado con éxito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cleanTextBox(tabNewUser);
                        cargarUsuarios();
                    }
                }
                else
                    MessageBox.Show("Las contraseñas no coinciden", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModSave_Click(object sender, EventArgs e)
        {

            if (ValidarUtil.validarTextBox(tabModificar))
            {
                if (txtModPasswrod.Text == txtModRepeatPassword.Text)
                {
                    DialogResult rta = MessageBox.Show("¿Esta seguro que desea modificar los datos del usuario?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (rta == DialogResult.Yes)
                    {
                        Usuario oUser = new Usuario();

                        oUser.Usu_ID = Convert.ToInt32(txtModId.Text);
                        oUser.Usu_NombreUsuario = txtModUsername.Text;
                        oUser.Usu_ApellidoNombre = txtModFullname.Text;
                        oUser.Rol_Codigo = Convert.ToInt32(cmbModRol.SelectedValue);

                        if (txtModPasswrod.Text == "")
                        {
                            TrabajarUsuario.updateUsuariosinpassword(oUser);
                        }
                        else
                        {
                            oUser.Usu_Contraseña = Encrypt.GetSHA256(txtModPasswrod.Text);
                            TrabajarUsuario.updateUsuario(oUser);
                        }


                        MessageBox.Show("Se actualizaron los datos del usuario ID: " + oUser.Usu_ID, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cleanTextBox(tabModificar);
                        cargarUsuarios();
                    }
                }
                else
                    MessageBox.Show("Las contraseñas no coinciden", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Eliminar usuario?\n ID: " + txtDelId.Text, "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rta == DialogResult.Yes)
            {

                //TrabajarUsuario.deleteUsuarioByID(Convert.ToInt32(txtModId.Text));
                TrabajarUsuario.deleteUsuarioByID(Convert.ToInt32(txtDelId.Text));

                MessageBox.Show("El usuario fué eliminado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cleanTextBox(tabModificar);
                cargarUsuarios();
            }
        }

        /*
         *  ------------------- BOTONES CANCEL ---------------------
         */

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            cleanTextBox(tabNewUser);

        }

        private void btnDelCancel_Click(object sender, EventArgs e)
        {
            cleanTextBox(tabDelete);

        }

        private void btnModCancel_Click(object sender, EventArgs e)
        {
            cleanTextBox(tabModificar);

        }

        /*
       * ---------------- LIMPIEZA DE CAMPOS -----------------------------
       */

        private void cleanTextBox(TabPage tPage)
        {
            foreach (Control oControls in tPage.Controls)
            {
                if (oControls is TextBox)
                {
                    TextBox textBox = oControls as TextBox;
                    textBox.Text = string.Empty;
                }
            }
        }

        private void btnVolverAtras_Click(object sender, EventArgs e)
        {
            //FrmPrincipal inicio = new FrmPrincipal();
            this.Close();
            //inicio.Show();
        }

        private void txtAddFullname_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarUtil.SoloLetras(e);
        }

        private void txtModFullname_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarUtil.SoloLetras(e);
        }



        private void txtPatternSearch_KeyUp(object sender, KeyEventArgs e)
        {

            dgwUsuarios.DataSource = TrabajarUsuario.buscarUsuarios(txtPatternSearch.Text);

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

        private void pctGestionUsuarioCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pctGestionUsuarioMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pctGestionUsuarioRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pctGestionUsuarioRestaurar.Visible = false;
            pctGestionUsuarioMaximizar.Visible = true;
        }

        private void pctGestionUsuarioMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pctGestionUsuarioRestaurar.Visible = true;
            pctGestionUsuarioMaximizar.Visible = false;
        }
    }
}
