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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edificiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeEdificiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inquilinosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alquilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tbclMenuPrincipal = new System.Windows.Forms.TabControl();
            this.tbUsuario = new System.Windows.Forms.TabPage();
            this.btnBajaUsuario = new System.Windows.Forms.Button();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.btnModUsuario = new System.Windows.Forms.Button();
            this.btnAltaUsuario = new System.Windows.Forms.Button();
            this.tbInquilino = new System.Windows.Forms.TabPage();
            this.btnBajaInquilino = new System.Windows.Forms.Button();
            this.btnBuscarInquilino = new System.Windows.Forms.Button();
            this.btnModInquilino = new System.Windows.Forms.Button();
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
            this.btnBajaAlquiler = new System.Windows.Forms.Button();
            this.btnBuscarAlquiler = new System.Windows.Forms.Button();
            this.btnModAlquiler = new System.Windows.Forms.Button();
            this.btnAltaAlquiler = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tbclMenuPrincipal.SuspendLayout();
            this.tbUsuario.SuspendLayout();
            this.tbInquilino.SuspendLayout();
            this.tbDepartamento.SuspendLayout();
            this.tbEdificio.SuspendLayout();
            this.tbAlquiler.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.edificiosToolStripMenuItem,
            this.inquilinosToolStripMenuItem,
            this.departamentosToolStripMenuItem,
            this.alquilerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(526, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // edificiosToolStripMenuItem
            // 
            this.edificiosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDeEdificiosToolStripMenuItem});
            this.edificiosToolStripMenuItem.Name = "edificiosToolStripMenuItem";
            this.edificiosToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.edificiosToolStripMenuItem.Text = "Edificios";
            // 
            // altaDeEdificiosToolStripMenuItem
            // 
            this.altaDeEdificiosToolStripMenuItem.Name = "altaDeEdificiosToolStripMenuItem";
            this.altaDeEdificiosToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.altaDeEdificiosToolStripMenuItem.Text = "Alta de Edificios";
            this.altaDeEdificiosToolStripMenuItem.Click += new System.EventHandler(this.altaDeEdificiosToolStripMenuItem_Click);
            // 
            // inquilinosToolStripMenuItem
            // 
            this.inquilinosToolStripMenuItem.Name = "inquilinosToolStripMenuItem";
            this.inquilinosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.inquilinosToolStripMenuItem.Text = "Inquilinos";
            // 
            // departamentosToolStripMenuItem
            // 
            this.departamentosToolStripMenuItem.Name = "departamentosToolStripMenuItem";
            this.departamentosToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.departamentosToolStripMenuItem.Text = "Departamentos";
            // 
            // alquilerToolStripMenuItem
            // 
            this.alquilerToolStripMenuItem.Name = "alquilerToolStripMenuItem";
            this.alquilerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.alquilerToolStripMenuItem.Text = "Alquiler";
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
            this.tbclMenuPrincipal.Location = new System.Drawing.Point(0, 27);
            this.tbclMenuPrincipal.Name = "tbclMenuPrincipal";
            this.tbclMenuPrincipal.SelectedIndex = 0;
            this.tbclMenuPrincipal.Size = new System.Drawing.Size(530, 235);
            this.tbclMenuPrincipal.TabIndex = 3;
            // 
            // tbUsuario
            // 
            this.tbUsuario.Controls.Add(this.btnBajaUsuario);
            this.tbUsuario.Controls.Add(this.btnBuscarUsuario);
            this.tbUsuario.Controls.Add(this.btnModUsuario);
            this.tbUsuario.Controls.Add(this.btnAltaUsuario);
            this.tbUsuario.Location = new System.Drawing.Point(4, 22);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tbUsuario.Size = new System.Drawing.Size(522, 209);
            this.tbUsuario.TabIndex = 0;
            this.tbUsuario.Text = "Usuario";
            this.tbUsuario.UseVisualStyleBackColor = true;
            // 
            // btnBajaUsuario
            // 
            this.btnBajaUsuario.Location = new System.Drawing.Point(277, 120);
            this.btnBajaUsuario.Name = "btnBajaUsuario";
            this.btnBajaUsuario.Size = new System.Drawing.Size(175, 57);
            this.btnBajaUsuario.TabIndex = 6;
            this.btnBajaUsuario.Text = "Eliminar un Usuario";
            this.btnBajaUsuario.UseVisualStyleBackColor = true;
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.Location = new System.Drawing.Point(70, 120);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(175, 57);
            this.btnBuscarUsuario.TabIndex = 5;
            this.btnBuscarUsuario.Text = "Buscar un Usuario";
            this.btnBuscarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnModUsuario
            // 
            this.btnModUsuario.Location = new System.Drawing.Point(277, 31);
            this.btnModUsuario.Name = "btnModUsuario";
            this.btnModUsuario.Size = new System.Drawing.Size(175, 57);
            this.btnModUsuario.TabIndex = 4;
            this.btnModUsuario.Text = "Modificar un Usuario";
            this.btnModUsuario.UseVisualStyleBackColor = true;
            // 
            // btnAltaUsuario
            // 
            this.btnAltaUsuario.Location = new System.Drawing.Point(70, 31);
            this.btnAltaUsuario.Name = "btnAltaUsuario";
            this.btnAltaUsuario.Size = new System.Drawing.Size(175, 57);
            this.btnAltaUsuario.TabIndex = 3;
            this.btnAltaUsuario.Text = "Registrar Usuario";
            this.btnAltaUsuario.UseVisualStyleBackColor = true;
            // 
            // tbInquilino
            // 
            this.tbInquilino.Controls.Add(this.btnBajaInquilino);
            this.tbInquilino.Controls.Add(this.btnBuscarInquilino);
            this.tbInquilino.Controls.Add(this.btnModInquilino);
            this.tbInquilino.Controls.Add(this.btnAltaInquilino);
            this.tbInquilino.Location = new System.Drawing.Point(4, 22);
            this.tbInquilino.Name = "tbInquilino";
            this.tbInquilino.Padding = new System.Windows.Forms.Padding(3);
            this.tbInquilino.Size = new System.Drawing.Size(522, 209);
            this.tbInquilino.TabIndex = 1;
            this.tbInquilino.Text = "Inquilino";
            this.tbInquilino.UseVisualStyleBackColor = true;
            // 
            // btnBajaInquilino
            // 
            this.btnBajaInquilino.Location = new System.Drawing.Point(277, 120);
            this.btnBajaInquilino.Name = "btnBajaInquilino";
            this.btnBajaInquilino.Size = new System.Drawing.Size(175, 57);
            this.btnBajaInquilino.TabIndex = 3;
            this.btnBajaInquilino.Text = "Eliminar un Inquilino";
            this.btnBajaInquilino.UseVisualStyleBackColor = true;
            // 
            // btnBuscarInquilino
            // 
            this.btnBuscarInquilino.Location = new System.Drawing.Point(70, 120);
            this.btnBuscarInquilino.Name = "btnBuscarInquilino";
            this.btnBuscarInquilino.Size = new System.Drawing.Size(175, 57);
            this.btnBuscarInquilino.TabIndex = 2;
            this.btnBuscarInquilino.Text = "Buscar un Inquilino";
            this.btnBuscarInquilino.UseVisualStyleBackColor = true;
            // 
            // btnModInquilino
            // 
            this.btnModInquilino.Location = new System.Drawing.Point(277, 31);
            this.btnModInquilino.Name = "btnModInquilino";
            this.btnModInquilino.Size = new System.Drawing.Size(175, 57);
            this.btnModInquilino.TabIndex = 1;
            this.btnModInquilino.Text = "Modificar un Inquilino";
            this.btnModInquilino.UseVisualStyleBackColor = true;
            // 
            // btnAltaInquilino
            // 
            this.btnAltaInquilino.Location = new System.Drawing.Point(70, 31);
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
            this.tbDepartamento.Size = new System.Drawing.Size(522, 209);
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
            this.tbEdificio.Size = new System.Drawing.Size(522, 209);
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
            this.tbAlquiler.Controls.Add(this.btnBajaAlquiler);
            this.tbAlquiler.Controls.Add(this.btnBuscarAlquiler);
            this.tbAlquiler.Controls.Add(this.btnModAlquiler);
            this.tbAlquiler.Controls.Add(this.btnAltaAlquiler);
            this.tbAlquiler.Location = new System.Drawing.Point(4, 22);
            this.tbAlquiler.Name = "tbAlquiler";
            this.tbAlquiler.Padding = new System.Windows.Forms.Padding(3);
            this.tbAlquiler.Size = new System.Drawing.Size(522, 209);
            this.tbAlquiler.TabIndex = 4;
            this.tbAlquiler.Text = "Alquiler";
            this.tbAlquiler.UseVisualStyleBackColor = true;
            // 
            // btnBajaAlquiler
            // 
            this.btnBajaAlquiler.Location = new System.Drawing.Point(277, 121);
            this.btnBajaAlquiler.Name = "btnBajaAlquiler";
            this.btnBajaAlquiler.Size = new System.Drawing.Size(175, 57);
            this.btnBajaAlquiler.TabIndex = 3;
            this.btnBajaAlquiler.Text = "Eliminar un Alquiler";
            this.btnBajaAlquiler.UseVisualStyleBackColor = true;
            // 
            // btnBuscarAlquiler
            // 
            this.btnBuscarAlquiler.Location = new System.Drawing.Point(70, 120);
            this.btnBuscarAlquiler.Name = "btnBuscarAlquiler";
            this.btnBuscarAlquiler.Size = new System.Drawing.Size(175, 58);
            this.btnBuscarAlquiler.TabIndex = 2;
            this.btnBuscarAlquiler.Text = "Buscar un Alquiler";
            this.btnBuscarAlquiler.UseVisualStyleBackColor = true;
            // 
            // btnModAlquiler
            // 
            this.btnModAlquiler.Location = new System.Drawing.Point(277, 31);
            this.btnModAlquiler.Name = "btnModAlquiler";
            this.btnModAlquiler.Size = new System.Drawing.Size(175, 57);
            this.btnModAlquiler.TabIndex = 1;
            this.btnModAlquiler.Text = "Modificar Alquiler";
            this.btnModAlquiler.UseVisualStyleBackColor = true;
            // 
            // btnAltaAlquiler
            // 
            this.btnAltaAlquiler.Location = new System.Drawing.Point(70, 31);
            this.btnAltaAlquiler.Name = "btnAltaAlquiler";
            this.btnAltaAlquiler.Size = new System.Drawing.Size(175, 57);
            this.btnAltaAlquiler.TabIndex = 0;
            this.btnAltaAlquiler.Text = "Registrar Alquiler";
            this.btnAltaAlquiler.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 310);
            this.Controls.Add(this.tbclMenuPrincipal);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnSalir);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tbclMenuPrincipal.ResumeLayout(false);
            this.tbUsuario.ResumeLayout(false);
            this.tbInquilino.ResumeLayout(false);
            this.tbDepartamento.ResumeLayout(false);
            this.tbEdificio.ResumeLayout(false);
            this.tbAlquiler.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edificiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDeEdificiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inquilinosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alquilerToolStripMenuItem;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TabControl tbclMenuPrincipal;
        private System.Windows.Forms.TabPage tbUsuario;
        private System.Windows.Forms.TabPage tbInquilino;
        private System.Windows.Forms.Button btnBajaUsuario;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.Button btnModUsuario;
        private System.Windows.Forms.Button btnAltaUsuario;
        private System.Windows.Forms.TabPage tbDepartamento;
        private System.Windows.Forms.TabPage tbEdificio;
        private System.Windows.Forms.TabPage tbAlquiler;
        private System.Windows.Forms.Button btnBajaInquilino;
        private System.Windows.Forms.Button btnBuscarInquilino;
        private System.Windows.Forms.Button btnModInquilino;
        private System.Windows.Forms.Button btnAltaInquilino;
        private System.Windows.Forms.Button btnBajaDepa;
        private System.Windows.Forms.Button btnBuscarDepa;
        private System.Windows.Forms.Button btnModDepa;
        private System.Windows.Forms.Button btnAltaDepa;
        private System.Windows.Forms.Button btnBajaEdificio;
        private System.Windows.Forms.Button btnBuscarEdificio;
        private System.Windows.Forms.Button btnModEdificio;
        private System.Windows.Forms.Button btnAltaEdificio;
        private System.Windows.Forms.Button btnBajaAlquiler;
        private System.Windows.Forms.Button btnBuscarAlquiler;
        private System.Windows.Forms.Button btnModAlquiler;
        private System.Windows.Forms.Button btnAltaAlquiler;
    }
}