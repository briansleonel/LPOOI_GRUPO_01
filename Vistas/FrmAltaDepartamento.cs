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
    public partial class FrmAltaDepartamento : Form
    {

        List<Departamento> listaDepartamentos = new List<Departamento>();
        public FrmAltaDepartamento()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            FrmAltaDepartamento oFormulario = new FrmAltaDepartamento();

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
                    Departamento oDepartamento = new Departamento();
                    oDepartamento.Dpto_Codigo = crearId();
                    oDepartamento.Edif_Codigo = Convert.ToInt32(txtCodEdificio.Text);
                    oDepartamento.Dpto_Tipo = txtTipo.Text;
                    oDepartamento.Dpto_Numero = Int32.Parse(txtNumero.Text);
                    oDepartamento.Dpto_Piso = Int32.Parse(txtPiso.Text);
                    oDepartamento.Dpto_Ambientes = Int32.Parse(txtAmbientes.Text);
                    oDepartamento.Dpto_Dormitorios = Int32.Parse(txtDormitorios.Text);
                    oDepartamento.Dpto_Baños = Int32.Parse(txtBanios.Text);
                    oDepartamento.Dpto_Disposicion = txtDisposicion.Text;
                    oDepartamento.Dpto_Precio = Convert.ToDecimal(txtPrecio.Text);
                    listaDepartamentos.Add(oDepartamento);

                    MessageBox.Show("Departamento registrado correctamente " + listaDepartamentos.Count);
                    MessageBox.Show(" Codigo Dpto.: " + oDepartamento.Dpto_Codigo +
                                   "\n Codigo Edif.: " + oDepartamento.Edif_Codigo +
                                   "\n Tipo: " + oDepartamento.Dpto_Tipo +
                                   "\n Número: " + oDepartamento.Dpto_Numero +
                                   "\n Piso: " + oDepartamento.Dpto_Piso +
                                   "\n Ambientes: " + oDepartamento.Dpto_Ambientes +
                                   "\n Dormitorios: " + oDepartamento.Dpto_Dormitorios +
                                   "\n Baños: " + oDepartamento.Dpto_Baños +
                                   "\n Disposición: " + oDepartamento.Dpto_Disposicion, "Datos del edificio"+
                                   "\n Precio: " + oDepartamento.Dpto_Precio);
                    limpiarTextBox();
                }
                else
                {
                    MessageBox.Show("Favor de llenar todos los campos."); // Si nuestra variable es verdadera mostramos un mensaje.
                }
                bVacio = false; // Devolvemos el valor original a nuestra variable.
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


        private int crearId()
        {
            if (listaDepartamentos.Count == 0)
                return 1;
            else
            {
                return listaDepartamentos.Count + 1;
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
