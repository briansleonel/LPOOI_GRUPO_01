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
    public partial class frmAltaUsuario : Form {
        public frmAltaUsuario() {
            InitializeComponent();
        }

        private void frmAltaUsuario_Load(object sender, EventArgs e) {
            cargarComboRoles();
        }

        private void cargarComboRoles() {
            cmbRol.DisplayMember = "rol_descripcion";
            cmbRol.ValueMember = "rol_codigo";
            cmbRol.DataSource = TrabajarUsuario.listarRoles();
        }

    }
}
