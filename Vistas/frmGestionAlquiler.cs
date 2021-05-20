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

namespace Vistas {
    public partial class frmGestionAlquiler : Form {
        public frmGestionAlquiler() {
            InitializeComponent();
        }

        int var1 = 0, var2 = 0 , var3 = 0;

        private void cargarComboFiltroTipoDepartamentoAndEdificio()
        {
            cmbFiltroTipoDepartamento.DisplayMember = "tipoDpto_descripcion";
            cmbFiltroTipoDepartamento.ValueMember = "tipoDpto_codigo";
            cmbFiltroTipoDepartamento.DataSource = TrabajarTipoDepartamento.listarTipoDepartamento();

            cmbFiltroEdificio.DisplayMember = "edif_nombre";
            cmbFiltroEdificio.ValueMember = "edif_codigo";
            cmbFiltroEdificio.DataSource = TrabajarEdificio.listarEdificio();
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
            cargarComboFiltroTipoDepartamentoAndEdificio();
            
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
            cargarAlquileres();
        }

        private void dgwAlquileres_CurrentCellChanged(object sender, EventArgs e) {
            if (dgwAlquileres.CurrentRow != null) {

                //Panel Modificar

                txtModId.Text = dgwAlquileres.CurrentRow.Cells["ID Alquiler"].Value.ToString();
                txtModPrecio.Text = dgwAlquileres.CurrentRow.Cells["Precio"].Value.ToString();
                txtModFechaContrato.Text = Convert.ToDateTime(dgwAlquileres.CurrentRow.Cells["Fecha Contrato"].Value).ToShortDateString();
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

        private void btnAddSaveAlquiler_Click(object sender, EventArgs e) {
            if (validarFecha())
            {
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
                   oAlquilerMod.Alq_Fecha = Convert.ToDateTime(txtModFechaContrato.Text);
                   oAlquilerMod.Dpto_Codigo = (int)cmbModDepartamento.SelectedValue;
                   oAlquilerMod.Inq_Codigo = (int)cmbModInquilino.SelectedValue;
                   oAlquilerMod.Alq_FechaDesde = Convert.ToDateTime(dtpModFechaInicio.Value);
                   oAlquilerMod.Alq_FechaHasta = Convert.ToDateTime(dtpModFechaFinal.Value);
                   oAlquilerMod.Alq_Precio = Convert.ToDecimal(txtModPrecio.Text);

                   TrabajarAlquiler.updateAlquiler(oAlquilerMod);

                   MessageBox.Show("Se actualizaron los datos correctamente ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            //ValidarUtil.cleanTextBox(tabNewUser);
            
        }

        private void btnDelCancel_Click(object sender, EventArgs e) {
            //alidarUtil.cleanTextBox(tabDelete);
            
        }

        private void btnModCancel_Click(object sender, EventArgs e) {
            //ValidarUtil.cleanTextBox(tabModificar);
            
        }

        /*
         * ------------------- VALIDACIONES DE CAMPOS -----------------------
         */
        private bool validarFecha()
        {
            if (dtpNuevoFechaFinal.Value.Date < dtpNuevoFechaInicio.Value.Date)
            {
                MessageBox.Show("La fecha Final debe ser mayor a la fecha de Inicio: " + dtpNuevoFechaFinal.Value, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (dtpNuevoFechaInicio.Value.Date < Convert.ToDateTime(DateTime.Now.ToLongDateString()))
                {
                    MessageBox.Show("La fecha Inico debe ser mayor o igual a la fecha de Hoy!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    return true;
                }
                }
            return false;
        }

        private bool validarTextBoxModificarUser() {

            if (dtpModFechaFinal.Value.Date < dtpModFechaInicio.Value.Date)
            {
                MessageBox.Show("La fecha Final debe ser mayor a la fecha de Inicio: " + dtpNuevoFechaFinal.Value, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                  return true;
            }
            return false;
        }

       

        private void btnVolverAtras_Click(object sender, EventArgs e) {
            this.Close();
            //FrmPrincipal inicio = new FrmPrincipal();
            //FrmMain inicio = new FrmMain();
            // inicio.Show();
            
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

        private void chkEdificio_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbFiltroEdificio.Enabled == false)
            {
                cmbFiltroEdificio.Enabled = true;
                var1 = 1;
                btnfiltroactivar();
            }
            else
            {
                cmbFiltroEdificio.Enabled = false;
                var1 = 0;
                btnfiltroactivar();
            }
        }

        private void chkFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (pnlFiltroFechas.Enabled == false)
            {
                pnlFiltroFechas.Enabled = true;
                var2 = 1;
                btnfiltroactivar();
            }
            else
            {
                pnlFiltroFechas.Enabled = false;
                var2 = 0;
                btnfiltroactivar();
            }
        }

        private void chkTipoDepartamento_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbFiltroTipoDepartamento.Enabled == false)
            {
                cmbFiltroTipoDepartamento.Enabled = true;
                var3 = 1;
                btnfiltroactivar();
            }
            else
            {
                cmbFiltroTipoDepartamento.Enabled = false;
                var3 = 0;
                btnfiltroactivar();
            }
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            if (dtpFiltroFechaInicio.Value.Date > dtpFiltroFechaFinal.Value.Date)
            {
                MessageBox.Show("La fecha Final debe ser mayor a la fecha de Inicio: ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpFiltroFechaFinal.ResetText();
            }
            else
            {
                dgwAlquileres.DataSource = TrabajarAlquiler.filtrarAlquileresPorSP(var1, var2, var3, cmbFiltroEdificio.Text, Convert.ToDateTime(dtpFiltroFechaInicio.Value.ToShortDateString()), Convert.ToDateTime(dtpFiltroFechaFinal.Value.ToShortDateString()), cmbFiltroTipoDepartamento.Text);
            }
        }

        private void btnfiltroactivar() {
            if ((var1 == 0) && (var2 == 0) && (var3 == 0))
            {
                btnFiltro.Enabled = false;
            }
            else {
                btnFiltro.Enabled = true;
            }

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Mover_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pctGestionAlquilerCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pctGestionAlquilerMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pctGestionAlquilerRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pctGestionAlquilerRestaurar.Visible = false;
            pctGestionAlquilermaximizar.Visible = true;
        }

        private void pctGestionAlquilermaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pctGestionAlquilerRestaurar.Visible = true;
            pctGestionAlquilermaximizar.Visible = false;
        }

    }
}
