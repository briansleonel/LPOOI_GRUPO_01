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
    public partial class FrmGestionDepartamento : Form
    {
        public FrmGestionDepartamento()
        {
            InitializeComponent();
        }


        private void FrmGestionDepartamento_Load(object sender, EventArgs e)
        {
            cargarDepartamentos();
            cargarComboEdificio();
            cargarComboDisposicion();
            cargarComboTipoDepartamento();
            lblOperador.Text = UserLogin.usuLog_FullName;
            txtPatternSearch.LostFocus += new EventHandler(this.TextLostFocus);
            txtPatternSearch.GotFocus += new EventHandler(this.TextGotFocus);

        }

        public void TextGotFocus(object sender, EventArgs e)
        {

            if (txtPatternSearch.Text == "Buscar por nombre edificio o direccion")
            {
                txtPatternSearch.Text = "";
                txtPatternSearch.ForeColor = Color.Black;
            }
        }

        public void TextLostFocus(object sender, EventArgs e)
        {

            if (txtPatternSearch.Text == "")
            {
                txtPatternSearch.Text = "Buscar por nombre edificio o direccion";
                txtPatternSearch.ForeColor = Color.DarkGray;
            }
        }

        private void cargarComboTipoDepartamento()
        {
            cmbNuevoTipoDepartamento.DisplayMember = "tipoDpto_descripcion";
            cmbNuevoTipoDepartamento.ValueMember = "tipoDpto_codigo";
            cmbNuevoTipoDepartamento.DataSource = TrabajarTipoDepartamento.listarTipoDepartamento();

            cmbModificarTipoDepartamento.DisplayMember = "tipoDpto_descripcion";
            cmbModificarTipoDepartamento.ValueMember = "tipoDpto_codigo";
            cmbModificarTipoDepartamento.DataSource = TrabajarTipoDepartamento.listarTipoDepartamento();

            cmbEliminarTipoDepartamento.DisplayMember = "tipoDpto_descripcion";
            cmbEliminarTipoDepartamento.ValueMember = "tipoDpto_codigo";
            cmbEliminarTipoDepartamento.DataSource = TrabajarTipoDepartamento.listarTipoDepartamento();

        }

        private void cargarComboEdificio()
        {
            cmbNuevobEdificio.DisplayMember = "edif_nombre";
            cmbNuevobEdificio.ValueMember = "edif_codigo";
            cmbNuevobEdificio.DataSource = TrabajarEdificio.listarEdificio();

            cmbModificarEdificio.DisplayMember = "edif_nombre";
            cmbModificarEdificio.ValueMember = "edif_codigo";
            cmbModificarEdificio.DataSource = TrabajarEdificio.listarEdificio();

            cmbEliminarEdificio.DisplayMember = "edif_nombre";
            cmbEliminarEdificio.ValueMember = "edif_codigo";
            cmbEliminarEdificio.DataSource = TrabajarEdificio.listarEdificio();

        }

        private void cargarComboDisposicion()
        {
            cmbNuevoDisposicion.DisplayMember = "Disposicion";
            cmbNuevoDisposicion.ValueMember = "dip_codigo";
            cmbNuevoDisposicion.DataSource = TrabajarDisposicion.listarDisposicionSP();

            cmbModificarDisposicion.DisplayMember = "Disposicion";
            cmbModificarDisposicion.ValueMember = "dip_codigo";
            cmbModificarDisposicion.DataSource = TrabajarDisposicion.listarDisposicionSP();

            cmbEliminarDisposicion.DisplayMember = "Disposicion";
            cmbEliminarDisposicion.ValueMember = "dip_codigo";
            cmbEliminarDisposicion.DataSource = TrabajarDisposicion.listarDisposicionSP();

        }

        private void cargarDepartamentos()
        {
            dgwDepartamentos.DataSource = TrabajarDepartamento.listarDepartamentosSP();
            OcultarColumnas();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            rbtAmbiente.Checked = false;
            rbtDispisicion.Checked = false;
            cargarDepartamentos();
            txtPatternSearch.Text = "Buscar por nombre edificio o direccion";
            txtPatternSearch.ForeColor = Color.DarkGray;
        }

        private void dgwUsuarios_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgwDepartamentos.CurrentRow != null)
            {

                //Panel Modificar
                txtModificarDepartamentoId.Text = dgwDepartamentos.CurrentRow.Cells["dpto_codigo"].Value.ToString();
                cmbModificarEdificio.SelectedValue = dgwDepartamentos.CurrentRow.Cells["edif_codigo"].Value.ToString();
                cmbModificarTipoDepartamento.SelectedValue = dgwDepartamentos.CurrentRow.Cells["tipoDpto_codigo"].Value.ToString();
                txtModificarNumero.Text = dgwDepartamentos.CurrentRow.Cells["Numero"].Value.ToString();
                txtModificarPiso.Text = dgwDepartamentos.CurrentRow.Cells["Piso"].Value.ToString();
                txtModificarAmbiente.Text = dgwDepartamentos.CurrentRow.Cells["Ambientes"].Value.ToString();
                txtModificarDormitorio.Text = dgwDepartamentos.CurrentRow.Cells["Dormitorios"].Value.ToString();
                txtModificarBanio.Text = dgwDepartamentos.CurrentRow.Cells["Baños"].Value.ToString();
                cmbModificarDisposicion.SelectedValue = dgwDepartamentos.CurrentRow.Cells["dpto_disposicion"].Value.ToString();
                txtModificarPrecio.Text = dgwDepartamentos.CurrentRow.Cells["Precio"].Value.ToString();

                //Panel delete

                txtEliminarCodigoDepartamentoId.Text = dgwDepartamentos.CurrentRow.Cells["dpto_codigo"].Value.ToString();
                cmbEliminarEdificio.SelectedValue = dgwDepartamentos.CurrentRow.Cells["edif_codigo"].Value.ToString();
                cmbEliminarTipoDepartamento.SelectedValue = dgwDepartamentos.CurrentRow.Cells["tipoDpto_codigo"].Value.ToString();
                txtEliminarNumero.Text = dgwDepartamentos.CurrentRow.Cells["Numero"].Value.ToString();
                txtEliminarPiso.Text = dgwDepartamentos.CurrentRow.Cells["Piso"].Value.ToString();
                txtEliminarAmbiente.Text = dgwDepartamentos.CurrentRow.Cells["Ambientes"].Value.ToString();
                txtEliminarDormitorio.Text = dgwDepartamentos.CurrentRow.Cells["Dormitorios"].Value.ToString();
                txtEliminarBaños.Text = dgwDepartamentos.CurrentRow.Cells["Baños"].Value.ToString();
                cmbEliminarDisposicion.SelectedValue = dgwDepartamentos.CurrentRow.Cells["dpto_disposicion"].Value.ToString();
                txtEliminarPrecio.Text = dgwDepartamentos.CurrentRow.Cells["Precio"].Value.ToString();

            }
        }

        /*
         * --------------------- BUTTONS GUARDAR -----------------------------
         */

        private void btnAddSaveUser_Click(object sender, EventArgs e)
        {
            if (ValidarUtil.validarTextBox(pnlNuevoDepartamento))
            {
                DialogResult rta = MessageBox.Show("¿Desea agregar el Departamento?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rta == DialogResult.Yes)
                {

                    guardarDepartamento();

                    MessageBox.Show("Departamento Agregado con éxito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cleanTextBox(tabNewUser);
                    cargarDepartamentos();
                }
            }
        }

        private void btnModSave_Click(object sender, EventArgs e)
        {
            if (ValidarUtil.validarTextBox(panel3))
            {
                DialogResult rta = MessageBox.Show("¿Esta seguro que desea modificar los datos del Departamento?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (rta == DialogResult.Yes)
                {
                    modificarDepartamento();
                    MessageBox.Show("Se actualizaron los datos del Departamento", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cleanTextBox(tabModificar);
                    cargarDepartamentos();
                }
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Eliminar Departamento?\n ID: " + txtEliminarCodigoDepartamentoId.Text, "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rta == DialogResult.Yes)
            {

                TrabajarDepartamento.EliminarDepartamentobyIdSP(Convert.ToInt32(txtEliminarCodigoDepartamentoId.Text));

                MessageBox.Show("El Departamento fué eliminado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cleanTextBox(tabModificar);
                cargarDepartamentos();
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



        //private Boolean validarTextBoxAddUser(Control control)
        //{

        //    //Variable auxiliar usada para validación de campos vacíos
        //    bool bVacio = true;
        //    //Buscamos en cada Control de nuestro Formulario.
        //    foreach (Control oControls in control.Controls)
        //    {
        //        //Preguntamos por cada TextBox de los controles del formulario
        //        if (oControls is TextBox)
        //        {
        //            TextBox textBox = oControls as TextBox;
        //            //Si algún TextBox se encontrase vacío la variable auxiliar se vuelve "true"
        //            if (textBox.Text == string.Empty)
        //            {
        //                bVacio = false;
        //                MessageBox.Show("Campo Requerido");
        //                textBox.Focus();
        //                textBox.BorderStyle = BorderStyle.Fixed3D;
        //                break;
        //            }
        //        }
        //    }
        //    return bVacio;

        //}

        //private bool validarTextBoxModificarUser()
        //{
        //    //    if (txtModificarApellido.Text == "")
        //    //    {
        //    //        MessageBox.Show("Debe ingresar el APELLIDO del Inquilino", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    //    }
        //    //    else if (txtModificarNombre.Text == "")
        //    //    {
        //    //        MessageBox.Show("Debe ingresar el NOMBRE del Inquilino", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    //    }
        //    //    else if (txtModificarTelefono.Text == "")
        //    //    {
        //    //        MessageBox.Show("Debe ingresar el TELEFONO del inquilino", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    //    }
        //    //    else
        //    //    {
        //    return true;
        //    //    }
        //    //return false;
        //}


        public void guardarDepartamento()
        {

            Departamento oDepartamento = new Departamento();
            oDepartamento.Edif_Codigo = (int)cmbNuevobEdificio.SelectedValue;
            oDepartamento.Dpto_Tipo = (int)cmbNuevoTipoDepartamento.SelectedValue;
            oDepartamento.Dpto_Numero = Convert.ToInt32(txtNuevoNumero.Text);
            oDepartamento.Dpto_Piso = Convert.ToInt32(txtNuevoPiso.Text);
            oDepartamento.Dpto_Ambientes = Convert.ToInt32(txtNuevoAmbientes.Text);
            oDepartamento.Dpto_Dormitorios = Convert.ToInt32(txtNuevoDormitorios.Text);
            oDepartamento.Dpto_Baños = Convert.ToInt32(txtNuevoBanios.Text);
            oDepartamento.Dpto_Disposicion = (int)cmbNuevoDisposicion.SelectedValue;
            oDepartamento.Dpto_Precio = Convert.ToDecimal(txtNuevoPrecio.Text);

            TrabajarDepartamento.NuevoDepartamentoSP(oDepartamento);
        }

        private void modificarDepartamento()
        {

            Departamento oDepartamento = new Departamento();
            oDepartamento.Dpto_Codigo = Convert.ToInt32(txtModificarDepartamentoId.Text);
            oDepartamento.Edif_Codigo = (int)cmbModificarEdificio.SelectedValue;
            oDepartamento.Dpto_Tipo = (int)cmbModificarTipoDepartamento.SelectedValue;
            oDepartamento.Dpto_Numero = Convert.ToInt32(txtModificarNumero.Text);
            oDepartamento.Dpto_Piso = Convert.ToInt32(txtModificarPiso.Text);
            oDepartamento.Dpto_Ambientes = Convert.ToInt32(txtModificarAmbiente.Text);
            oDepartamento.Dpto_Dormitorios = Convert.ToInt32(txtModificarAmbiente.Text);
            oDepartamento.Dpto_Baños = Convert.ToInt32(txtModificarBanio.Text);
            oDepartamento.Dpto_Disposicion = (int)cmbModificarDisposicion.SelectedValue;
            oDepartamento.Dpto_Precio = Convert.ToDecimal(txtModificarPrecio.Text);
            TrabajarDepartamento.UpdateDepartamentoSP(oDepartamento);
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
            //FrmPrincipal inicio = new FrmPrincipal();
            //FrmMain inicio = new FrmMain();
            //inicio.Show();
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

        private void rbtAmbiente_CheckedChanged(object sender, EventArgs e)
        {

            dgwDepartamentos.DataSource = TrabajarDepartamento.listarDepartamentosPorSP(1);
            OcultarColumnas();
        }

        private void rbtDispisicion_CheckedChanged(object sender, EventArgs e)
        {

            dgwDepartamentos.DataSource = TrabajarDepartamento.listarDepartamentosPorSP(0);
            OcultarColumnas();
        }

        private void OcultarColumnas()
        {
            DataGridViewColumn ColumnCodigoDepartamento = dgwDepartamentos.Columns["dpto_codigo"];
            ColumnCodigoDepartamento.Visible = false;
            DataGridViewColumn ColumnCodigoEdificio = dgwDepartamentos.Columns["edif_codigo"];
            ColumnCodigoEdificio.Visible = false;
            DataGridViewColumn ColumnCodigoTipoDepartamento = dgwDepartamentos.Columns["tipoDpto_codigo"];
            ColumnCodigoTipoDepartamento.Visible = false;
            DataGridViewColumn ColumnDeapartamentoDisposicion = dgwDepartamentos.Columns["Dpto_Disposicion"];
            ColumnDeapartamentoDisposicion.Visible = false;
        }

        private void txtPatternSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPatternSearch_KeyUp(object sender, KeyEventArgs e)
        {

            dgwDepartamentos.DataSource = TrabajarDepartamento.listarDepartamentosPorEdificcioORDireccionSP(txtPatternSearch.Text);
            OcultarColumnas();
        }

        private void soloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarUtil.SoloNumeros(e);
        }

        private void txtNuevoPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarUtil.NumerosDecimales(e);
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

        private void pctGestionDepartamentoCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pctGestionDepartamentoMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pctGestionDepartamentoRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pctGestionDepartamentoRestaurar.Visible = false;
            pctGestionDepartamentomaximizar.Visible = true;
        }

        private void pctGestionDepartamentomaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pctGestionDepartamentoRestaurar.Visible = true;
            pctGestionDepartamentomaximizar.Visible = false;
        }
    }
}
