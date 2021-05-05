namespace Vistas
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.btnGestionAlquiler = new System.Windows.Forms.Button();
            this.btnGestionEdificio = new System.Windows.Forms.Button();
            this.btnGestionDepartamento = new System.Windows.Forms.Button();
            this.btnGestionInquilino = new System.Windows.Forms.Button();
            this.btnGestionarUsuarios = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblPresentacion = new System.Windows.Forms.Label();
            this.lblOperador = new System.Windows.Forms.Label();
            this.pnlOperador = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlOperador.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGestionAlquiler
            // 
            this.btnGestionAlquiler.Location = new System.Drawing.Point(14, 360);
            this.btnGestionAlquiler.Name = "btnGestionAlquiler";
            this.btnGestionAlquiler.Size = new System.Drawing.Size(175, 57);
            this.btnGestionAlquiler.TabIndex = 10;
            this.btnGestionAlquiler.Text = "Gestion Alquiler";
            this.btnGestionAlquiler.UseVisualStyleBackColor = true;
            this.btnGestionAlquiler.Click += new System.EventHandler(this.btnGestionAlquiler_Click);
            // 
            // btnGestionEdificio
            // 
            this.btnGestionEdificio.Location = new System.Drawing.Point(14, 280);
            this.btnGestionEdificio.Name = "btnGestionEdificio";
            this.btnGestionEdificio.Size = new System.Drawing.Size(175, 57);
            this.btnGestionEdificio.TabIndex = 9;
            this.btnGestionEdificio.Text = "Gestión Edificio";
            this.btnGestionEdificio.UseVisualStyleBackColor = true;
            this.btnGestionEdificio.Click += new System.EventHandler(this.btnGestionEdificio_Click);
            // 
            // btnGestionDepartamento
            // 
            this.btnGestionDepartamento.Location = new System.Drawing.Point(14, 192);
            this.btnGestionDepartamento.Name = "btnGestionDepartamento";
            this.btnGestionDepartamento.Size = new System.Drawing.Size(175, 57);
            this.btnGestionDepartamento.TabIndex = 8;
            this.btnGestionDepartamento.Text = "Gestión Departamento";
            this.btnGestionDepartamento.UseVisualStyleBackColor = true;
            this.btnGestionDepartamento.Click += new System.EventHandler(this.btnAltaDepa_Click);
            // 
            // btnGestionInquilino
            // 
            this.btnGestionInquilino.Location = new System.Drawing.Point(14, 108);
            this.btnGestionInquilino.Name = "btnGestionInquilino";
            this.btnGestionInquilino.Size = new System.Drawing.Size(175, 57);
            this.btnGestionInquilino.TabIndex = 7;
            this.btnGestionInquilino.Text = "Gestión Inquilino";
            this.btnGestionInquilino.UseVisualStyleBackColor = true;
            this.btnGestionInquilino.Click += new System.EventHandler(this.btnAltaInquilino_Click);
            // 
            // btnGestionarUsuarios
            // 
            this.btnGestionarUsuarios.Location = new System.Drawing.Point(14, 24);
            this.btnGestionarUsuarios.Name = "btnGestionarUsuarios";
            this.btnGestionarUsuarios.Size = new System.Drawing.Size(175, 57);
            this.btnGestionarUsuarios.TabIndex = 7;
            this.btnGestionarUsuarios.Text = "Gestionar Usuarios";
            this.btnGestionarUsuarios.UseVisualStyleBackColor = true;
            this.btnGestionarUsuarios.Click += new System.EventHandler(this.btnGestionarUsuarios_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(329, 269);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(235, 509);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(208, 34);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblPresentacion
            // 
            this.lblPresentacion.AutoSize = true;
            this.lblPresentacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresentacion.Location = new System.Drawing.Point(3, 14);
            this.lblPresentacion.Name = "lblPresentacion";
            this.lblPresentacion.Size = new System.Drawing.Size(169, 20);
            this.lblPresentacion.TabIndex = 8;
            this.lblPresentacion.Text = "Bienvenido Usuario:";
            // 
            // lblOperador
            // 
            this.lblOperador.AutoSize = true;
            this.lblOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperador.Location = new System.Drawing.Point(19, 57);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(0, 24);
            this.lblOperador.TabIndex = 10;
            // 
            // pnlOperador
            // 
            this.pnlOperador.AutoSize = true;
            this.pnlOperador.BackColor = System.Drawing.Color.Transparent;
            this.pnlOperador.Controls.Add(this.lblOperador);
            this.pnlOperador.Controls.Add(this.lblPresentacion);
            this.pnlOperador.Location = new System.Drawing.Point(108, 33);
            this.pnlOperador.Name = "pnlOperador";
            this.pnlOperador.Size = new System.Drawing.Size(180, 100);
            this.pnlOperador.TabIndex = 10;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMenu.Controls.Add(this.btnGestionAlquiler);
            this.pnlMenu.Controls.Add(this.btnGestionarUsuarios);
            this.pnlMenu.Controls.Add(this.btnGestionEdificio);
            this.pnlMenu.Controls.Add(this.btnGestionInquilino);
            this.pnlMenu.Controls.Add(this.btnGestionDepartamento);
            this.pnlMenu.Location = new System.Drawing.Point(430, 51);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(206, 444);
            this.pnlMenu.TabIndex = 11;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Vistas.Properties.Resources.background_2344222_640;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(678, 556);
            this.ControlBox = false;
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlOperador);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlOperador.ResumeLayout(false);
            this.pnlOperador.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGestionarUsuarios;
        private System.Windows.Forms.Button btnGestionInquilino;
        private System.Windows.Forms.Button btnGestionDepartamento;
        private System.Windows.Forms.Button btnGestionEdificio;
        private System.Windows.Forms.Button btnGestionAlquiler;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblPresentacion;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.Panel pnlOperador;
        private System.Windows.Forms.Panel pnlMenu;
    }
}