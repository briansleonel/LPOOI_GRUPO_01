namespace Vistas {
    partial class frmGestionInquilino
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionInquilino));
            this.dgwInquilinos = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtPatternSearch = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabNewUser = new System.Windows.Forms.TabPage();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.lblNuevoInquilino = new System.Windows.Forms.Label();
            this.btnAddSaveUser = new System.Windows.Forms.Button();
            this.txtNuevoApellido = new System.Windows.Forms.TextBox();
            this.lblNuevoApellido = new System.Windows.Forms.Label();
            this.txtNuevoTelefono = new System.Windows.Forms.TextBox();
            this.lblNuevoNombre = new System.Windows.Forms.Label();
            this.txtNuevoNombre = new System.Windows.Forms.TextBox();
            this.lblNuevoTelefono = new System.Windows.Forms.Label();
            this.tabModificar = new System.Windows.Forms.TabPage();
            this.btnModCancel = new System.Windows.Forms.Button();
            this.txtModificarID = new System.Windows.Forms.TextBox();
            this.lblModificarInquilino = new System.Windows.Forms.Label();
            this.btnModSave = new System.Windows.Forms.Button();
            this.txtModificarTelefono = new System.Windows.Forms.TextBox();
            this.txtModificarNombre = new System.Windows.Forms.TextBox();
            this.lblModificarTelefono = new System.Windows.Forms.Label();
            this.lblModificarNombre = new System.Windows.Forms.Label();
            this.txtModificarApellido = new System.Windows.Forms.TextBox();
            this.lblModificarApellido = new System.Windows.Forms.Label();
            this.tabDelete = new System.Windows.Forms.TabPage();
            this.txtEliminarTelefono = new System.Windows.Forms.TextBox();
            this.lblEliminarTelefono = new System.Windows.Forms.Label();
            this.btnDelCancel = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEliminarID = new System.Windows.Forms.TextBox();
            this.lblElimarInquilino = new System.Windows.Forms.Label();
            this.txtEliminarNombre = new System.Windows.Forms.TextBox();
            this.lblEliminarNombre = new System.Windows.Forms.Label();
            this.txtEliminarApellido = new System.Windows.Forms.TextBox();
            this.lblEliminarApellido = new System.Windows.Forms.Label();
            this.lblGestionInquilinos = new System.Windows.Forms.Label();
            this.btnVolverAtras = new System.Windows.Forms.Button();
            this.gpbOperador = new System.Windows.Forms.GroupBox();
            this.lblNuevoOperador = new System.Windows.Forms.Label();
            this.lblOperador = new System.Windows.Forms.Label();
            this.chkOrdenarApellido = new System.Windows.Forms.CheckBox();
            this.pnlGestionInquilinoDerecho = new System.Windows.Forms.Panel();
            this.pnlGestionInquilinoSuperior = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pctGestionInquilinoMaximizar = new System.Windows.Forms.PictureBox();
            this.pctGestionInquilinoCerrar = new System.Windows.Forms.PictureBox();
            this.pctGestionInquilinoRestaurar = new System.Windows.Forms.PictureBox();
            this.pctGestionInquilinoMinimizar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwInquilinos)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabNewUser.SuspendLayout();
            this.tabModificar.SuspendLayout();
            this.tabDelete.SuspendLayout();
            this.gpbOperador.SuspendLayout();
            this.pnlGestionInquilinoDerecho.SuspendLayout();
            this.pnlGestionInquilinoSuperior.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctGestionInquilinoMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctGestionInquilinoCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctGestionInquilinoRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctGestionInquilinoMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwInquilinos
            // 
            this.dgwInquilinos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwInquilinos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwInquilinos.BackgroundColor = System.Drawing.Color.White;
            this.dgwInquilinos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwInquilinos.Location = new System.Drawing.Point(15, 213);
            this.dgwInquilinos.Margin = new System.Windows.Forms.Padding(6);
            this.dgwInquilinos.Name = "dgwInquilinos";
            this.dgwInquilinos.Size = new System.Drawing.Size(742, 455);
            this.dgwInquilinos.TabIndex = 80;
            this.dgwInquilinos.CurrentCellChanged += new System.EventHandler(this.dgwUsuarios_CurrentCellChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(85)))), ((int)(((byte)(93)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.LightGray;
            this.btnSearch.Location = new System.Drawing.Point(644, 139);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 29);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Mostrar Todos";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtPatternSearch
            // 
            this.txtPatternSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatternSearch.ForeColor = System.Drawing.Color.DarkGray;
            this.txtPatternSearch.Location = new System.Drawing.Point(15, 139);
            this.txtPatternSearch.Margin = new System.Windows.Forms.Padding(6);
            this.txtPatternSearch.Name = "txtPatternSearch";
            this.txtPatternSearch.Size = new System.Drawing.Size(617, 29);
            this.txtPatternSearch.TabIndex = 2;
            this.txtPatternSearch.Text = "Buscar por Apellido o Nombre";
            this.txtPatternSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPatternSearch_KeyUp);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabNewUser);
            this.tabControl.Controls.Add(this.tabModificar);
            this.tabControl.Controls.Add(this.tabDelete);
            this.tabControl.Location = new System.Drawing.Point(9, 183);
            this.tabControl.Margin = new System.Windows.Forms.Padding(6);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(350, 455);
            this.tabControl.TabIndex = 11;
            // 
            // tabNewUser
            // 
            this.tabNewUser.Controls.Add(this.btnAddCancel);
            this.tabNewUser.Controls.Add(this.lblNuevoInquilino);
            this.tabNewUser.Controls.Add(this.btnAddSaveUser);
            this.tabNewUser.Controls.Add(this.txtNuevoApellido);
            this.tabNewUser.Controls.Add(this.lblNuevoApellido);
            this.tabNewUser.Controls.Add(this.txtNuevoTelefono);
            this.tabNewUser.Controls.Add(this.lblNuevoNombre);
            this.tabNewUser.Controls.Add(this.txtNuevoNombre);
            this.tabNewUser.Controls.Add(this.lblNuevoTelefono);
            this.tabNewUser.Location = new System.Drawing.Point(4, 22);
            this.tabNewUser.Name = "tabNewUser";
            this.tabNewUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabNewUser.Size = new System.Drawing.Size(342, 429);
            this.tabNewUser.TabIndex = 1;
            this.tabNewUser.Text = "Nuevo";
            this.tabNewUser.UseVisualStyleBackColor = true;
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.btnAddCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCancel.Location = new System.Drawing.Point(27, 374);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(140, 30);
            this.btnAddCancel.TabIndex = 9;
            this.btnAddCancel.Text = "CANCELAR";
            this.btnAddCancel.UseVisualStyleBackColor = false;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // lblNuevoInquilino
            // 
            this.lblNuevoInquilino.AutoSize = true;
            this.lblNuevoInquilino.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoInquilino.Location = new System.Drawing.Point(84, 35);
            this.lblNuevoInquilino.Name = "lblNuevoInquilino";
            this.lblNuevoInquilino.Size = new System.Drawing.Size(175, 25);
            this.lblNuevoInquilino.TabIndex = 30;
            this.lblNuevoInquilino.Text = "Nuevo Inquilino";
            // 
            // btnAddSaveUser
            // 
            this.btnAddSaveUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.btnAddSaveUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddSaveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSaveUser.Location = new System.Drawing.Point(175, 374);
            this.btnAddSaveUser.Name = "btnAddSaveUser";
            this.btnAddSaveUser.Size = new System.Drawing.Size(140, 30);
            this.btnAddSaveUser.TabIndex = 10;
            this.btnAddSaveUser.Text = "GUARDAR";
            this.btnAddSaveUser.UseVisualStyleBackColor = false;
            this.btnAddSaveUser.Click += new System.EventHandler(this.btnAddSaveUser_Click);
            // 
            // txtNuevoApellido
            // 
            this.txtNuevoApellido.Location = new System.Drawing.Point(155, 148);
            this.txtNuevoApellido.Name = "txtNuevoApellido";
            this.txtNuevoApellido.Size = new System.Drawing.Size(130, 20);
            this.txtNuevoApellido.TabIndex = 6;
            this.txtNuevoApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarSoloLetras_KeyPress);
            // 
            // lblNuevoApellido
            // 
            this.lblNuevoApellido.AutoSize = true;
            this.lblNuevoApellido.Location = new System.Drawing.Point(64, 151);
            this.lblNuevoApellido.Name = "lblNuevoApellido";
            this.lblNuevoApellido.Size = new System.Drawing.Size(44, 13);
            this.lblNuevoApellido.TabIndex = 35;
            this.lblNuevoApellido.Text = "Apellido";
            this.lblNuevoApellido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNuevoTelefono
            // 
            this.txtNuevoTelefono.Location = new System.Drawing.Point(155, 256);
            this.txtNuevoTelefono.Name = "txtNuevoTelefono";
            this.txtNuevoTelefono.Size = new System.Drawing.Size(130, 20);
            this.txtNuevoTelefono.TabIndex = 8;
            this.txtNuevoTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarSoloNumeros_KeyPress);
            // 
            // lblNuevoNombre
            // 
            this.lblNuevoNombre.AutoSize = true;
            this.lblNuevoNombre.Location = new System.Drawing.Point(64, 205);
            this.lblNuevoNombre.Name = "lblNuevoNombre";
            this.lblNuevoNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNuevoNombre.TabIndex = 36;
            this.lblNuevoNombre.Text = "Nombre";
            this.lblNuevoNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNuevoNombre
            // 
            this.txtNuevoNombre.Location = new System.Drawing.Point(155, 202);
            this.txtNuevoNombre.Name = "txtNuevoNombre";
            this.txtNuevoNombre.Size = new System.Drawing.Size(130, 20);
            this.txtNuevoNombre.TabIndex = 7;
            this.txtNuevoNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarSoloLetras_KeyPress);
            // 
            // lblNuevoTelefono
            // 
            this.lblNuevoTelefono.AutoSize = true;
            this.lblNuevoTelefono.Location = new System.Drawing.Point(64, 259);
            this.lblNuevoTelefono.Name = "lblNuevoTelefono";
            this.lblNuevoTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblNuevoTelefono.TabIndex = 38;
            this.lblNuevoTelefono.Text = "Telefono";
            // 
            // tabModificar
            // 
            this.tabModificar.Controls.Add(this.btnModCancel);
            this.tabModificar.Controls.Add(this.txtModificarID);
            this.tabModificar.Controls.Add(this.lblModificarInquilino);
            this.tabModificar.Controls.Add(this.btnModSave);
            this.tabModificar.Controls.Add(this.txtModificarTelefono);
            this.tabModificar.Controls.Add(this.txtModificarNombre);
            this.tabModificar.Controls.Add(this.lblModificarTelefono);
            this.tabModificar.Controls.Add(this.lblModificarNombre);
            this.tabModificar.Controls.Add(this.txtModificarApellido);
            this.tabModificar.Controls.Add(this.lblModificarApellido);
            this.tabModificar.Location = new System.Drawing.Point(4, 22);
            this.tabModificar.Name = "tabModificar";
            this.tabModificar.Padding = new System.Windows.Forms.Padding(3);
            this.tabModificar.Size = new System.Drawing.Size(342, 429);
            this.tabModificar.TabIndex = 2;
            this.tabModificar.Text = "Modificar";
            this.tabModificar.UseVisualStyleBackColor = true;
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
            this.btnModCancel.TabIndex = 15;
            this.btnModCancel.Text = "CANCELAR";
            this.btnModCancel.UseVisualStyleBackColor = false;
            this.btnModCancel.Click += new System.EventHandler(this.btnModCancel_Click);
            // 
            // txtModificarID
            // 
            this.txtModificarID.Enabled = false;
            this.txtModificarID.Location = new System.Drawing.Point(16, 41);
            this.txtModificarID.Name = "txtModificarID";
            this.txtModificarID.Size = new System.Drawing.Size(28, 20);
            this.txtModificarID.TabIndex = 40;
            this.txtModificarID.Visible = false;
            // 
            // lblModificarInquilino
            // 
            this.lblModificarInquilino.AutoSize = true;
            this.lblModificarInquilino.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarInquilino.Location = new System.Drawing.Point(69, 35);
            this.lblModificarInquilino.Name = "lblModificarInquilino";
            this.lblModificarInquilino.Size = new System.Drawing.Size(205, 25);
            this.lblModificarInquilino.TabIndex = 30;
            this.lblModificarInquilino.Text = "Modificar inquilino";
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
            this.btnModSave.TabIndex = 16;
            this.btnModSave.Text = "GUARDAR CAMBIOS";
            this.btnModSave.UseVisualStyleBackColor = false;
            this.btnModSave.Click += new System.EventHandler(this.btnModSave_Click);
            // 
            // txtModificarTelefono
            // 
            this.txtModificarTelefono.Location = new System.Drawing.Point(155, 256);
            this.txtModificarTelefono.Name = "txtModificarTelefono";
            this.txtModificarTelefono.Size = new System.Drawing.Size(130, 20);
            this.txtModificarTelefono.TabIndex = 14;
            this.txtModificarTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarSoloNumeros_KeyPress);
            // 
            // txtModificarNombre
            // 
            this.txtModificarNombre.Location = new System.Drawing.Point(155, 202);
            this.txtModificarNombre.Name = "txtModificarNombre";
            this.txtModificarNombre.Size = new System.Drawing.Size(130, 20);
            this.txtModificarNombre.TabIndex = 13;
            this.txtModificarNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarSoloLetras_KeyPress);
            // 
            // lblModificarTelefono
            // 
            this.lblModificarTelefono.AutoSize = true;
            this.lblModificarTelefono.Location = new System.Drawing.Point(64, 259);
            this.lblModificarTelefono.Name = "lblModificarTelefono";
            this.lblModificarTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblModificarTelefono.TabIndex = 37;
            this.lblModificarTelefono.Text = "Telefono";
            // 
            // lblModificarNombre
            // 
            this.lblModificarNombre.AutoSize = true;
            this.lblModificarNombre.Location = new System.Drawing.Point(64, 205);
            this.lblModificarNombre.Name = "lblModificarNombre";
            this.lblModificarNombre.Size = new System.Drawing.Size(44, 13);
            this.lblModificarNombre.TabIndex = 35;
            this.lblModificarNombre.Text = "Nombre";
            this.lblModificarNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtModificarApellido
            // 
            this.txtModificarApellido.Location = new System.Drawing.Point(155, 148);
            this.txtModificarApellido.Name = "txtModificarApellido";
            this.txtModificarApellido.Size = new System.Drawing.Size(130, 20);
            this.txtModificarApellido.TabIndex = 12;
            this.txtModificarApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarSoloLetras_KeyPress);
            // 
            // lblModificarApellido
            // 
            this.lblModificarApellido.AutoSize = true;
            this.lblModificarApellido.Location = new System.Drawing.Point(64, 151);
            this.lblModificarApellido.Name = "lblModificarApellido";
            this.lblModificarApellido.Size = new System.Drawing.Size(44, 13);
            this.lblModificarApellido.TabIndex = 34;
            this.lblModificarApellido.Text = "Apellido";
            this.lblModificarApellido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabDelete
            // 
            this.tabDelete.Controls.Add(this.txtEliminarTelefono);
            this.tabDelete.Controls.Add(this.lblEliminarTelefono);
            this.tabDelete.Controls.Add(this.btnDelCancel);
            this.tabDelete.Controls.Add(this.btnDeleteUser);
            this.tabDelete.Controls.Add(this.label2);
            this.tabDelete.Controls.Add(this.txtEliminarID);
            this.tabDelete.Controls.Add(this.lblElimarInquilino);
            this.tabDelete.Controls.Add(this.txtEliminarNombre);
            this.tabDelete.Controls.Add(this.lblEliminarNombre);
            this.tabDelete.Controls.Add(this.txtEliminarApellido);
            this.tabDelete.Controls.Add(this.lblEliminarApellido);
            this.tabDelete.Location = new System.Drawing.Point(4, 22);
            this.tabDelete.Name = "tabDelete";
            this.tabDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tabDelete.Size = new System.Drawing.Size(342, 429);
            this.tabDelete.TabIndex = 3;
            this.tabDelete.Text = "Eliminar";
            this.tabDelete.UseVisualStyleBackColor = true;
            // 
            // txtEliminarTelefono
            // 
            this.txtEliminarTelefono.Enabled = false;
            this.txtEliminarTelefono.Location = new System.Drawing.Point(159, 268);
            this.txtEliminarTelefono.Name = "txtEliminarTelefono";
            this.txtEliminarTelefono.Size = new System.Drawing.Size(130, 20);
            this.txtEliminarTelefono.TabIndex = 59;
            // 
            // lblEliminarTelefono
            // 
            this.lblEliminarTelefono.AutoSize = true;
            this.lblEliminarTelefono.Location = new System.Drawing.Point(60, 271);
            this.lblEliminarTelefono.Name = "lblEliminarTelefono";
            this.lblEliminarTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblEliminarTelefono.TabIndex = 60;
            this.lblEliminarTelefono.Text = "Telefono";
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
            this.label2.Location = new System.Drawing.Point(91, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "ID";
            // 
            // txtEliminarID
            // 
            this.txtEliminarID.Enabled = false;
            this.txtEliminarID.Location = new System.Drawing.Point(159, 136);
            this.txtEliminarID.Name = "txtEliminarID";
            this.txtEliminarID.Size = new System.Drawing.Size(130, 20);
            this.txtEliminarID.TabIndex = 55;
            // 
            // lblElimarInquilino
            // 
            this.lblElimarInquilino.AutoSize = true;
            this.lblElimarInquilino.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElimarInquilino.Location = new System.Drawing.Point(75, 34);
            this.lblElimarInquilino.Name = "lblElimarInquilino";
            this.lblElimarInquilino.Size = new System.Drawing.Size(193, 25);
            this.lblElimarInquilino.TabIndex = 45;
            this.lblElimarInquilino.Text = "Eliminar Inquilino";
            // 
            // txtEliminarNombre
            // 
            this.txtEliminarNombre.Enabled = false;
            this.txtEliminarNombre.Location = new System.Drawing.Point(159, 224);
            this.txtEliminarNombre.Name = "txtEliminarNombre";
            this.txtEliminarNombre.Size = new System.Drawing.Size(130, 20);
            this.txtEliminarNombre.TabIndex = 47;
            // 
            // lblEliminarNombre
            // 
            this.lblEliminarNombre.AutoSize = true;
            this.lblEliminarNombre.Location = new System.Drawing.Point(65, 227);
            this.lblEliminarNombre.Name = "lblEliminarNombre";
            this.lblEliminarNombre.Size = new System.Drawing.Size(44, 13);
            this.lblEliminarNombre.TabIndex = 52;
            this.lblEliminarNombre.Text = "Nombre";
            // 
            // txtEliminarApellido
            // 
            this.txtEliminarApellido.Enabled = false;
            this.txtEliminarApellido.Location = new System.Drawing.Point(159, 180);
            this.txtEliminarApellido.Name = "txtEliminarApellido";
            this.txtEliminarApellido.Size = new System.Drawing.Size(130, 20);
            this.txtEliminarApellido.TabIndex = 43;
            // 
            // lblEliminarApellido
            // 
            this.lblEliminarApellido.AutoSize = true;
            this.lblEliminarApellido.Location = new System.Drawing.Point(65, 183);
            this.lblEliminarApellido.Name = "lblEliminarApellido";
            this.lblEliminarApellido.Size = new System.Drawing.Size(44, 13);
            this.lblEliminarApellido.TabIndex = 49;
            this.lblEliminarApellido.Text = "Apellido";
            this.lblEliminarApellido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGestionInquilinos
            // 
            this.lblGestionInquilinos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGestionInquilinos.AutoSize = true;
            this.lblGestionInquilinos.BackColor = System.Drawing.Color.Transparent;
            this.lblGestionInquilinos.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionInquilinos.Location = new System.Drawing.Point(274, 59);
            this.lblGestionInquilinos.Margin = new System.Windows.Forms.Padding(10);
            this.lblGestionInquilinos.Name = "lblGestionInquilinos";
            this.lblGestionInquilinos.Size = new System.Drawing.Size(418, 42);
            this.lblGestionInquilinos.TabIndex = 6;
            this.lblGestionInquilinos.Text = "Gestionar Inquilinos";
            // 
            // btnVolverAtras
            // 
            this.btnVolverAtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(85)))), ((int)(((byte)(93)))));
            this.btnVolverAtras.FlatAppearance.BorderSize = 0;
            this.btnVolverAtras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnVolverAtras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnVolverAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverAtras.ForeColor = System.Drawing.Color.White;
            this.btnVolverAtras.Location = new System.Drawing.Point(15, 72);
            this.btnVolverAtras.Name = "btnVolverAtras";
            this.btnVolverAtras.Size = new System.Drawing.Size(150, 29);
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
            this.gpbOperador.BackColor = System.Drawing.Color.Transparent;
            this.gpbOperador.Controls.Add(this.lblNuevoOperador);
            this.gpbOperador.Controls.Add(this.lblOperador);
            this.gpbOperador.Location = new System.Drawing.Point(81, 31);
            this.gpbOperador.Name = "gpbOperador";
            this.gpbOperador.Size = new System.Drawing.Size(147, 52);
            this.gpbOperador.TabIndex = 51;
            this.gpbOperador.TabStop = false;
            // 
            // lblNuevoOperador
            // 
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
            // chkOrdenarApellido
            // 
            this.chkOrdenarApellido.AutoSize = true;
            this.chkOrdenarApellido.BackColor = System.Drawing.Color.Transparent;
            this.chkOrdenarApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.chkOrdenarApellido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkOrdenarApellido.Location = new System.Drawing.Point(586, 182);
            this.chkOrdenarApellido.Name = "chkOrdenarApellido";
            this.chkOrdenarApellido.Size = new System.Drawing.Size(171, 20);
            this.chkOrdenarApellido.TabIndex = 4;
            this.chkOrdenarApellido.Text = "Ordenar por apellido";
            this.chkOrdenarApellido.UseVisualStyleBackColor = false;
            this.chkOrdenarApellido.CheckedChanged += new System.EventHandler(this.chkOrdenarApellido_CheckedChanged);
            // 
            // pnlGestionInquilinoDerecho
            // 
            this.pnlGestionInquilinoDerecho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(85)))), ((int)(((byte)(93)))));
            this.pnlGestionInquilinoDerecho.Controls.Add(this.gpbOperador);
            this.pnlGestionInquilinoDerecho.Controls.Add(this.tabControl);
            this.pnlGestionInquilinoDerecho.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlGestionInquilinoDerecho.Location = new System.Drawing.Point(766, 30);
            this.pnlGestionInquilinoDerecho.Name = "pnlGestionInquilinoDerecho";
            this.pnlGestionInquilinoDerecho.Size = new System.Drawing.Size(374, 653);
            this.pnlGestionInquilinoDerecho.TabIndex = 53;
            // 
            // pnlGestionInquilinoSuperior
            // 
            this.pnlGestionInquilinoSuperior.BackColor = System.Drawing.Color.Transparent;
            this.pnlGestionInquilinoSuperior.Controls.Add(this.panel2);
            this.pnlGestionInquilinoSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGestionInquilinoSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlGestionInquilinoSuperior.Name = "pnlGestionInquilinoSuperior";
            this.pnlGestionInquilinoSuperior.Size = new System.Drawing.Size(1140, 30);
            this.pnlGestionInquilinoSuperior.TabIndex = 54;
            this.pnlGestionInquilinoSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(85)))), ((int)(((byte)(93)))));
            this.panel2.Controls.Add(this.pctGestionInquilinoMaximizar);
            this.panel2.Controls.Add(this.pctGestionInquilinoCerrar);
            this.panel2.Controls.Add(this.pctGestionInquilinoRestaurar);
            this.panel2.Controls.Add(this.pctGestionInquilinoMinimizar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(766, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 30);
            this.panel2.TabIndex = 55;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pctGestionInquilinoMaximizar
            // 
            this.pctGestionInquilinoMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctGestionInquilinoMaximizar.Image = global::Vistas.Properties.Resources.maxi;
            this.pctGestionInquilinoMaximizar.Location = new System.Drawing.Point(241, 0);
            this.pctGestionInquilinoMaximizar.Name = "pctGestionInquilinoMaximizar";
            this.pctGestionInquilinoMaximizar.Size = new System.Drawing.Size(28, 28);
            this.pctGestionInquilinoMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctGestionInquilinoMaximizar.TabIndex = 84;
            this.pctGestionInquilinoMaximizar.TabStop = false;
            this.pctGestionInquilinoMaximizar.Click += new System.EventHandler(this.pctGestionInquilinoMaximizar_Click);
            // 
            // pctGestionInquilinoCerrar
            // 
            this.pctGestionInquilinoCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctGestionInquilinoCerrar.Image = global::Vistas.Properties.Resources.cerrar;
            this.pctGestionInquilinoCerrar.Location = new System.Drawing.Point(341, 0);
            this.pctGestionInquilinoCerrar.Name = "pctGestionInquilinoCerrar";
            this.pctGestionInquilinoCerrar.Size = new System.Drawing.Size(28, 28);
            this.pctGestionInquilinoCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctGestionInquilinoCerrar.TabIndex = 81;
            this.pctGestionInquilinoCerrar.TabStop = false;
            this.pctGestionInquilinoCerrar.Click += new System.EventHandler(this.pctGestionInquilinoCerrar_Click);
            // 
            // pctGestionInquilinoRestaurar
            // 
            this.pctGestionInquilinoRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctGestionInquilinoRestaurar.Image = global::Vistas.Properties.Resources.res;
            this.pctGestionInquilinoRestaurar.Location = new System.Drawing.Point(241, 0);
            this.pctGestionInquilinoRestaurar.Name = "pctGestionInquilinoRestaurar";
            this.pctGestionInquilinoRestaurar.Size = new System.Drawing.Size(28, 28);
            this.pctGestionInquilinoRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctGestionInquilinoRestaurar.TabIndex = 83;
            this.pctGestionInquilinoRestaurar.TabStop = false;
            this.pctGestionInquilinoRestaurar.Visible = false;
            this.pctGestionInquilinoRestaurar.Click += new System.EventHandler(this.pctGestionInquilinoRestaurar_Click);
            // 
            // pctGestionInquilinoMinimizar
            // 
            this.pctGestionInquilinoMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctGestionInquilinoMinimizar.Image = global::Vistas.Properties.Resources.minimazar;
            this.pctGestionInquilinoMinimizar.Location = new System.Drawing.Point(291, 0);
            this.pctGestionInquilinoMinimizar.Name = "pctGestionInquilinoMinimizar";
            this.pctGestionInquilinoMinimizar.Size = new System.Drawing.Size(28, 28);
            this.pctGestionInquilinoMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctGestionInquilinoMinimizar.TabIndex = 82;
            this.pctGestionInquilinoMinimizar.TabStop = false;
            this.pctGestionInquilinoMinimizar.Click += new System.EventHandler(this.pctGestionInquilinoMinimizar_Click);
            // 
            // frmGestionInquilino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1140, 683);
            this.ControlBox = false;
            this.Controls.Add(this.pnlGestionInquilinoDerecho);
            this.Controls.Add(this.chkOrdenarApellido);
            this.Controls.Add(this.btnVolverAtras);
            this.Controls.Add(this.lblGestionInquilinos);
            this.Controls.Add(this.txtPatternSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgwInquilinos);
            this.Controls.Add(this.pnlGestionInquilinoSuperior);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGestionInquilino";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmGestionInquilino_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwInquilinos)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabNewUser.ResumeLayout(false);
            this.tabNewUser.PerformLayout();
            this.tabModificar.ResumeLayout(false);
            this.tabModificar.PerformLayout();
            this.tabDelete.ResumeLayout(false);
            this.tabDelete.PerformLayout();
            this.gpbOperador.ResumeLayout(false);
            this.gpbOperador.PerformLayout();
            this.pnlGestionInquilinoDerecho.ResumeLayout(false);
            this.pnlGestionInquilinoDerecho.PerformLayout();
            this.pnlGestionInquilinoSuperior.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctGestionInquilinoMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctGestionInquilinoCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctGestionInquilinoRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctGestionInquilinoMinimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwInquilinos;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtPatternSearch;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabNewUser;
        private System.Windows.Forms.TabPage tabModificar;
        private System.Windows.Forms.Button btnAddSaveUser;
        private System.Windows.Forms.TextBox txtNuevoApellido;
        private System.Windows.Forms.Label lblNuevoApellido;
        private System.Windows.Forms.TextBox txtNuevoTelefono;
        private System.Windows.Forms.Label lblNuevoNombre;
        private System.Windows.Forms.TextBox txtNuevoNombre;
        private System.Windows.Forms.Label lblNuevoTelefono;
        private System.Windows.Forms.Button btnModSave;
        private System.Windows.Forms.TextBox txtModificarTelefono;
        private System.Windows.Forms.TextBox txtModificarNombre;
        private System.Windows.Forms.Label lblModificarTelefono;
        private System.Windows.Forms.Label lblModificarNombre;
        private System.Windows.Forms.TextBox txtModificarApellido;
        private System.Windows.Forms.Label lblModificarApellido;
        private System.Windows.Forms.Label lblNuevoInquilino;
        private System.Windows.Forms.Label lblModificarInquilino;
        private System.Windows.Forms.TextBox txtModificarID;
        private System.Windows.Forms.Button btnModCancel;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.TabPage tabDelete;
        private System.Windows.Forms.Button btnDelCancel;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEliminarID;
        private System.Windows.Forms.Label lblElimarInquilino;
        private System.Windows.Forms.TextBox txtEliminarNombre;
        private System.Windows.Forms.Label lblEliminarNombre;
        private System.Windows.Forms.TextBox txtEliminarApellido;
        private System.Windows.Forms.Label lblEliminarApellido;
        private System.Windows.Forms.Label lblGestionInquilinos;
        private System.Windows.Forms.Button btnVolverAtras;
        private System.Windows.Forms.TextBox txtEliminarTelefono;
        private System.Windows.Forms.Label lblEliminarTelefono;
        private System.Windows.Forms.GroupBox gpbOperador;
        private System.Windows.Forms.Label lblNuevoOperador;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.CheckBox chkOrdenarApellido;
        private System.Windows.Forms.Panel pnlGestionInquilinoDerecho;
        private System.Windows.Forms.Panel pnlGestionInquilinoSuperior;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pctGestionInquilinoMaximizar;
        private System.Windows.Forms.PictureBox pctGestionInquilinoCerrar;
        private System.Windows.Forms.PictureBox pctGestionInquilinoRestaurar;
        private System.Windows.Forms.PictureBox pctGestionInquilinoMinimizar;
    }
}