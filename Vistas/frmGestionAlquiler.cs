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
    public partial class frmGestionAlquiler : Form {
        public frmGestionAlquiler() {
            InitializeComponent();
        }


        private void cargarComboEdificios() {
            cmbAddEdificio.DisplayMember = "edif_nombre";
            cmbAddEdificio.ValueMember = "edif_codigo";
            cmbAddEdificio.DataSource = TrabajarEdificio.listarEdificio();

            cmbModEdificio.DisplayMember = "edif_nombre";
            cmbModEdificio.ValueMember = "edif_codigo";
            cmbModEdificio.DataSource = TrabajarEdificio.listarEdificio();

            cmbEliminarEdificio.DisplayMember = "edif_nombre";
            cmbEliminarEdificio.ValueMember = "edif_codigo";
            cmbEliminarEdificio.DataSource = TrabajarEdificio.listarEdificio();

            cargarComboDepartamentos();
            cargarComboModDepartamentos();
            cargarComboEliminarDepartamentos();
        }
        
        private void cargarComboDepartamentos()
        {
            cmbAddDepartamento.DataSource = null;
            cmbAddDepartamento.DisplayMember = "Numero";
            cmbAddDepartamento.ValueMember = "ID";
            cmbAddDepartamento.DataSource = TrabajarDepartamento.buscarDepartamentobyIdEdificio((int)cmbAddEdificio.SelectedValue);

            
        }

        private void cargarComboModDepartamentos()
        {

            cmbModDepartamento.DataSource = null;
            cmbModDepartamento.DisplayMember = "Numero";
            cmbModDepartamento.ValueMember = "ID";
            cmbModDepartamento.DataSource = TrabajarDepartamento.buscarDepartamentobyIdEdificio((int)cmbModEdificio.SelectedValue);

        }

        private void cargarComboEliminarDepartamentos()
        {
            cmbEliminarDepartamento.DataSource = null;
            cmbEliminarDepartamento.DisplayMember = "Numero";
            cmbEliminarDepartamento.ValueMember = "ID";
            cmbEliminarDepartamento.DataSource = TrabajarDepartamento.buscarDepartamentobyIdEdificio((int)cmbEliminarEdificio.SelectedValue);

        }


        private void cargarComboInquilinos()
        {
            cmbAddInquilino.DataSource = null;
            cmbAddInquilino.DisplayMember = "Apellido";
            cmbAddInquilino.ValueMember = "ID";
            cmbAddInquilino.DataSource = TrabajarInquilino.listarInquilinos();

            cmbModInquilino.DataSource = null;
            cmbModInquilino.DisplayMember = "Apellido";
            cmbModInquilino.ValueMember = "ID";
            cmbModInquilino.DataSource = TrabajarInquilino.listarInquilinos();

            cmbEliminarInquilino.DataSource = null;
            cmbEliminarInquilino.DisplayMember = "Apellido";
            cmbEliminarInquilino.ValueMember = "ID";
            cmbEliminarInquilino.DataSource = TrabajarInquilino.listarInquilinos();
        }

        private void frmGestionAlquiler_Load(object sender, EventArgs e)
        {
            cargarComboEdificios();
            cargarAlquileres();
            cargarComboInquilinos();
            lblOperador.Text = UserLogin.usuLog_FullName;
            
        }

        private void cargarAlquileres() {
            dgwAlquileres.DataSource = TrabajarAlquiler.listarAlquileresVista();
            DataGridViewColumn ColumnCodigoEdificio = dgwAlquileres.Columns["Edificio Codigo"];
            ColumnCodigoEdificio.Visible = false;
            DataGridViewColumn ColumnCodigoInquilino = dgwAlquileres.Columns["Codigo Inquilino"];
            ColumnCodigoInquilino.Visible = false;
            DataGridViewColumn ColumnCodigoDepartamento = dgwAlquileres.Columns["Depto Codigo"];
            ColumnCodigoDepartamento.Visible = false;
            
            
            
        }



        private void btnSearch_Click(object sender, EventArgs e) {
            if (txtPatternSearch.Text != "")
                dgwAlquileres.DataSource = TrabajarUsuario.buscarUsuarios(txtPatternSearch.Text);
            else {
                MessageBox.Show("Debe ingresar un patrón de búsqueda", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarAlquileres();
            }
        }

        private void dgwAlquileres_CurrentCellChanged(object sender, EventArgs e) {
            if (dgwAlquileres.CurrentRow != null) {

                //Panel Modificar

                txtModId.Text = dgwAlquileres.CurrentRow.Cells["ID Alquiler"].Value.ToString();
                txtModPrecio.Text = dgwAlquileres.CurrentRow.Cells["Precio"].Value.ToString();

                cmbModEdificio.SelectedValue = dgwAlquileres.CurrentRow.Cells["Edificio Codigo"].Value.ToString();
                cmbModDepartamento.SelectedValue = dgwAlquileres.CurrentRow.Cells["Depto Codigo"].Value.ToString();
                cmbModInquilino.SelectedValue = dgwAlquileres.CurrentRow.Cells["Codigo Inquilino"].Value.ToString();
                dtpModFechaInicio.Text = dgwAlquileres.CurrentRow.Cells["Fecha de Inicio"].Value.ToString();
                dtpModFechaFinal.Text = dgwAlquileres.CurrentRow.Cells["Fecha de Final"].Value.ToString();

                //Panel delete

                txtEliminarId.Text = dgwAlquileres.CurrentRow.Cells["ID Alquiler"].Value.ToString();
                txtEliminarPrecio.Text = dgwAlquileres.CurrentRow.Cells["Precio"].Value.ToString();

                cmbEliminarEdificio.SelectedValue = dgwAlquileres.CurrentRow.Cells["Edificio Codigo"].Value.ToString();
                cmbEliminarDepartamento.SelectedValue = dgwAlquileres.CurrentRow.Cells["Depto Codigo"].Value.ToString();
                cmbEliminarInquilino.SelectedValue = dgwAlquileres.CurrentRow.Cells["Codigo Inquilino"].Value.ToString();
                dtpEliminarFechaInicio.Text = dgwAlquileres.CurrentRow.Cells["Fecha de Inicio"].Value.ToString();
                dtpEliminarFechaFinal.Text = dgwAlquileres.CurrentRow.Cells["Fecha de Final"].Value.ToString();


                
            }
        }

        /*
         * --------------------- BUTTONS GUARDAR -----------------------------
         */

        private void btnAddSaveInquilino_Click(object sender, EventArgs e) {
            if (validarTextBoxAddUser()) {
                    DialogResult rta = MessageBox.Show("¿Desea agregar el Alquiler?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rta == DialogResult.Yes) {
                        Alquiler oAlquiler = new Alquiler();
                        oAlquiler.Alq_Fecha = Convert.ToDateTime(DateTime.Now.ToLongDateString());
                        oAlquiler.Dpto_Codigo = (int)cmbAddDepartamento.SelectedValue;
                        oAlquiler.Inq_Codigo = (int)cmbAddInquilino.SelectedValue;
                        oAlquiler.Alq_FechaDesde = Convert.ToDateTime(dtpNuevoFechaInicio.Value);
                        oAlquiler.Alq_FechaHasta = Convert.ToDateTime(dtpNuevoFechaFinal.Value);
                        oAlquiler.Alq_Precio = Convert.ToDecimal(txtNuevoPrecio.Text);
                        TrabajarAlquiler.addAlquiler(oAlquiler);

                        MessageBox.Show("Alquiler Agregado con éxito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ValidarUtil.cleanTextBox(tabNewUser);
                        cargarAlquileres();
                   }
            }
        }

        private void btnModSave_Click(object sender, EventArgs e) {
           if (validarTextBoxModificarUser()) {

               DialogResult rta = MessageBox.Show("¿Esta seguro que desea modificar los datos del Alquiler?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
               if (rta == DialogResult.Yes)
               {
                   Alquiler oAlquilerMod = new Alquiler();

                   oAlquilerMod.Alq_Codigo = Convert.ToInt32(txtModId.Text);
                   oAlquilerMod.Alq_Fecha = Convert.ToDateTime(DateTime.Now.ToLongDateString());
                   oAlquilerMod.Dpto_Codigo = (int)cmbModDepartamento.SelectedValue;
                   oAlquilerMod.Inq_Codigo = (int)cmbModInquilino.SelectedValue;
                   oAlquilerMod.Alq_FechaDesde = Convert.ToDateTime(dtpModFechaInicio.Value);
                   oAlquilerMod.Alq_FechaHasta = Convert.ToDateTime(dtpModFechaFinal.Value);
                   oAlquilerMod.Alq_Precio = Convert.ToDecimal(txtModPrecio.Text);

                   TrabajarAlquiler.updateInquilino(oAlquilerMod);

                   MessageBox.Show("Se actualizaron los datos del usuario ID: ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   ValidarUtil.cleanTextBox(tabModificar);
                   cargarAlquileres();
               }

          }
        }

        private void btnDeleteAlquiler_Click(object sender, EventArgs e) {
            DialogResult rta = MessageBox.Show("¿Eliminar Alquiler?\n ID: " + txtEliminarId.Text, "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rta == DialogResult.Yes) {

                 
                TrabajarAlquiler.deleteAlquilerByID(Convert.ToInt32(txtEliminarId.Text));

                MessageBox.Show("El Alquiler fué eliminado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ValidarUtil.cleanTextBox(tabModificar);
                cargarAlquileres();
            }
        }

        /*
         *  ------------------- BOTONES CANCEL ---------------------
         */

        private void btnAddCancel_Click(object sender, EventArgs e) {
            ValidarUtil.cleanTextBox(tabNewUser);
            
        }

        private void btnDelCancel_Click(object sender, EventArgs e) {
            ValidarUtil.cleanTextBox(tabDelete);
            
        }

        private void btnModCancel_Click(object sender, EventArgs e) {
            ValidarUtil.cleanTextBox(tabModificar);
            
        }

        /*
         * ------------------- VALIDACIONES DE CAMPOS -----------------------
         */
        private bool validarTextBoxAddUser()
        {
            if (txtNuevoPrecio.Text == "")
            {
                MessageBox.Show("Debe ingresar el Precio", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return true;
            }
            return false;
        }

        private bool validarTextBoxModificarUser() {
            if (txtModPrecio.Text == "")
            {
                MessageBox.Show("Debe ingresar el Precio", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return true;
            }
            return false;
        }

       

        private void btnVolverAtras_Click(object sender, EventArgs e) {
            this.Close();
            FrmPrincipal inicio = new FrmPrincipal();
            //FrmMain inicio = new FrmMain();
            inicio.Show();
            
        }

        private void cmbAddEdificio_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarComboDepartamentos();
        }


        private void cmbAddDepartamento_Format(object sender, ListControlConvertEventArgs e)
        {
            DataRow r = ((DataRowView)e.ListItem).Row;
            e.Value = "Número: " + r["Numero"] + ", Piso: " + r["Piso"];
            txtNuevoPrecio.Text = r["Precio"].ToString();
            
        }

        private void cmbAddInquilino_Format(object sender, ListControlConvertEventArgs e)
        {
            DataRow r = ((DataRowView)e.ListItem).Row;
            e.Value = r["Apellido"] + ", " + r["Nombre"];
        }

        private void cmbModEdificio_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarComboModDepartamentos();
        }

        private void cmbModDepartamento_Format(object sender, ListControlConvertEventArgs e)
        {
            DataRow r = ((DataRowView)e.ListItem).Row;
            e.Value = "Número: " + r["Numero"] + ", Piso: " + r["Piso"];
            txtModPrecio.Text = r["Precio"].ToString();
        }

        private void cmbModInquilino_Format(object sender, ListControlConvertEventArgs e)
        {
            DataRow r = ((DataRowView)e.ListItem).Row;
            e.Value = r["Apellido"] + ", " + r["Nombre"];
        }

        private void cmbEliminarEdificio_TextChanged(object sender, EventArgs e)
        {
            cargarComboEliminarDepartamentos();
        }

        private void cmbEliminarDepartamento_Format(object sender, ListControlConvertEventArgs e)
        {
            DataRow r = ((DataRowView)e.ListItem).Row;
            e.Value = "Número: " + r["Numero"] + ", Piso: " + r["Piso"];
            txtEliminarPrecio.Text = r["Precio"].ToString();
        }

        private void cmbEliminarInquilino_Format(object sender, ListControlConvertEventArgs e)
        {
            DataRow r = ((DataRowView)e.ListItem).Row;
            e.Value = r["Apellido"] + ", " + r["Nombre"];
        }

        private void txtNuevoPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarUtil.NumerosDecimales(e);
        }

    }
}
