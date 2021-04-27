using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vistas {
    public partial class frmGestionUsuario : Form {
        public frmGestionUsuario() {
            InitializeComponent();
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e) {
            frmAltaUsuario altaUsuario = new frmAltaUsuario();
            altaUsuario.Show();
        }
    }
}
