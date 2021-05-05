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
        }

        private void cargarInquilinos()
        {
            dgwInquilinos.DataSource = TrabajarInquilino.listarInquilinos();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            cargarInquilinos();
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
            if (validarTextBoxAddUser())
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
            if (validarTextBoxModificarUser())
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

        /*
         * ------------------- VALIDACIONES DE CAMPOS -----------------------
         */

        private bool validarTextBoxAddUser()
        {
            if (txtNuevoApellido.Text == "")
            {
                MessageBox.Show("Debe ingresar el APELLIDO del Inquilino", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtNuevoNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar el NOMBRE del Inquilino", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtNuevoTelefono.Text == "")
            {
                MessageBox.Show("Debe ingresar el TELEFONO del inquilino", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return true;
            }
            return false;
        }

        private bool validarTextBoxModificarUser()
        {
            if (txtModificarApellido.Text == "")
            {
                MessageBox.Show("Debe ingresar el APELLIDO del Inquilino", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtModificarNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar el NOMBRE del Inquilino", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtModificarTelefono.Text == "")
            {
                MessageBox.Show("Debe ingresar el TELEFONO del inquilino", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return true;
            }
            return false;
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

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtPatternSearch.Text != "")
            {
                dgwInquilinos.DataSource = TrabajarInquilino.buscarInquilinos(txtPatternSearch.Text);
                DataGridViewColumn Column = dgwInquilinos.Columns[0];

            }
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
            FrmPrincipal inicio = new FrmPrincipal();
            //FrmMain inicio = new FrmMain();
            inicio.Show();
        }

        private void txtNuevoApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarUtil.SoloLetras(e);
        }

        private void txtNuevoNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarUtil.SoloLetras(e);
        }

        private void txtNuevoTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarUtil.SoloNumeros(e);
        }

        private void txtModificarApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarUtil.SoloLetras(e);
        }

        private void txtModificarNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarUtil.SoloLetras(e);
        }

        private void txtModificarTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarUtil.SoloNumeros(e);
        }
    }
}
