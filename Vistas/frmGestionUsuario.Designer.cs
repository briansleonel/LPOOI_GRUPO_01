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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtPatternSearch = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.tabNewUser = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.btnAddSaveUser = new System.Windows.Forms.Button();
            this.txtAddUsername = new System.Windows.Forms.TextBox();
            this.cmbAddRol = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAddFullname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAddRepeatPassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAddPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabModificar = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.btnModSave = new System.Windows.Forms.Button();
            this.cmbModRol = new System.Windows.Forms.ComboBox();
            this.txtModFullname = new System.Windows.Forms.TextBox();
            this.txtModRepeatPassword = new System.Windows.Forms.TextBox();
            this.txtModPasswrod = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtModUsername = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtModId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsuarios)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabNewUser.SuspendLayout();
            this.tabModificar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNuevoUsuario
            // 
            this.btnNuevoUsuario.Location = new System.Drawing.Point(675, 28);
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
            this.dgwUsuarios.CurrentCellChanged += new System.EventHandler(this.dgwUsuarios_CurrentCellChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(453, 53);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 26);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "BUSCAR";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtPatternSearch
            // 
            this.txtPatternSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatternSearch.Location = new System.Drawing.Point(15, 55);
            this.txtPatternSearch.Margin = new System.Windows.Forms.Padding(6);
            this.txtPatternSearch.Name = "txtPatternSearch";
            this.txtPatternSearch.Size = new System.Drawing.Size(420, 24);
            this.txtPatternSearch.TabIndex = 4;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabMain);
            this.tabControl.Controls.Add(this.tabNewUser);
            this.tabControl.Controls.Add(this.tabModificar);
            this.tabControl.Location = new System.Drawing.Point(619, 96);
            this.tabControl.Margin = new System.Windows.Forms.Padding(6);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(350, 450);
            this.tabControl.TabIndex = 5;
            // 
            // tabMain
            // 
            this.tabMain.Location = new System.Drawing.Point(4, 22);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(342, 424);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Main";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // tabNewUser
            // 
            this.tabNewUser.Controls.Add(this.label17);
            this.tabNewUser.Controls.Add(this.btnAddSaveUser);
            this.tabNewUser.Controls.Add(this.txtAddUsername);
            this.tabNewUser.Controls.Add(this.cmbAddRol);
            this.tabNewUser.Controls.Add(this.label11);
            this.tabNewUser.Controls.Add(this.txtAddFullname);
            this.tabNewUser.Controls.Add(this.label10);
            this.tabNewUser.Controls.Add(this.txtAddRepeatPassword);
            this.tabNewUser.Controls.Add(this.label9);
            this.tabNewUser.Controls.Add(this.txtAddPassword);
            this.tabNewUser.Controls.Add(this.label8);
            this.tabNewUser.Controls.Add(this.label7);
            this.tabNewUser.Location = new System.Drawing.Point(4, 22);
            this.tabNewUser.Name = "tabNewUser";
            this.tabNewUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabNewUser.Size = new System.Drawing.Size(342, 424);
            this.tabNewUser.TabIndex = 1;
            this.tabNewUser.Text = "Nuevo";
            this.tabNewUser.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(88, 35);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(167, 25);
            this.label17.TabIndex = 30;
            this.label17.Text = "Nuevo Usuario";
            // 
            // btnAddSaveUser
            // 
            this.btnAddSaveUser.Location = new System.Drawing.Point(111, 356);
            this.btnAddSaveUser.Name = "btnAddSaveUser";
            this.btnAddSaveUser.Size = new System.Drawing.Size(120, 30);
            this.btnAddSaveUser.TabIndex = 40;
            this.btnAddSaveUser.Text = "GUARDAR";
            this.btnAddSaveUser.UseVisualStyleBackColor = true;
            this.btnAddSaveUser.Click += new System.EventHandler(this.btnAddSaveUser_Click);
            // 
            // txtAddUsername
            // 
            this.txtAddUsername.Location = new System.Drawing.Point(164, 108);
            this.txtAddUsername.Name = "txtAddUsername";
            this.txtAddUsername.Size = new System.Drawing.Size(130, 20);
            this.txtAddUsername.TabIndex = 30;
            // 
            // cmbAddRol
            // 
            this.cmbAddRol.FormattingEnabled = true;
            this.cmbAddRol.Location = new System.Drawing.Point(164, 284);
            this.cmbAddRol.Name = "cmbAddRol";
            this.cmbAddRol.Size = new System.Drawing.Size(130, 21);
            this.cmbAddRol.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(73, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Nombre Usuario";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAddFullname
            // 
            this.txtAddFullname.Location = new System.Drawing.Point(164, 240);
            this.txtAddFullname.Name = "txtAddFullname";
            this.txtAddFullname.Size = new System.Drawing.Size(130, 20);
            this.txtAddFullname.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(95, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Contraseña";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAddRepeatPassword
            // 
            this.txtAddRepeatPassword.Location = new System.Drawing.Point(164, 196);
            this.txtAddRepeatPassword.Name = "txtAddRepeatPassword";
            this.txtAddRepeatPassword.Size = new System.Drawing.Size(130, 20);
            this.txtAddRepeatPassword.TabIndex = 32;
            this.txtAddRepeatPassword.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Repita su contraseña";
            // 
            // txtAddPassword
            // 
            this.txtAddPassword.Location = new System.Drawing.Point(164, 152);
            this.txtAddPassword.Name = "txtAddPassword";
            this.txtAddPassword.Size = new System.Drawing.Size(130, 20);
            this.txtAddPassword.TabIndex = 31;
            this.txtAddPassword.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(66, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Apellido y nombre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(133, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Rol";
            // 
            // tabModificar
            // 
            this.tabModificar.Controls.Add(this.txtModId);
            this.tabModificar.Controls.Add(this.label18);
            this.tabModificar.Controls.Add(this.btnModSave);
            this.tabModificar.Controls.Add(this.cmbModRol);
            this.tabModificar.Controls.Add(this.txtModFullname);
            this.tabModificar.Controls.Add(this.txtModRepeatPassword);
            this.tabModificar.Controls.Add(this.txtModPasswrod);
            this.tabModificar.Controls.Add(this.label12);
            this.tabModificar.Controls.Add(this.label13);
            this.tabModificar.Controls.Add(this.label14);
            this.tabModificar.Controls.Add(this.label15);
            this.tabModificar.Controls.Add(this.txtModUsername);
            this.tabModificar.Controls.Add(this.label16);
            this.tabModificar.Location = new System.Drawing.Point(4, 22);
            this.tabModificar.Name = "tabModificar";
            this.tabModificar.Padding = new System.Windows.Forms.Padding(3);
            this.tabModificar.Size = new System.Drawing.Size(342, 424);
            this.tabModificar.TabIndex = 2;
            this.tabModificar.Text = "Modificar";
            this.tabModificar.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(73, 35);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(197, 25);
            this.label18.TabIndex = 30;
            this.label18.Text = "Modificar Usuario";
            // 
            // btnModSave
            // 
            this.btnModSave.Location = new System.Drawing.Point(101, 356);
            this.btnModSave.Name = "btnModSave";
            this.btnModSave.Size = new System.Drawing.Size(140, 30);
            this.btnModSave.TabIndex = 39;
            this.btnModSave.Text = "GUARDAR CAMBIOS";
            this.btnModSave.UseVisualStyleBackColor = true;
            this.btnModSave.Click += new System.EventHandler(this.btnModSave_Click);
            // 
            // cmbModRol
            // 
            this.cmbModRol.FormattingEnabled = true;
            this.cmbModRol.Location = new System.Drawing.Point(164, 284);
            this.cmbModRol.Name = "cmbModRol";
            this.cmbModRol.Size = new System.Drawing.Size(130, 21);
            this.cmbModRol.TabIndex = 33;
            // 
            // txtModFullname
            // 
            this.txtModFullname.Location = new System.Drawing.Point(164, 240);
            this.txtModFullname.Name = "txtModFullname";
            this.txtModFullname.Size = new System.Drawing.Size(130, 20);
            this.txtModFullname.TabIndex = 32;
            // 
            // txtModRepeatPassword
            // 
            this.txtModRepeatPassword.Location = new System.Drawing.Point(164, 196);
            this.txtModRepeatPassword.Name = "txtModRepeatPassword";
            this.txtModRepeatPassword.Size = new System.Drawing.Size(130, 20);
            this.txtModRepeatPassword.TabIndex = 31;
            this.txtModRepeatPassword.UseSystemPasswordChar = true;
            // 
            // txtModPasswrod
            // 
            this.txtModPasswrod.Location = new System.Drawing.Point(164, 152);
            this.txtModPasswrod.Name = "txtModPasswrod";
            this.txtModPasswrod.Size = new System.Drawing.Size(130, 20);
            this.txtModPasswrod.TabIndex = 30;
            this.txtModPasswrod.UseSystemPasswordChar = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(133, 287);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 13);
            this.label12.TabIndex = 38;
            this.label12.Text = "Rol";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(66, 243);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = "Apellido y nombre";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(48, 199);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 13);
            this.label14.TabIndex = 36;
            this.label14.Text = "Repita su contraseña";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(95, 155);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = "Contraseña";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtModUsername
            // 
            this.txtModUsername.Location = new System.Drawing.Point(164, 108);
            this.txtModUsername.Name = "txtModUsername";
            this.txtModUsername.Size = new System.Drawing.Size(130, 20);
            this.txtModUsername.TabIndex = 29;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(73, 111);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "Nombre Usuario";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtModId
            // 
            this.txtModId.Location = new System.Drawing.Point(164, 77);
            this.txtModId.Name = "txtModId";
            this.txtModId.Size = new System.Drawing.Size(100, 20);
            this.txtModId.TabIndex = 40;
            // 
            // frmGestionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.txtPatternSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgwUsuarios);
            this.Controls.Add(this.btnNuevoUsuario);
            this.Name = "frmGestionUsuario";
            this.Text = "Gestión de Usuarios";
            this.Load += new System.EventHandler(this.frmGestionUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsuarios)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabNewUser.ResumeLayout(false);
            this.tabNewUser.PerformLayout();
            this.tabModificar.ResumeLayout(false);
            this.tabModificar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevoUsuario;
        private System.Windows.Forms.DataGridView dgwUsuarios;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtPatternSearch;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.TabPage tabNewUser;
        private System.Windows.Forms.TabPage tabModificar;
        private System.Windows.Forms.Button btnAddSaveUser;
        private System.Windows.Forms.TextBox txtAddUsername;
        private System.Windows.Forms.ComboBox cmbAddRol;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAddFullname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAddRepeatPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAddPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnModSave;
        private System.Windows.Forms.ComboBox cmbModRol;
        private System.Windows.Forms.TextBox txtModFullname;
        private System.Windows.Forms.TextBox txtModRepeatPassword;
        private System.Windows.Forms.TextBox txtModPasswrod;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtModUsername;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtModId;
    }
}