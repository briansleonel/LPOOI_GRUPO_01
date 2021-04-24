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
    public partial class FrmAltaEdificio : Form
    {

        List<Edificio> listaEdificios = new List<Edificio>();
        public FrmAltaEdificio()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            FrmAltaEdificio oFormulario = new FrmAltaEdificio();

            const string sMensaje = "Está seguro que desea guardar esos datos?";
            const string sTitulo = "Registrar Datos";

            //Mensaje de confirmación para aceptar el alta
            var vResult = MessageBox.Show(sMensaje, sTitulo,
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);

            //El registro sólo se realiza en caso de haber seleccionado "Sí" por pantalla
            if (vResult == DialogResult.Yes)
            {
                //Variable auxiliar usada para validación de campos vacíos
                bool bVacio = false;
                // Buscamos en cada Control de nuestro Formulario.
                foreach (Control oControls in this.Controls)
                {
                    //Preguntamos por cada TextBox de los controles del formulario
                    if (oControls is TextBox)
                    {
                        TextBox textBox = oControls as TextBox;
                        //Si algún TextBox se encontrase vacío la variable auxiliar se vuelve "true"
                        if (textBox.Text == string.Empty)
                        {
                            bVacio = true;
                        }
                    }
                }
                if (bVacio == false)
                {
                    Edificio oEdificio = new Edificio();
                    oEdificio.Edif_Codigo = crearId();
                    oEdificio.Edif_Nombre = txtNombre.Text;
                    oEdificio.Edif_Direccion = txtDireccion.Text;
                    oEdificio.Edif_Administrador = txtAdministrador.Text;
                    oEdificio.Edif_Telefono = txtTelefono.Text;
                    listaEdificios.Add(oEdificio);
                    MessageBox.Show("Edificio registrado correctamente " + listaEdificios.Count);
                    MessageBox.Show(" Nombre: " + oEdificio.Edif_Nombre +
                                   "\n Administrador: " + oEdificio.Edif_Administrador +
                                   "\n Dirección: " + oEdificio.Edif_Direccion +
                                   "\n Teléfono: " + oEdificio.Edif_Telefono +
                                   "\n Código: " + oEdificio.Edif_Codigo, "Datos del edificio");
                    limpiarTextBox();
                }
                else
                {
                    MessageBox.Show("Favor de llenar todos los campos."); // Si nuestra variable es verdadera mostramos un mensaje.
                }
                bVacio = false; // Devolvemos el valor original a nuestra variable.
            }
        }


        private int crearId()
        {
            if (listaEdificios.Count == 0)
                return 1;
            else
            {
                return listaEdificios.Count + 1;
            }
        }

        private void limpiarTextBox()
        {
            foreach (Control oControls in this.Controls)
            {
                if (oControls is TextBox)
                {
                    TextBox textBox = oControls as TextBox;
                    textBox.Text = string.Empty;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FrmAltaInquilino.ActiveForm.Hide();
            FrmMain inicio = new FrmMain();
            inicio.Show();
            this.Close();
        }

        private void btnAceptar_MouseHover(object sender, EventArgs e)
        {
            
        }
    }
}
