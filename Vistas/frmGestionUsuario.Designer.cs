namespace Vistas {
    partial class frmGestionUsuario {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnNuevoUsuario = new System.Windows.Forms.Button();
            this.dgwUsuarios = new System.Windows.Forms.DataGridView();
            this.pnlAddUser = new System.Windows.Forms.Panel();
            this.btnSaveUser = new System.Windows.Forms.Button();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.txtApellidoNombre = new System.Windows.Forms.TextBox();
            this.txtRepeatPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsuarios)).BeginInit();
            this.pnlAddUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNuevoUsuario
            // 
            this.btnNuevoUsuario.Location = new System.Drawing.Point(432, 22);
            this.btnNuevoUsuario.Name = "btnNuevoUsuario";
            this.btnNuevoUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnNuevoUsuario.TabIndex = 0;
            this.btnNuevoUsuario.Text = "Agregar";
            this.btnNuevoUsuario.UseVisualStyleBackColor = true;
            this.btnNuevoUsuario.Click += new System.EventHandler(this.btnNuevoUsuario_Click);
            // 
            // dgwUsuarios
            // 
            this.dgwUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUsuarios.Location = new System.Drawing.Point(15, 96);
            this.dgwUsuarios.Margin = new System.Windows.Forms.Padding(6);
            this.dgwUsuarios.Name = "dgwUsuarios";
            this.dgwUsuarios.Size = new System.Drawing.Size(588, 450);
            this.dgwUsuarios.TabIndex = 1;
            // 
            // pnlAddUser
            // 
            this.pnlAddUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddUser.Controls.Add(this.label6);
            this.pnlAddUser.Controls.Add(this.btnSaveUser);
            this.pnlAddUser.Controls.Add(this.cmbRol);
            this.pnlAddUser.Controls.Add(this.txtApellidoNombre);
            this.pnlAddUser.Controls.Add(this.txtRepeatPassword);
            this.pnlAddUser.Controls.Add(this.txtPassword);
            this.pnlAddUser.Controls.Add(this.label5);
            this.pnlAddUser.Controls.Add(this.label4);
            this.pnlAddUser.Controls.Add(this.label3);
            this.pnlAddUser.Controls.Add(this.label2);
            this.pnlAddUser.Controls.Add(this.txtUsername);
            this.pnlAddUser.Controls.Add(this.label1);
            this.pnlAddUser.Location = new System.Drawing.Point(619, 96);
            this.pnlAddUser.Margin = new System.Windows.Forms.Padding(6);
            this.pnlAddUser.Name = "pnlAddUser";
            this.pnlAddUser.Size = new System.Drawing.Size(350, 400);
            this.pnlAddUser.TabIndex = 2;
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.Location = new System.Drawing.Point(115, 336);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.Size = new System.Drawing.Size(120, 30);
            this.btnSaveUser.TabIndex = 28;
            this.btnSaveUser.Text = "GUARDAR";
            this.btnSaveUser.UseVisualStyleBackColor = true;
            this.btnSaveUser.Click += new System.EventHandler(this.btnSaveUser_Click);
            // 
            // cmbRol
            // 
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(168, 264);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(130, 21);
            this.cmbRol.TabIndex = 21;
            // 
            // txtApellidoNombre
            // 
            this.txtApellidoNombre.Location = new System.Drawing.Point(168, 220);
            this.txtApellidoNombre.Name = "txtApellidoNombre";
            this.txtApellidoNombre.Size = new System.Drawing.Size(130, 20);
            this.txtApellidoNombre.TabIndex = 20;
            // 
            // txtRepeatPassword
            // 
            this.txtRepeatPassword.Location = new System.Drawing.Point(168, 176);
            this.txtRepeatPassword.Name = "txtRepeatPassword";
            this.txtRepeatPassword.Size = new System.Drawing.Size(130, 20);
            this.txtRepeatPassword.TabIndex = 19;
            this.txtRepeatPassword.UseSystemPasswordChar = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(168, 132);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(130, 20);
            this.txtPassword.TabIndex = 18;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Rol";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Apellido y nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Repita su contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Contraseña";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(168, 88);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(130, 20);
            this.txtUsername.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nombre Usuario";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(92, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 25);
            this.label6.TabIndex = 29;
            this.label6.Text = "Nuevo Usuario";
            // 
            // frmGestionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.pnlAddUser);
            this.Controls.Add(this.dgwUsuarios);
            this.Controls.Add(this.btnNuevoUsuario);
            this.Name = "frmGestionUsuario";
            this.Text = "Gestión de Usuarios";
            this.Load += new System.EventHandler(this.frmGestionUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsuarios)).EndInit();
            this.pnlAddUser.ResumeLayout(false);
            this.pnlAddUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNuevoUsuario;
        private System.Windows.Forms.DataGridView dgwUsuarios;
        private System.Windows.Forms.Panel pnlAddUser;
        private System.Windows.Forms.Button btnSaveUser;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.TextBox txtApellidoNombre;
        private System.Windows.Forms.TextBox txtRepeatPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}