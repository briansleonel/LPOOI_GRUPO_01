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
    public partial class FrmAltaInquilino : Form
    {
        
        List<Inquilino> listaInquilinos = new List<Inquilino>();
        public FrmAltaInquilino()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            FrmAltaInquilino oFormulario = new FrmAltaInquilino();

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
                    Inquilino oInquilino = new Inquilino();
                    oInquilino.Inq_Apellido = txtApellido.Text;
                    oInquilino.Inq_Nombre = txtNombre.Text;
                    oInquilino.Inq_Telefono = txtTelefono.Text;
                    oInquilino.Inq_Codigo = crearId();
                    listaInquilinos.Add(oInquilino);

                    MessageBox.Show("Apellido: " + oInquilino.Inq_Apellido + 
                                    "\nNombre: " + oInquilino.Inq_Nombre +
                                    "\nTelefono: " + oInquilino.Inq_Telefono +
                                    "\nCódido: " + oInquilino.Inq_Codigo);
                    MessageBox.Show("Tamaño: " + listaInquilinos.Count);

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
            if (listaInquilinos.Count == 0)
                return 1;
            else
            {
                return listaInquilinos.Count + 1;
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
    }
}
