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
    public partial class FrmGestionEdificio : Form
    {
        public FrmGestionEdificio()
        {
            InitializeComponent();
        }


        private void FrmGestionEdificio_Load(object sender, EventArgs e)
        {
            cargarEdificios();
            lblOperador.Text = UserLogin.usuLog_FullName;
            txtPatternSearch.LostFocus += new EventHandler(this.TextLostFocus);
            txtPatternSearch.GotFocus += new EventHandler(this.TextGotFocus);
        }

        public void TextGotFocus(object sender, EventArgs e)
        {

            if (txtPatternSearch.Text == "Buscar por nombre edificio o dirección")
            {
                txtPatternSearch.Text = "";
                txtPatternSearch.ForeColor = Color.Black;
            }
        }

        public void TextLostFocus(object sender, EventArgs e)
        {

            if (txtPatternSearch.Text == "")
            {
                txtPatternSearch.Text = "Buscar por nombre edificio o dirección";
                txtPatternSearch.ForeColor = Color.DarkGray;
            }
        }

        private void cargarEdificios()
        {
            dgwEdificios.DataSource = TrabajarEdificio.listarEdificioSP();
          
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            cargarEdificios();
            txtPatternSearch.Clear();
            txtPatternSearch.Text = "Buscar por nombre edificio o dirección";
            txtPatternSearch.ForeColor = Color.DarkGray;
        }

        private void dgwUsuarios_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgwEdificios.CurrentRow != null)
            {

                //Panel Modificar

                txtModificarID.Text = dgwEdificios.CurrentRow.Cells["ID"].Value.ToString();
                txtModificarNombre.Text = dgwEdificios.CurrentRow.Cells["Nombre"].Value.ToString();
                txtModificarDireccion.Text = dgwEdificios.CurrentRow.Cells["Direccion"].Value.ToString();
                txtModificarAdministrador.Text = dgwEdificios.CurrentRow.Cells["Administrador"].Value.ToString();
                txtModificarTelefono.Text = dgwEdificios.CurrentRow.Cells["Telefono"].Value.ToString();


 

                //Panel delete

                txtEliminarID.Text = dgwEdificios.CurrentRow.Cells["ID"].Value.ToString();
                txtEliminarNombre.Text = dgwEdificios.CurrentRow.Cells["Nombre"].Value.ToString();
                txtEliminarDireccion.Text = dgwEdificios.CurrentRow.Cells["Direccion"].Value.ToString();
                txtEliminarAdministrador.Text = dgwEdificios.CurrentRow.Cells["Administrador"].Value.ToString();
                txtEliminarTelefono.Text = dgwEdificios.CurrentRow.Cells["Telefono"].Value.ToString();
            }
        }

        /*
         * --------------------- BUTTONS GUARDAR -----------------------------
         */

        private void btnAddGuardarEdificio_Click(object sender, EventArgs e)
        {
            if (ValidarUtil.validarTextBox(tabNewUser))
            {
                DialogResult rta = MessageBox.Show("¿Desea agregar el Edificio?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rta == DialogResult.Yes)
                {

                    guardarEdificio();

                    MessageBox.Show("Edificio Agregado con éxito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cleanTextBox(tabNewUser);
                    cargarEdificios();
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
                    modificarEdificio();
                    MessageBox.Show("Se actualizaron los datos del Inquilino", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cleanTextBox(tabModificar);
                    cargarEdificios();
                }
            }
        }

        private void btnEliminarEdificio_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Eliminar Edificio?\n ID: " + txtEliminarID.Text, "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rta == DialogResult.Yes)
            {
                TrabajarEdificio.EliminarEdificiobyIdSP(Convert.ToInt32(txtEliminarID.Text));


                MessageBox.Show("El Edificio fué eliminado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cleanTextBox(tabModificar);
                cargarEdificios();
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

       

        

        public void guardarEdificio()
        {
            Edificio oEdificio = new Edificio();
            oEdificio.Edif_Nombre = txtNuevoNombre.Text;
            oEdificio.Edif_Direccion = txtNuevoDireccion.Text;
            oEdificio.Edif_Administrador = txtNuevoAdministrador.Text;
            oEdificio.Edif_Telefono = txtNuevoTelefono.Text;

            TrabajarEdificio.NuevoEdificioSP(oEdificio);
        }

        private void modificarEdificio()
        {
            Edificio oEdificio = new Edificio();
            oEdificio.Edif_Codigo = Convert.ToInt32(txtModificarID.Text);
            oEdificio.Edif_Nombre = txtModificarNombre.Text;
            oEdificio.Edif_Direccion= txtModificarDireccion.Text;
            oEdificio.Edif_Telefono = txtModificarTelefono.Text;
            oEdificio.Edif_Administrador = txtModificarAdministrador.Text;
            TrabajarEdificio.UpdateEdificioSP(oEdificio);
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


        private void validarSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarUtil.SoloNumeros(e);
        }

        private void txtPatternSearch_KeyUp(object sender, KeyEventArgs e)
        {
            dgwEdificios.DataSource = TrabajarEdificio.listarEdificcioPorNombreORDireccionSP(txtPatternSearch.Text);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pctGestionEdificioMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pctGestionEdificioRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pctGestionEdificioRestaurar.Visible = false;
            pctGestionEdificioMaximizar.Visible = true;
        }

        private void pctGestionEdificiomaximizae_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pctGestionEdificioRestaurar.Visible = true;
            pctGestionEdificioMaximizar.Visible = false;
        }
    }
}
