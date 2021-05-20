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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionUsuario));
            this.dgwUsuarios = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtPatternSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnVolverAtras = new System.Windows.Forms.Button();
            this.gpbOperador = new System.Windows.Forms.GroupBox();
            this.lblNuevoOperador = new System.Windows.Forms.Label();
            this.lblOperador = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabNewUser = new System.Windows.Forms.TabPage();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.btnAddSaveUser = new System.Windows.Forms.Button();
            this.txtAddUsername = new System.Windows.Forms.TextBox();
            this.txtAddFullname = new System.Windows.Forms.TextBox();
            this.cmbAddRol = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAddRepeatPassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAddPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabModificar = new System.Windows.Forms.TabPage();
            this.pnlModificarContrasenia = new System.Windows.Forms.Panel();
            this.txtModRepeatPassword = new System.Windows.Forms.TextBox();
            this.txtModPasswrod = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnModCancel = new System.Windows.Forms.Button();
            this.txtModId = new System.Windows.Forms.TextBox();
            this.txtModFullname = new System.Windows.Forms.TextBox();
            this.txtModUsername = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnModSave = new System.Windows.Forms.Button();
            this.cmbModRol = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tabDelete = new System.Windows.Forms.TabPage();
            this.txtEliminarRol = new System.Windows.Forms.TextBox();
            this.txtDelId = new System.Windows.Forms.TextBox();
            this.txtDelFullname = new System.Windows.Forms.TextBox();
            this.txtDelUsername = new System.Windows.Forms.TextBox();
            this.btnDelCancel = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.pnlGestionUsuarioSuperior = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pctGestionUsuarioMaximizar = new System.Windows.Forms.PictureBox();
            this.pctGestionUsuarioCerrar = new System.Windows.Forms.PictureBox();
            this.pctGestionUsuarioRestaurar = new System.Windows.Forms.PictureBox();
            this.pctGestionUsuarioMinimizar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsuarios)).BeginInit();
            this.gpbOperador.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabNewUser.SuspendLayout();
            this.tabModificar.SuspendLayout();
            this.pnlModificarContrasenia.SuspendLayout();
            this.tabDelete.SuspendLayout();
            this.pnlGestionUsuarioSuperior.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctGestionUsuarioMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctGestionUsuarioCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctGestionUsuarioRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctGestionUsuarioMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwUsuarios
            // 
            this.dgwUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dgwUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUsuarios.Location = new System.Drawing.Point(15, 220);
            this.dgwUsuarios.Margin = new System.Windows.Forms.Padding(6);
            this.dgwUsuarios.Name = "dgwUsuarios";
            this.dgwUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwUsuarios.Size = new System.Drawing.Size(741, 448);
            this.dgwUsuarios.TabIndex = 80;
            this.dgwUsuarios.CurrentCellChanged += new System.EventHandler(this.dgwUsuarios_CurrentCellChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(85)))), ((int)(((byte)(93)))));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.LightGray;
            this.btnSearch.Location = new System.Drawing.Point(606, 163);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 30);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Mostrar Todo";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtPatternSearch
            // 
            this.txtPatternSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatternSearch.ForeColor = System.Drawing.Color.LightGray;
            this.txtPatternSearch.Location = new System.Drawing.Point(15, 163);
            this.txtPatternSearch.Margin = new System.Windows.Forms.Padding(6);
            this.txtPatternSearch.Name = "txtPatternSearch";
            this.txtPatternSearch.Size = new System.Drawing.Size(570, 29);
            this.txtPatternSearch.TabIndex = 2;
            this.txtPatternSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPatternSearch_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(297, 64);
            this.label6.Margin = new System.Windows.Forms.Padding(10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(390, 42);
            this.label6.TabIndex = 6;
            this.label6.Text = "Gestionar Usuarios";
            // 
            // btnVolverAtras
            // 
            this.btnVolverAtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(85)))), ((int)(((byte)(93)))));
            this.btnVolverAtras.FlatAppearance.BorderSize = 0;
            this.btnVolverAtras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnVolverAtras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnVolverAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverAtras.ForeColor = System.Drawing.Color.White;
            this.btnVolverAtras.Location = new System.Drawing.Point(15, 77);
            this.btnVolverAtras.Name = "btnVolverAtras";
            this.btnVolverAtras.Size = new System.Drawing.Size(150, 30);
            this.btnVolverAtras.TabIndex = 1;
            this.btnVolverAtras.Text = "VOLVER ATRÁS";
            this.btnVolverAtras.UseVisualStyleBackColor = false;
            this.btnVolverAtras.Click += new System.EventHandler(this.btnVolverAtras_Click);
            // 
            // gpbOperador
            // 
            this.gpbOperador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbOperador.AutoSize = true;
            this.gpbOperador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(85)))), ((int)(((byte)(93)))));
            this.gpbOperador.Controls.Add(this.lblNuevoOperador);
            this.gpbOperador.Controls.Add(this.lblOperador);
            this.gpbOperador.Location = new System.Drawing.Point(91, 21);
            this.gpbOperador.Name = "gpbOperador";
            this.gpbOperador.Size = new System.Drawing.Size(147, 52);
            this.gpbOperador.TabIndex = 51;
            this.gpbOperador.TabStop = false;
            // 
            // lblNuevoOperador
            // 
            this.lblNuevoOperador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNuevoOperador.AutoSize = true;
            this.lblNuevoOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoOperador.ForeColor = System.Drawing.Color.LightGray;
            this.lblNuevoOperador.Location = new System.Drawing.Point(6, 20);
            this.lblNuevoOperador.Name = "lblNuevoOperador";
            this.lblNuevoOperador.Size = new System.Drawing.Size(78, 16);
            this.lblNuevoOperador.TabIndex = 42;
            this.lblNuevoOperador.Text = "Operador:";
            // 
            // lblOperador
            // 
            this.lblOperador.AutoSize = true;
            this.lblOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperador.ForeColor = System.Drawing.Color.LightGray;
            this.lblOperador.Location = new System.Drawing.Point(87, 20);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(0, 16);
            this.lblOperador.TabIndex = 49;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(85)))), ((int)(((byte)(93)))));
            this.panel2.Controls.Add(this.gpbOperador);
            this.panel2.Controls.Add(this.tabControl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(765, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 653);
            this.panel2.TabIndex = 52;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabNewUser);
            this.tabControl.Controls.Add(this.tabModificar);
            this.tabControl.Controls.Add(this.tabDelete);
            this.tabControl.Location = new System.Drawing.Point(16, 190);
            this.tabControl.Margin = new System.Windows.Forms.Padding(6);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(350, 450);
            this.tabControl.TabIndex = 12;
            // 
            // tabNewUser
            // 
            this.tabNewUser.Controls.Add(this.btnAddCancel);
            this.tabNewUser.Controls.Add(this.label17);
            this.tabNewUser.Controls.Add(this.btnAddSaveUser);
            this.tabNewUser.Controls.Add(this.txtAddUsername);
            this.tabNewUser.Controls.Add(this.txtAddFullname);
            this.tabNewUser.Controls.Add(this.cmbAddRol);
            this.tabNewUser.Controls.Add(this.label11);
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
            // btnAddCancel
            // 
            this.btnAddCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.btnAddCancel.FlatAppearance.BorderSize = 0;
            this.btnAddCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAddCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCancel.ForeColor = System.Drawing.Color.Black;
            this.btnAddCancel.Location = new System.Drawing.Point(27, 374);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(140, 30);
            this.btnAddCancel.TabIndex = 10;
            this.btnAddCancel.Text = "LIMPIAR DATOS";
            this.btnAddCancel.UseVisualStyleBackColor = false;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
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
            this.btnAddSaveUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.btnAddSaveUser.FlatAppearance.BorderSize = 0;
            this.btnAddSaveUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAddSaveUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddSaveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSaveUser.Location = new System.Drawing.Point(175, 374);
            this.btnAddSaveUser.Name = "btnAddSaveUser";
            this.btnAddSaveUser.Size = new System.Drawing.Size(140, 30);
            this.btnAddSaveUser.TabIndex = 11;
            this.btnAddSaveUser.Text = "GUARDAR";
            this.btnAddSaveUser.UseVisualStyleBackColor = false;
            this.btnAddSaveUser.Click += new System.EventHandler(this.btnAddSaveUser_Click);
            // 
            // txtAddUsername
            // 
            this.txtAddUsername.Location = new System.Drawing.Point(164, 108);
            this.txtAddUsername.Name = "txtAddUsername";
            this.txtAddUsername.Size = new System.Drawing.Size(130, 20);
            this.txtAddUsername.TabIndex = 5;
            // 
            // txtAddFullname
            // 
            this.txtAddFullname.Location = new System.Drawing.Point(164, 240);
            this.txtAddFullname.Name = "txtAddFullname";
            this.txtAddFullname.Size = new System.Drawing.Size(130, 20);
            this.txtAddFullname.TabIndex = 8;
            this.txtAddFullname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddFullname_KeyPress);
            // 
            // cmbAddRol
            // 
            this.cmbAddRol.FormattingEnabled = true;
            this.cmbAddRol.Location = new System.Drawing.Point(164, 284);
            this.cmbAddRol.Name = "cmbAddRol";
            this.cmbAddRol.Size = new System.Drawing.Size(130, 21);
            this.cmbAddRol.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(46, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Nombre Usuario";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 155);
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
            this.txtAddRepeatPassword.TabIndex = 7;
            this.txtAddRepeatPassword.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 199);
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
            this.txtAddPassword.TabIndex = 6;
            this.txtAddPassword.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Apellido y nombre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Rol";
            // 
            // tabModificar
            // 
            this.tabModificar.Controls.Add(this.pnlModificarContrasenia);
            this.tabModificar.Controls.Add(this.btnModCancel);
            this.tabModificar.Controls.Add(this.txtModId);
            this.tabModificar.Controls.Add(this.txtModFullname);
            this.tabModificar.Controls.Add(this.txtModUsername);
            this.tabModificar.Controls.Add(this.label18);
            this.tabModificar.Controls.Add(this.btnModSave);
            this.tabModificar.Controls.Add(this.cmbModRol);
            this.tabModificar.Controls.Add(this.label12);
            this.tabModificar.Controls.Add(this.label13);
            this.tabModificar.Controls.Add(this.label16);
            this.tabModificar.Location = new System.Drawing.Point(4, 22);
            this.tabModificar.Name = "tabModificar";
            this.tabModificar.Padding = new System.Windows.Forms.Padding(3);
            this.tabModificar.Size = new System.Drawing.Size(342, 424);
            this.tabModificar.TabIndex = 2;
            this.tabModificar.Text = "Modificar";
            this.tabModificar.UseVisualStyleBackColor = true;
            // 
            // pnlModificarContrasenia
            // 
            this.pnlModificarContrasenia.Controls.Add(this.txtModRepeatPassword);
            this.pnlModificarContrasenia.Controls.Add(this.txtModPasswrod);
            this.pnlModificarContrasenia.Controls.Add(this.label14);
            this.pnlModificarContrasenia.Controls.Add(this.label15);
            this.pnlModificarContrasenia.Location = new System.Drawing.Point(30, 138);
            this.pnlModificarContrasenia.Name = "pnlModificarContrasenia";
            this.pnlModificarContrasenia.Size = new System.Drawing.Size(284, 92);
            this.pnlModificarContrasenia.TabIndex = 43;
            // 
            // txtModRepeatPassword
            // 
            this.txtModRepeatPassword.Location = new System.Drawing.Point(136, 58);
            this.txtModRepeatPassword.Name = "txtModRepeatPassword";
            this.txtModRepeatPassword.Size = new System.Drawing.Size(130, 20);
            this.txtModRepeatPassword.TabIndex = 15;
            this.txtModRepeatPassword.UseSystemPasswordChar = true;
            // 
            // txtModPasswrod
            // 
            this.txtModPasswrod.Location = new System.Drawing.Point(136, 14);
            this.txtModPasswrod.Name = "txtModPasswrod";
            this.txtModPasswrod.Size = new System.Drawing.Size(130, 20);
            this.txtModPasswrod.TabIndex = 14;
            this.txtModPasswrod.UseSystemPasswordChar = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 13);
            this.label14.TabIndex = 40;
            this.label14.Text = "Repita su contraseña";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 39;
            this.label15.Text = "Contraseña";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnModCancel
            // 
            this.btnModCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.btnModCancel.FlatAppearance.BorderSize = 0;
            this.btnModCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnModCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnModCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModCancel.Location = new System.Drawing.Point(27, 374);
            this.btnModCancel.Name = "btnModCancel";
            this.btnModCancel.Size = new System.Drawing.Size(140, 30);
            this.btnModCancel.TabIndex = 18;
            this.btnModCancel.Text = "CANCELAR";
            this.btnModCancel.UseVisualStyleBackColor = false;
            this.btnModCancel.Click += new System.EventHandler(this.btnModCancel_Click);
            // 
            // txtModId
            // 
            this.txtModId.Enabled = false;
            this.txtModId.Location = new System.Drawing.Point(18, 35);
            this.txtModId.Name = "txtModId";
            this.txtModId.Size = new System.Drawing.Size(33, 20);
            this.txtModId.TabIndex = 40;
            this.txtModId.Visible = false;
            // 
            // txtModFullname
            // 
            this.txtModFullname.Location = new System.Drawing.Point(164, 240);
            this.txtModFullname.Name = "txtModFullname";
            this.txtModFullname.Size = new System.Drawing.Size(130, 20);
            this.txtModFullname.TabIndex = 16;
            this.txtModFullname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtModFullname_KeyPress);
            // 
            // txtModUsername
            // 
            this.txtModUsername.Location = new System.Drawing.Point(164, 108);
            this.txtModUsername.Name = "txtModUsername";
            this.txtModUsername.Size = new System.Drawing.Size(130, 20);
            this.txtModUsername.TabIndex = 13;
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
            this.btnModSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.btnModSave.FlatAppearance.BorderSize = 0;
            this.btnModSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnModSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnModSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModSave.Location = new System.Drawing.Point(175, 374);
            this.btnModSave.Name = "btnModSave";
            this.btnModSave.Size = new System.Drawing.Size(140, 30);
            this.btnModSave.TabIndex = 19;
            this.btnModSave.Text = "GUARDAR CAMBIOS";
            this.btnModSave.UseVisualStyleBackColor = false;
            this.btnModSave.Click += new System.EventHandler(this.btnModSave_Click);
            // 
            // cmbModRol
            // 
            this.cmbModRol.FormattingEnabled = true;
            this.cmbModRol.Location = new System.Drawing.Point(164, 284);
            this.cmbModRol.Name = "cmbModRol";
            this.cmbModRol.Size = new System.Drawing.Size(130, 21);
            this.cmbModRol.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(46, 287);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 13);
            this.label12.TabIndex = 38;
            this.label12.Text = "Rol";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(46, 243);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = "Apellido y nombre";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(46, 111);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "Nombre Usuario";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabDelete
            // 
            this.tabDelete.Controls.Add(this.txtEliminarRol);
            this.tabDelete.Controls.Add(this.txtDelId);
            this.tabDelete.Controls.Add(this.txtDelFullname);
            this.tabDelete.Controls.Add(this.txtDelUsername);
            this.tabDelete.Controls.Add(this.btnDelCancel);
            this.tabDelete.Controls.Add(this.btnDeleteUser);
            this.tabDelete.Controls.Add(this.label2);
            this.tabDelete.Controls.Add(this.label3);
            this.tabDelete.Controls.Add(this.label4);
            this.tabDelete.Controls.Add(this.label5);
            this.tabDelete.Controls.Add(this.label20);
            this.tabDelete.Location = new System.Drawing.Point(4, 22);
            this.tabDelete.Name = "tabDelete";
            this.tabDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tabDelete.Size = new System.Drawing.Size(342, 424);
            this.tabDelete.TabIndex = 3;
            this.tabDelete.Text = "Eliminar";
            this.tabDelete.UseVisualStyleBackColor = true;
            // 
            // txtEliminarRol
            // 
            this.txtEliminarRol.Enabled = false;
            this.txtEliminarRol.Location = new System.Drawing.Point(157, 235);
            this.txtEliminarRol.Name = "txtEliminarRol";
            this.txtEliminarRol.Size = new System.Drawing.Size(130, 20);
            this.txtEliminarRol.TabIndex = 59;
            // 
            // txtDelId
            // 
            this.txtDelId.Enabled = false;
            this.txtDelId.Location = new System.Drawing.Point(157, 103);
            this.txtDelId.Name = "txtDelId";
            this.txtDelId.Size = new System.Drawing.Size(130, 20);
            this.txtDelId.TabIndex = 55;
            // 
            // txtDelFullname
            // 
            this.txtDelFullname.Enabled = false;
            this.txtDelFullname.Location = new System.Drawing.Point(157, 191);
            this.txtDelFullname.Name = "txtDelFullname";
            this.txtDelFullname.Size = new System.Drawing.Size(130, 20);
            this.txtDelFullname.TabIndex = 47;
            // 
            // txtDelUsername
            // 
            this.txtDelUsername.Enabled = false;
            this.txtDelUsername.Location = new System.Drawing.Point(157, 147);
            this.txtDelUsername.Name = "txtDelUsername";
            this.txtDelUsername.Size = new System.Drawing.Size(130, 20);
            this.txtDelUsername.TabIndex = 43;
            // 
            // btnDelCancel
            // 
            this.btnDelCancel.Location = new System.Drawing.Point(43, 368);
            this.btnDelCancel.Name = "btnDelCancel";
            this.btnDelCancel.Size = new System.Drawing.Size(120, 30);
            this.btnDelCancel.TabIndex = 58;
            this.btnDelCancel.Text = "CANCELAR";
            this.btnDelCancel.UseVisualStyleBackColor = true;
            this.btnDelCancel.Click += new System.EventHandler(this.btnDelCancel_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(179, 368);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(120, 30);
            this.btnDeleteUser.TabIndex = 57;
            this.btnDeleteUser.Text = "ELIMINAR";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 25);
            this.label3.TabIndex = 45;
            this.label3.Text = "Eliminar Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "Rol";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Apellido y nombre";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(63, 150);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(83, 13);
            this.label20.TabIndex = 49;
            this.label20.Text = "Nombre Usuario";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlGestionUsuarioSuperior
            // 
            this.pnlGestionUsuarioSuperior.Controls.Add(this.panel1);
            this.pnlGestionUsuarioSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGestionUsuarioSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlGestionUsuarioSuperior.Name = "pnlGestionUsuarioSuperior";
            this.pnlGestionUsuarioSuperior.Size = new System.Drawing.Size(1140, 30);
            this.pnlGestionUsuarioSuperior.TabIndex = 53;
            this.pnlGestionUsuarioSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(85)))), ((int)(((byte)(93)))));
            this.panel1.Controls.Add(this.pctGestionUsuarioMaximizar);
            this.panel1.Controls.Add(this.pctGestionUsuarioCerrar);
            this.panel1.Controls.Add(this.pctGestionUsuarioRestaurar);
            this.panel1.Controls.Add(this.pctGestionUsuarioMinimizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(765, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 30);
            this.panel1.TabIndex = 54;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // pctGestionUsuarioMaximizar
            // 
            this.pctGestionUsuarioMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctGestionUsuarioMaximizar.Image = global::Vistas.Properties.Resources.maxi;
            this.pctGestionUsuarioMaximizar.Location = new System.Drawing.Point(241, 0);
            this.pctGestionUsuarioMaximizar.Name = "pctGestionUsuarioMaximizar";
            this.pctGestionUsuarioMaximizar.Size = new System.Drawing.Size(28, 28);
            this.pctGestionUsuarioMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctGestionUsuarioMaximizar.TabIndex = 61;
            this.pctGestionUsuarioMaximizar.TabStop = false;
            this.pctGestionUsuarioMaximizar.Click += new System.EventHandler(this.pctGestionUsuarioMaximizar_Click);
            // 
            // pctGestionUsuarioCerrar
            // 
            this.pctGestionUsuarioCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctGestionUsuarioCerrar.Image = global::Vistas.Properties.Resources.cerrar;
            this.pctGestionUsuarioCerrar.Location = new System.Drawing.Point(341, 0);
            this.pctGestionUsuarioCerrar.Name = "pctGestionUsuarioCerrar";
            this.pctGestionUsuarioCerrar.Size = new System.Drawing.Size(28, 28);
            this.pctGestionUsuarioCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctGestionUsuarioCerrar.TabIndex = 58;
            this.pctGestionUsuarioCerrar.TabStop = false;
            this.pctGestionUsuarioCerrar.Click += new System.EventHandler(this.pctGestionUsuarioCerrar_Click);
            // 
            // pctGestionUsuarioRestaurar
            // 
            this.pctGestionUsuarioRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctGestionUsuarioRestaurar.Image = global::Vistas.Properties.Resources.res;
            this.pctGestionUsuarioRestaurar.Location = new System.Drawing.Point(241, 0);
            this.pctGestionUsuarioRestaurar.Name = "pctGestionUsuarioRestaurar";
            this.pctGestionUsuarioRestaurar.Size = new System.Drawing.Size(28, 28);
            this.pctGestionUsuarioRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctGestionUsuarioRestaurar.TabIndex = 60;
            this.pctGestionUsuarioRestaurar.TabStop = false;
            this.pctGestionUsuarioRestaurar.Visible = false;
            this.pctGestionUsuarioRestaurar.Click += new System.EventHandler(this.pctGestionUsuarioRestaurar_Click);
            // 
            // pctGestionUsuarioMinimizar
            // 
            this.pctGestionUsuarioMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctGestionUsuarioMinimizar.Image = global::Vistas.Properties.Resources.minimazar;
            this.pctGestionUsuarioMinimizar.Location = new System.Drawing.Point(291, 0);
            this.pctGestionUsuarioMinimizar.Name = "pctGestionUsuarioMinimizar";
            this.pctGestionUsuarioMinimizar.Size = new System.Drawing.Size(28, 28);
            this.pctGestionUsuarioMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctGestionUsuarioMinimizar.TabIndex = 59;
            this.pctGestionUsuarioMinimizar.TabStop = false;
            this.pctGestionUsuarioMinimizar.Click += new System.EventHandler(this.pctGestionUsuarioMinimizar_Click);
            // 
            // frmGestionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1140, 683);
            this.ControlBox = false;
            this.Controls.Add(this.dgwUsuarios);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlGestionUsuarioSuperior);
            this.Controls.Add(this.btnVolverAtras);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPatternSearch);
            this.Controls.Add(this.btnSearch);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGestionUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmGestionUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsuarios)).EndInit();
            this.gpbOperador.ResumeLayout(false);
            this.gpbOperador.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabNewUser.ResumeLayout(false);
            this.tabNewUser.PerformLayout();
            this.tabModificar.ResumeLayout(false);
            this.tabModificar.PerformLayout();
            this.pnlModificarContrasenia.ResumeLayout(false);
            this.pnlModificarContrasenia.PerformLayout();
            this.tabDelete.ResumeLayout(false);
            this.tabDelete.PerformLayout();
            this.pnlGestionUsuarioSuperior.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctGestionUsuarioMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctGestionUsuarioCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctGestionUsuarioRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctGestionUsuarioMinimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwUsuarios;
        private System.Windows.Forms.TextBox txtPatternSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnVolverAtras;
        private System.Windows.Forms.GroupBox gpbOperador;
        private System.Windows.Forms.Label lblNuevoOperador;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabNewUser;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnAddSaveUser;
        private System.Windows.Forms.TextBox txtAddUsername;
        private System.Windows.Forms.TextBox txtAddFullname;
        private System.Windows.Forms.ComboBox cmbAddRol;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAddRepeatPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAddPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabModificar;
        private System.Windows.Forms.Panel pnlModificarContrasenia;
        private System.Windows.Forms.TextBox txtModRepeatPassword;
        private System.Windows.Forms.TextBox txtModPasswrod;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnModCancel;
        private System.Windows.Forms.TextBox txtModId;
        private System.Windows.Forms.TextBox txtModFullname;
        private System.Windows.Forms.TextBox txtModUsername;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnModSave;
        private System.Windows.Forms.ComboBox cmbModRol;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage tabDelete;
        private System.Windows.Forms.TextBox txtEliminarRol;
        private System.Windows.Forms.TextBox txtDelId;
        private System.Windows.Forms.TextBox txtDelFullname;
        private System.Windows.Forms.TextBox txtDelUsername;
        private System.Windows.Forms.Button btnDelCancel;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnlGestionUsuarioSuperior;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pctGestionUsuarioMaximizar;
        private System.Windows.Forms.PictureBox pctGestionUsuarioCerrar;
        private System.Windows.Forms.PictureBox pctGestionUsuarioRestaurar;
        private System.Windows.Forms.PictureBox pctGestionUsuarioMinimizar;
    }
}