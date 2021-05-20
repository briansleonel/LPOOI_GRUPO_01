using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using ClaseBase;

namespace Vistas
{
    public partial class frmGestionInquilino : Form
    {
        public frmGestionInquilino()
        {
            InitializeComponent();
        }


        private void frmGestionInquilino_Load(object sender, EventArgs e)
        {
            cargarInquilinos();
            lblOperador.Text = UserLogin.usuLog_FullName;
            txtPatternSearch.LostFocus += new EventHandler(this.TextLostFocus);
            txtPatternSearch.GotFocus += new EventHandler(this.TextGotFocus);
        }


        public void TextGotFocus(object sender, EventArgs e)
        {

            if (txtPatternSearch.Text == "Buscar por Apellido o Nombre")
            {
                txtPatternSearch.Text = "";
                txtPatternSearch.ForeColor = Color.Black;
            }
        }

        public void TextLostFocus(object sender, EventArgs e)
        {

            if (txtPatternSearch.Text == "")
            {
                txtPatternSearch.Text = "Buscar por Apellido o Nombre";
                txtPatternSearch.ForeColor = Color.DarkGray;
            }
        }

        private void cargarInquilinosApellido()
        {
            dgwInquilinos.DataSource = TrabajarInquilino.listarInquilinosApellidoSP();
        }
        private void cargarInquilinos()
        {
            dgwInquilinos.DataSource = TrabajarInquilino.listarInquilinos();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            cargarInquilinos();
            txtPatternSearch.Text = "Buscar por Apellido o Nombre";
            txtPatternSearch.ForeColor = Color.DarkGray;

        }

        private void dgwUsuarios_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgwInquilinos.CurrentRow != null)
            {

                //Panel Modificar

                txtModificarID.Text = dgwInquilinos.CurrentRow.Cells["ID"].Value.ToString();
                txtModificarApellido.Text = dgwInquilinos.CurrentRow.Cells["Apellido"].Value.ToString();
                txtModificarNombre.Text = dgwInquilinos.CurrentRow.Cells["Nombre"].Value.ToString();
                txtModificarTelefono.Text = dgwInquilinos.CurrentRow.Cells["Telefono"].Value.ToString();
                

                //Panel delete

                txtEliminarID.Text = dgwInquilinos.CurrentRow.Cells["ID"].Value.ToString();
                txtEliminarApellido.Text = dgwInquilinos.CurrentRow.Cells["Apellido"].Value.ToString();
                txtEliminarNombre.Text = dgwInquilinos.CurrentRow.Cells["Nombre"].Value.ToString();
                txtEliminarTelefono.Text = dgwInquilinos.CurrentRow.Cells["Telefono"].Value.ToString();
            }
        }

        /*
         * --------------------- BUTTONS GUARDAR -----------------------------
         */

        private void btnAddSaveUser_Click(object sender, EventArgs e)
        {
            if (ValidarUtil.validarTextBox(tabNewUser))
            {
                DialogResult rta = MessageBox.Show("¿Desea agregar el Inquilino?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rta == DialogResult.Yes)
                {

                    guardarInquilino();

                    MessageBox.Show("Inquilino Agregado con éxito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cleanTextBox(tabNewUser);
                    cargarInquilinos();
                }
            }
        }

        private void btnModSave_Click(object sender, EventArgs e)
        {
            if (ValidarUtil.validarTextBox(tabModificar))
            {
                DialogResult rta = MessageBox.Show("¿Esta seguro que desea modificar los datos del Inquilino?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (rta == DialogResult.Yes)
                {
                    modificarInquilino();
                    MessageBox.Show("Se actualizaron los datos del Inquilino", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cleanTextBox(tabModificar);
                    cargarInquilinos();
                }
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Eliminar Inquilino?\n ID: " + txtEliminarID.Text, "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rta == DialogResult.Yes)
            {

                TrabajarInquilino.deleteInquilinoByID(Convert.ToInt32(txtEliminarID.Text));

                MessageBox.Show("El usuario fué eliminado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cleanTextBox(tabModificar);
                cargarInquilinos();
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



        public void guardarInquilino()
        {
            Inquilino oInquilino = new Inquilino();
            oInquilino.Inq_Apellido = txtNuevoApellido.Text;
            oInquilino.Inq_Nombre = txtNuevoNombre.Text;
            oInquilino.Inq_Telefono = txtNuevoTelefono.Text;
            TrabajarInquilino.insert_inquilino(oInquilino);
        }

        private void modificarInquilino()
        {
            Inquilino oInquilino = new Inquilino();
            oInquilino.Inq_Codigo = Convert.ToInt32(txtModificarID.Text);
            oInquilino.Inq_Apellido = txtModificarApellido.Text;
            oInquilino.Inq_Nombre = txtModificarNombre.Text;
            oInquilino.Inq_Telefono = txtModificarTelefono.Text;

            TrabajarInquilino.update_inquilino(oInquilino);
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
            this.Close();

        }

        private void validarSoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarUtil.SoloLetras(e);
        }

        

        private void validarSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarUtil.SoloNumeros(e);
        }

        

        private void chkOrdenarApellido_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOrdenarApellido.Checked)
            {
                cargarInquilinosApellido();
                txtPatternSearch.Text = "Buscar por Apellido o Nombre";
                txtPatternSearch.ForeColor = Color.DarkGray;
            }

            else
            {
                cargarInquilinos();
                txtPatternSearch.Text = "Buscar por Apellido o Nombre";
                txtPatternSearch.ForeColor = Color.DarkGray;
            }

        }

        private void txtPatternSearch_KeyUp(object sender, KeyEventArgs e)
        {
                    
            dgwInquilinos.DataSource = TrabajarInquilino.buscarInquilinos(txtPatternSearch.Text);
            DataGridViewColumn Column = dgwInquilinos.Columns[0];

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pctGestionInquilinoCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pctGestionInquilinoMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pctGestionInquilinoRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pctGestionInquilinoRestaurar.Visible = false;
            pctGestionInquilinoMaximizar.Visible = true;
        }

        private void pctGestionInquilinoMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pctGestionInquilinoRestaurar.Visible = true;
            pctGestionInquilinoMaximizar.Visible = false;
        }

     }
}
