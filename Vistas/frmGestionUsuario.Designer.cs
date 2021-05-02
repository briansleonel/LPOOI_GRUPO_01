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
            this.dgwUsuarios = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtPatternSearch = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.tabNewUser = new System.Windows.Forms.TabPage();
            this.btnAddCancel = new System.Windows.Forms.Button();
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
            this.btnModCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtModId = new System.Windows.Forms.TextBox();
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
            this.tabDelete = new System.Windows.Forms.TabPage();
            this.btnDelCancel = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDelId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDelRol = new System.Windows.Forms.ComboBox();
            this.txtDelFullname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDelUsername = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnVolverAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsuarios)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabNewUser.SuspendLayout();
            this.tabModificar.SuspendLayout();
            this.tabDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwUsuarios
            // 
            this.dgwUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUsuarios.Location = new System.Drawing.Point(15, 196);
            this.dgwUsuarios.Margin = new System.Windows.Forms.Padding(6);
            this.dgwUsuarios.Name = "dgwUsuarios";
            this.dgwUsuarios.Size = new System.Drawing.Size(588, 450);
            this.dgwUsuarios.TabIndex = 1;
            //this.dgwUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwUsuarios_CellContentClick);
            this.dgwUsuarios.CurrentCellChanged += new System.EventHandler(this.dgwUsuarios_CurrentCellChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(453, 145);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 29);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "BUSCAR";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtPatternSearch
            // 
            this.txtPatternSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatternSearch.Location = new System.Drawing.Point(15, 145);
            this.txtPatternSearch.Margin = new System.Windows.Forms.Padding(6);
            this.txtPatternSearch.Name = "txtPatternSearch";
            this.txtPatternSearch.Size = new System.Drawing.Size(420, 29);
            this.txtPatternSearch.TabIndex = 4;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabMain);
            this.tabControl.Controls.Add(this.tabNewUser);
            this.tabControl.Controls.Add(this.tabModificar);
            this.tabControl.Controls.Add(this.tabDelete);
            this.tabControl.Location = new System.Drawing.Point(619, 196);
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
            this.tabNewUser.Controls.Add(this.btnAddCancel);
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
            // btnAddCancel
            // 
            this.btnAddCancel.Location = new System.Drawing.Point(43, 367);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(120, 30);
            this.btnAddCancel.TabIndex = 41;
            this.btnAddCancel.Text = "CANCELAR";
            this.btnAddCancel.UseVisualStyleBackColor = true;
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
            this.btnAddSaveUser.Location = new System.Drawing.Point(179, 367);
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
            this.tabModificar.Controls.Add(this.btnModCancel);
            this.tabModificar.Controls.Add(this.label1);
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
            // btnModCancel
            // 
            this.btnModCancel.Location = new System.Drawing.Point(27, 374);
            this.btnModCancel.Name = "btnModCancel";
            this.btnModCancel.Size = new System.Drawing.Size(140, 30);
            this.btnModCancel.TabIndex = 42;
            this.btnModCancel.Text = "CANCELAR";
            this.btnModCancel.UseVisualStyleBackColor = true;
            this.btnModCancel.Click += new System.EventHandler(this.btnModCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "ID";
            // 
            // txtModId
            // 
            this.txtModId.Enabled = false;
            this.txtModId.Location = new System.Drawing.Point(164, 91);
            this.txtModId.Name = "txtModId";
            this.txtModId.Size = new System.Drawing.Size(130, 20);
            this.txtModId.TabIndex = 40;
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
            this.btnModSave.Location = new System.Drawing.Point(175, 374);
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
            this.cmbModRol.Location = new System.Drawing.Point(164, 312);
            this.cmbModRol.Name = "cmbModRol";
            this.cmbModRol.Size = new System.Drawing.Size(130, 21);
            this.cmbModRol.TabIndex = 33;
            // 
            // txtModFullname
            // 
            this.txtModFullname.Location = new System.Drawing.Point(164, 268);
            this.txtModFullname.Name = "txtModFullname";
            this.txtModFullname.Size = new System.Drawing.Size(130, 20);
            this.txtModFullname.TabIndex = 32;
            // 
            // txtModRepeatPassword
            // 
            this.txtModRepeatPassword.Location = new System.Drawing.Point(164, 224);
            this.txtModRepeatPassword.Name = "txtModRepeatPassword";
            this.txtModRepeatPassword.Size = new System.Drawing.Size(130, 20);
            this.txtModRepeatPassword.TabIndex = 31;
            this.txtModRepeatPassword.UseSystemPasswordChar = true;
            // 
            // txtModPasswrod
            // 
            this.txtModPasswrod.Location = new System.Drawing.Point(164, 180);
            this.txtModPasswrod.Name = "txtModPasswrod";
            this.txtModPasswrod.Size = new System.Drawing.Size(130, 20);
            this.txtModPasswrod.TabIndex = 30;
            this.txtModPasswrod.UseSystemPasswordChar = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(133, 315);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 13);
            this.label12.TabIndex = 38;
            this.label12.Text = "Rol";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(66, 271);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = "Apellido y nombre";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(48, 227);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 13);
            this.label14.TabIndex = 36;
            this.label14.Text = "Repita su contraseña";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(95, 183);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = "Contraseña";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtModUsername
            // 
            this.txtModUsername.Location = new System.Drawing.Point(164, 136);
            this.txtModUsername.Name = "txtModUsername";
            this.txtModUsername.Size = new System.Drawing.Size(130, 20);
            this.txtModUsername.TabIndex = 29;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(73, 139);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "Nombre Usuario";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabDelete
            // 
            this.tabDelete.Controls.Add(this.btnDelCancel);
            this.tabDelete.Controls.Add(this.btnDeleteUser);
            this.tabDelete.Controls.Add(this.label2);
            this.tabDelete.Controls.Add(this.txtDelId);
            this.tabDelete.Controls.Add(this.label3);
            this.tabDelete.Controls.Add(this.cmbDelRol);
            this.tabDelete.Controls.Add(this.txtDelFullname);
            this.tabDelete.Controls.Add(this.label4);
            this.tabDelete.Controls.Add(this.label5);
            this.tabDelete.Controls.Add(this.txtDelUsername);
            this.tabDelete.Controls.Add(this.label20);
            this.tabDelete.Location = new System.Drawing.Point(4, 22);
            this.tabDelete.Name = "tabDelete";
            this.tabDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tabDelete.Size = new System.Drawing.Size(342, 424);
            this.tabDelete.TabIndex = 3;
            this.tabDelete.Text = "Eliminar";
            this.tabDelete.UseVisualStyleBackColor = true;
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
            // txtDelId
            // 
            this.txtDelId.Enabled = false;
            this.txtDelId.Location = new System.Drawing.Point(157, 103);
            this.txtDelId.Name = "txtDelId";
            this.txtDelId.Size = new System.Drawing.Size(130, 20);
            this.txtDelId.TabIndex = 55;
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
            // cmbDelRol
            // 
            this.cmbDelRol.FormattingEnabled = true;
            this.cmbDelRol.Location = new System.Drawing.Point(157, 235);
            this.cmbDelRol.Name = "cmbDelRol";
            this.cmbDelRol.Size = new System.Drawing.Size(130, 21);
            this.cmbDelRol.TabIndex = 48;
            // 
            // txtDelFullname
            // 
            this.txtDelFullname.Location = new System.Drawing.Point(157, 191);
            this.txtDelFullname.Name = "txtDelFullname";
            this.txtDelFullname.Size = new System.Drawing.Size(130, 20);
            this.txtDelFullname.TabIndex = 47;
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
            // txtDelUsername
            // 
            this.txtDelUsername.Enabled = false;
            this.txtDelUsername.Location = new System.Drawing.Point(157, 147);
            this.txtDelUsername.Name = "txtDelUsername";
            this.txtDelUsername.Size = new System.Drawing.Size(130, 20);
            this.txtDelUsername.TabIndex = 43;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(297, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(390, 42);
            this.label6.TabIndex = 6;
            this.label6.Text = "Gestionar Usuarios";
            // 
            // btnVolverAtras
            // 
            this.btnVolverAtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btnVolverAtras.ForeColor = System.Drawing.Color.White;
            this.btnVolverAtras.Location = new System.Drawing.Point(815, 145);
            this.btnVolverAtras.Name = "btnVolverAtras";
            this.btnVolverAtras.Size = new System.Drawing.Size(150, 29);
            this.btnVolverAtras.TabIndex = 7;
            this.btnVolverAtras.Text = "VOLVER ATRÁS";
            this.btnVolverAtras.UseVisualStyleBackColor = false;
            this.btnVolverAtras.Click += new System.EventHandler(this.btnVolverAtras_Click);
            // 
            // frmGestionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.btnVolverAtras);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.txtPatternSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgwUsuarios);
            this.Name = "frmGestionUsuario";
            this.Text = "Gestión de Usuarios";
            this.Load += new System.EventHandler(this.frmGestionUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsuarios)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabNewUser.ResumeLayout(false);
            this.tabNewUser.PerformLayout();
            this.tabModificar.ResumeLayout(false);
            this.tabModificar.PerformLayout();
            this.tabDelete.ResumeLayout(false);
            this.tabDelete.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModCancel;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.TabPage tabDelete;
        private System.Windows.Forms.Button btnDelCancel;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDelId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDelRol;
        private System.Windows.Forms.TextBox txtDelFullname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDelUsername;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnVolverAtras;
    }
}