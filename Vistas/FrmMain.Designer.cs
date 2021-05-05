namespace Vistas
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSalir = new System.Windows.Forms.Button();
            this.tbclMenuPrincipal = new System.Windows.Forms.TabControl();
            this.tbUsuario = new System.Windows.Forms.TabPage();
            this.lblAcesoUsuario = new System.Windows.Forms.Label();
            this.btnGestionarUsuarios = new System.Windows.Forms.Button();
            this.tbInquilino = new System.Windows.Forms.TabPage();
            this.btnAltaInquilino = new System.Windows.Forms.Button();
            this.tbDepartamento = new System.Windows.Forms.TabPage();
            this.btnBajaDepa = new System.Windows.Forms.Button();
            this.btnBuscarDepa = new System.Windows.Forms.Button();
            this.btnModDepa = new System.Windows.Forms.Button();
            this.btnAltaDepa = new System.Windows.Forms.Button();
            this.tbEdificio = new System.Windows.Forms.TabPage();
            this.btnBajaEdificio = new System.Windows.Forms.Button();
            this.btnBuscarEdificio = new System.Windows.Forms.Button();
            this.btnModEdificio = new System.Windows.Forms.Button();
            this.btnAltaEdificio = new System.Windows.Forms.Button();
            this.tbAlquiler = new System.Windows.Forms.TabPage();
            this.btnGestionAlquiler = new System.Windows.Forms.Button();
            this.lblUserlogin = new System.Windows.Forms.Label();
            this.tbclMenuPrincipal.SuspendLayout();
            this.tbUsuario.SuspendLayout();
            this.tbInquilino.SuspendLayout();
            this.tbDepartamento.SuspendLayout();
            this.tbEdificio.SuspendLayout();
            this.tbAlquiler.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(211, 268);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(105, 34);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tbclMenuPrincipal
            // 
            this.tbclMenuPrincipal.Controls.Add(this.tbUsuario);
            this.tbclMenuPrincipal.Controls.Add(this.tbInquilino);
            this.tbclMenuPrincipal.Controls.Add(this.tbDepartamento);
            this.tbclMenuPrincipal.Controls.Add(this.tbEdificio);
            this.tbclMenuPrincipal.Controls.Add(this.tbAlquiler);
            this.tbclMenuPrincipal.Location = new System.Drawing.Point(0, 3);
            this.tbclMenuPrincipal.Name = "tbclMenuPrincipal";
            this.tbclMenuPrincipal.SelectedIndex = 0;
            this.tbclMenuPrincipal.Size = new System.Drawing.Size(530, 259);
            this.tbclMenuPrincipal.TabIndex = 0;
            // 
            // tbUsuario
            // 
            this.tbUsuario.Controls.Add(this.lblAcesoUsuario);
            this.tbUsuario.Controls.Add(this.btnGestionarUsuarios);
            this.tbUsuario.Location = new System.Drawing.Point(4, 22);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tbUsuario.Size = new System.Drawing.Size(522, 233);
            this.tbUsuario.TabIndex = 0;
            this.tbUsuario.Text = "Usuario";
            this.tbUsuario.UseVisualStyleBackColor = true;
            // 
            // lblAcesoUsuario
            // 
            this.lblAcesoUsuario.AutoSize = true;
            this.lblAcesoUsuario.Location = new System.Drawing.Point(190, 12);
            this.lblAcesoUsuario.Name = "lblAcesoUsuario";
            this.lblAcesoUsuario.Size = new System.Drawing.Size(0, 13);
            this.lblAcesoUsuario.TabIndex = 4;
            // 
            // btnGestionarUsuarios
            // 
            this.btnGestionarUsuarios.Location = new System.Drawing.Point(174, 88);
            this.btnGestionarUsuarios.Name = "btnGestionarUsuarios";
            this.btnGestionarUsuarios.Size = new System.Drawing.Size(175, 57);
            this.btnGestionarUsuarios.TabIndex = 3;
            this.btnGestionarUsuarios.Text = "Gestionar Usuarios";
            this.btnGestionarUsuarios.UseVisualStyleBackColor = true;
            this.btnGestionarUsuarios.Click += new System.EventHandler(this.btnGestionarUsuarios_Click);
            // 
            // tbInquilino
            // 
            this.tbInquilino.Controls.Add(this.btnAltaInquilino);
            this.tbInquilino.Location = new System.Drawing.Point(4, 22);
            this.tbInquilino.Name = "tbInquilino";
            this.tbInquilino.Padding = new System.Windows.Forms.Padding(3);
            this.tbInquilino.Size = new System.Drawing.Size(522, 233);
            this.tbInquilino.TabIndex = 1;
            this.tbInquilino.Text = "Inquilino";
            this.tbInquilino.UseVisualStyleBackColor = true;
            // 
            // btnAltaInquilino
            // 
            this.btnAltaInquilino.Location = new System.Drawing.Point(174, 88);
            this.btnAltaInquilino.Name = "btnAltaInquilino";
            this.btnAltaInquilino.Size = new System.Drawing.Size(175, 57);
            this.btnAltaInquilino.TabIndex = 0;
            this.btnAltaInquilino.Text = "Registrar Inquilino";
            this.btnAltaInquilino.UseVisualStyleBackColor = true;
            this.btnAltaInquilino.Click += new System.EventHandler(this.btnAltaInquilino_Click);
            // 
            // tbDepartamento
            // 
            this.tbDepartamento.Controls.Add(this.btnBajaDepa);
            this.tbDepartamento.Controls.Add(this.btnBuscarDepa);
            this.tbDepartamento.Controls.Add(this.btnModDepa);
            this.tbDepartamento.Controls.Add(this.btnAltaDepa);
            this.tbDepartamento.Location = new System.Drawing.Point(4, 22);
            this.tbDepartamento.Name = "tbDepartamento";
            this.tbDepartamento.Padding = new System.Windows.Forms.Padding(3);
            this.tbDepartamento.Size = new System.Drawing.Size(522, 233);
            this.tbDepartamento.TabIndex = 2;
            this.tbDepartamento.Text = "Departamento";
            this.tbDepartamento.UseVisualStyleBackColor = true;
            // 
            // btnBajaDepa
            // 
            this.btnBajaDepa.Location = new System.Drawing.Point(277, 120);
            this.btnBajaDepa.Name = "btnBajaDepa";
            this.btnBajaDepa.Size = new System.Drawing.Size(175, 57);
            this.btnBajaDepa.TabIndex = 3;
            this.btnBajaDepa.Text = "Eliminar un Departamento";
            this.btnBajaDepa.UseVisualStyleBackColor = true;
            // 
            // btnBuscarDepa
            // 
            this.btnBuscarDepa.Location = new System.Drawing.Point(70, 120);
            this.btnBuscarDepa.Name = "btnBuscarDepa";
            this.btnBuscarDepa.Size = new System.Drawing.Size(175, 57);
            this.btnBuscarDepa.TabIndex = 2;
            this.btnBuscarDepa.Text = "Buscar un Departamento";
            this.btnBuscarDepa.UseVisualStyleBackColor = true;
            // 
            // btnModDepa
            // 
            this.btnModDepa.Location = new System.Drawing.Point(277, 31);
            this.btnModDepa.Name = "btnModDepa";
            this.btnModDepa.Size = new System.Drawing.Size(175, 57);
            this.btnModDepa.TabIndex = 1;
            this.btnModDepa.Text = "Modificar un Departamento";
            this.btnModDepa.UseVisualStyleBackColor = true;
            // 
            // btnAltaDepa
            // 
            this.btnAltaDepa.Location = new System.Drawing.Point(70, 31);
            this.btnAltaDepa.Name = "btnAltaDepa";
            this.btnAltaDepa.Size = new System.Drawing.Size(175, 57);
            this.btnAltaDepa.TabIndex = 0;
            this.btnAltaDepa.Text = "Registrar Departamento";
            this.btnAltaDepa.UseVisualStyleBackColor = true;
            this.btnAltaDepa.Click += new System.EventHandler(this.btnAltaDepa_Click);
            // 
            // tbEdificio
            // 
            this.tbEdificio.Controls.Add(this.btnBajaEdificio);
            this.tbEdificio.Controls.Add(this.btnBuscarEdificio);
            this.tbEdificio.Controls.Add(this.btnModEdificio);
            this.tbEdificio.Controls.Add(this.btnAltaEdificio);
            this.tbEdificio.Location = new System.Drawing.Point(4, 22);
            this.tbEdificio.Name = "tbEdificio";
            this.tbEdificio.Padding = new System.Windows.Forms.Padding(3);
            this.tbEdificio.Size = new System.Drawing.Size(522, 233);
            this.tbEdificio.TabIndex = 3;
            this.tbEdificio.Text = "Edificio";
            this.tbEdificio.UseVisualStyleBackColor = true;
            // 
            // btnBajaEdificio
            // 
            this.btnBajaEdificio.Location = new System.Drawing.Point(277, 120);
            this.btnBajaEdificio.Name = "btnBajaEdificio";
            this.btnBajaEdificio.Size = new System.Drawing.Size(175, 57);
            this.btnBajaEdificio.TabIndex = 3;
            this.btnBajaEdificio.Text = "Eliminar un Edificio";
            this.btnBajaEdificio.UseVisualStyleBackColor = true;
            // 
            // btnBuscarEdificio
            // 
            this.btnBuscarEdificio.Location = new System.Drawing.Point(70, 120);
            this.btnBuscarEdificio.Name = "btnBuscarEdificio";
            this.btnBuscarEdificio.Size = new System.Drawing.Size(175, 57);
            this.btnBuscarEdificio.TabIndex = 2;
            this.btnBuscarEdificio.Text = "Buscar un Edificio";
            this.btnBuscarEdificio.UseVisualStyleBackColor = true;
            // 
            // btnModEdificio
            // 
            this.btnModEdificio.Location = new System.Drawing.Point(277, 31);
            this.btnModEdificio.Name = "btnModEdificio";
            this.btnModEdificio.Size = new System.Drawing.Size(175, 57);
            this.btnModEdificio.TabIndex = 1;
            this.btnModEdificio.Text = "Modificar un Edificio";
            this.btnModEdificio.UseVisualStyleBackColor = true;
            // 
            // btnAltaEdificio
            // 
            this.btnAltaEdificio.Location = new System.Drawing.Point(70, 31);
            this.btnAltaEdificio.Name = "btnAltaEdificio";
            this.btnAltaEdificio.Size = new System.Drawing.Size(175, 57);
            this.btnAltaEdificio.TabIndex = 0;
            this.btnAltaEdificio.Text = "Registrar Edificio";
            this.btnAltaEdificio.UseVisualStyleBackColor = true;
            this.btnAltaEdificio.Click += new System.EventHandler(this.btnAltaEdificio_Click);
            // 
            // tbAlquiler
            // 
            this.tbAlquiler.Controls.Add(this.btnGestionAlquiler);
            this.tbAlquiler.Location = new System.Drawing.Point(4, 22);
            this.tbAlquiler.Name = "tbAlquiler";
            this.tbAlquiler.Padding = new System.Windows.Forms.Padding(3);
            this.tbAlquiler.Size = new System.Drawing.Size(522, 233);
            this.tbAlquiler.TabIndex = 4;
            this.tbAlquiler.Text = "Alquiler";
            this.tbAlquiler.UseVisualStyleBackColor = true;
            // 
            // btnGestionAlquiler
            // 
            this.btnGestionAlquiler.Location = new System.Drawing.Point(174, 88);
            this.btnGestionAlquiler.Name = "btnGestionAlquiler";
            this.btnGestionAlquiler.Size = new System.Drawing.Size(175, 57);
            this.btnGestionAlquiler.TabIndex = 0;
            this.btnGestionAlquiler.Text = "Gestion Alquiler";
            this.btnGestionAlquiler.UseVisualStyleBackColor = true;
            this.btnGestionAlquiler.Click += new System.EventHandler(this.btnAltaAlquiler_Click);
            // 
            // lblUserlogin
            // 
            this.lblUserlogin.AutoSize = true;
            this.lblUserlogin.Location = new System.Drawing.Point(373, 279);
            this.lblUserlogin.Name = "lblUserlogin";
            this.lblUserlogin.Size = new System.Drawing.Size(0, 13);
            this.lblUserlogin.TabIndex = 4;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 310);
            this.Controls.Add(this.lblUserlogin);
            this.Controls.Add(this.tbclMenuPrincipal);
            this.Controls.Add(this.btnSalir);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tbclMenuPrincipal.ResumeLayout(false);
            this.tbUsuario.ResumeLayout(false);
            this.tbUsuario.PerformLayout();
            this.tbInquilino.ResumeLayout(false);
            this.tbDepartamento.ResumeLayout(false);
            this.tbEdificio.ResumeLayout(false);
            this.tbAlquiler.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TabControl tbclMenuPrincipal;
        private System.Windows.Forms.TabPage tbUsuario;
        private System.Windows.Forms.TabPage tbInquilino;
        private System.Windows.Forms.TabPage tbDepartamento;
        private System.Windows.Forms.TabPage tbEdificio;
        private System.Windows.Forms.TabPage tbAlquiler;
        private System.Windows.Forms.Button btnAltaInquilino;
        private System.Windows.Forms.Button btnBajaDepa;
        private System.Windows.Forms.Button btnBuscarDepa;
        private System.Windows.Forms.Button btnModDepa;
        private System.Windows.Forms.Button btnAltaDepa;
        private System.Windows.Forms.Button btnBajaEdificio;
        private System.Windows.Forms.Button btnBuscarEdificio;
        private System.Windows.Forms.Button btnModEdificio;
        private System.Windows.Forms.Button btnAltaEdificio;
        private System.Windows.Forms.Button btnGestionAlquiler;
        private System.Windows.Forms.Button btnGestionarUsuarios;
        private System.Windows.Forms.Label lblUserlogin;
        private System.Windows.Forms.Label lblAcesoUsuario;
    }
}