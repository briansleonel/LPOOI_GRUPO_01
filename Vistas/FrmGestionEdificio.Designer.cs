namespace Vistas {
    partial class FrmGestionEdificio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionEdificio));
            this.dgwEdificios = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtPatternSearch = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabNewUser = new System.Windows.Forms.TabPage();
            this.lblNuevoAdministrador = new System.Windows.Forms.Label();
            this.txtNuevoAdministrador = new System.Windows.Forms.TextBox();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.lblNuevoEdificios = new System.Windows.Forms.Label();
            this.btnAddSaveUser = new System.Windows.Forms.Button();
            this.txtNuevoNombre = new System.Windows.Forms.TextBox();
            this.lblNuevoNombre = new System.Windows.Forms.Label();
            this.txtNuevoTelefono = new System.Windows.Forms.TextBox();
            this.lblNuevoDireccion = new System.Windows.Forms.Label();
            this.txtNuevoDireccion = new System.Windows.Forms.TextBox();
            this.lblNuevoTelefono = new System.Windows.Forms.Label();
            this.tabModificar = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModificarAdministrador = new System.Windows.Forms.TextBox();
            this.btnModCancel = new System.Windows.Forms.Button();
            this.txtModificarID = new System.Windows.Forms.TextBox();
            this.lblModificarEdificio = new System.Windows.Forms.Label();
            this.btnModSave = new System.Windows.Forms.Button();
            this.txtModificarTelefono = new System.Windows.Forms.TextBox();
            this.txtModificarDireccion = new System.Windows.Forms.TextBox();
            this.lblModificarTelefono = new System.Windows.Forms.Label();
            this.lblModificarDireccion = new System.Windows.Forms.Label();
            this.txtModificarNombre = new System.Windows.Forms.TextBox();
            this.lblModificarNombre = new System.Windows.Forms.Label();
            this.tabDelete = new System.Windows.Forms.TabPage();
            this.lblEliminarAdministrador = new System.Windows.Forms.Label();
            this.txtEliminarAdministrador = new System.Windows.Forms.TextBox();
            this.txtEliminarTelefono = new System.Windows.Forms.TextBox();
            this.lblEliminarTelefono = new System.Windows.Forms.Label();
            this.btnDelCancel = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEliminarID = new System.Windows.Forms.TextBox();
            this.lblElimarEdificio = new System.Windows.Forms.Label();
            this.txtEliminarDireccion = new System.Windows.Forms.TextBox();
            this.lblEliminarDireccion = new System.Windows.Forms.Label();
            this.txtEliminarNombre = new System.Windows.Forms.TextBox();
            this.lblEliminarNombre = new System.Windows.Forms.Label();
            this.lblGestionEdificios = new System.Windows.Forms.Label();
            this.btnVolverAtras = new System.Windows.Forms.Button();
            this.gpbOperador = new System.Windows.Forms.GroupBox();
            this.lblNuevoOperador = new System.Windows.Forms.Label();
            this.lblOperador = new System.Windows.Forms.Label();
            this.pnlGestionEdificioDerecho = new System.Windows.Forms.Panel();
            this.pnlGestionEdificioSuperior = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pctGestionEdificioMaximizar = new System.Windows.Forms.PictureBox();
            this.pctGestionEdificioRestaurar = new System.Windows.Forms.PictureBox();
            this.pctGestionEdificioMinimizar = new System.Windows.Forms.PictureBox();
            this.pctGestionEdificioCerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwEdificios)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabNewUser.SuspendLayout();
            this.tabModificar.SuspendLayout();
            this.tabDelete.SuspendLayout();
            this.gpbOperador.SuspendLayout();
            this.pnlGestionEdificioDerecho.SuspendLayout();
            this.pnlGestionEdificioSuperior.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctGestionEdificioMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctGestionEdificioRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctGestionEdificioMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctGestionEdificioCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwEdificios
            // 
            this.dgwEdificios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwEdificios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwEdificios.BackgroundColor = System.Drawing.Color.White;
            this.dgwEdificios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwEdificios.Location = new System.Drawing.Point(15, 209);
            this.dgwEdificios.Margin = new System.Windows.Forms.Padding(6);
            this.dgwEdificios.Name = "dgwEdificios";
            this.dgwEdificios.Size = new System.Drawing.Size(742, 459);
            this.dgwEdificios.TabIndex = 80;
            this.dgwEdificios.CurrentCellChanged += new System.EventHandler(this.dgwUsuarios_CurrentCellChanged);
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
            this.btnSearch.Location = new System.Drawing.Point(644, 145);
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
            this.txtPatternSearch.Location = new System.Drawing.Point(15, 145);
            this.txtPatternSearch.Margin = new System.Windows.Forms.Padding(6);
            this.txtPatternSearch.Name = "txtPatternSearch";
            this.txtPatternSearch.Size = new System.Drawing.Size(617, 29);
            this.txtPatternSearch.TabIndex = 2;
            this.txtPatternSearch.Text = "Buscar por nombre edificio o dirección";
            this.txtPatternSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPatternSearch_KeyUp);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabNewUser);
            this.tabControl.Controls.Add(this.tabModificar);
            this.tabControl.Controls.Add(this.tabDelete);
            this.tabControl.Location = new System.Drawing.Point(13, 179);
            this.tabControl.Margin = new System.Windows.Forms.Padding(6);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(350, 458);
            this.tabControl.TabIndex = 11;
            // 
            // tabNewUser
            // 
            this.tabNewUser.Controls.Add(this.lblNuevoAdministrador);
            this.tabNewUser.Controls.Add(this.txtNuevoAdministrador);
            this.tabNewUser.Controls.Add(this.btnAddCancel);
            this.tabNewUser.Controls.Add(this.lblNuevoEdificios);
            this.tabNewUser.Controls.Add(this.btnAddSaveUser);
            this.tabNewUser.Controls.Add(this.txtNuevoNombre);
            this.tabNewUser.Controls.Add(this.lblNuevoNombre);
            this.tabNewUser.Controls.Add(this.txtNuevoTelefono);
            this.tabNewUser.Controls.Add(this.lblNuevoDireccion);
            this.tabNewUser.Controls.Add(this.txtNuevoDireccion);
            this.tabNewUser.Controls.Add(this.lblNuevoTelefono);
            this.tabNewUser.Location = new System.Drawing.Point(4, 22);
            this.tabNewUser.Name = "tabNewUser";
            this.tabNewUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabNewUser.Size = new System.Drawing.Size(342, 432);
            this.tabNewUser.TabIndex = 1;
            this.tabNewUser.Text = "Nuevo";
            this.tabNewUser.UseVisualStyleBackColor = true;
            // 
            // lblNuevoAdministrador
            // 
            this.lblNuevoAdministrador.AutoSize = true;
            this.lblNuevoAdministrador.Location = new System.Drawing.Point(45, 229);
            this.lblNuevoAdministrador.Name = "lblNuevoAdministrador";
            this.lblNuevoAdministrador.Size = new System.Drawing.Size(70, 13);
            this.lblNuevoAdministrador.TabIndex = 43;
            this.lblNuevoAdministrador.Text = "Administrador";
            this.lblNuevoAdministrador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNuevoAdministrador
            // 
            this.txtNuevoAdministrador.Location = new System.Drawing.Point(154, 226);
            this.txtNuevoAdministrador.Name = "txtNuevoAdministrador";
            this.txtNuevoAdministrador.Size = new System.Drawing.Size(130, 20);
            this.txtNuevoAdministrador.TabIndex = 7;
            this.txtNuevoAdministrador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarSoloNumeros_KeyPress);
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.btnAddCancel.FlatAppearance.BorderSize = 0;
            this.btnAddCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
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
            // lblNuevoEdificios
            // 
            this.lblNuevoEdificios.AutoSize = true;
            this.lblNuevoEdificios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoEdificios.Location = new System.Drawing.Point(84, 35);
            this.lblNuevoEdificios.Name = "lblNuevoEdificios";
            this.lblNuevoEdificios.Size = new System.Drawing.Size(176, 25);
            this.lblNuevoEdificios.TabIndex = 30;
            this.lblNuevoEdificios.Text = "Nuevo Edificios";
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
            this.btnAddSaveUser.TabIndex = 10;
            this.btnAddSaveUser.Text = "GUARDAR";
            this.btnAddSaveUser.UseVisualStyleBackColor = false;
            this.btnAddSaveUser.Click += new System.EventHandler(this.btnAddGuardarEdificio_Click);
            // 
            // txtNuevoNombre
            // 
            this.txtNuevoNombre.Location = new System.Drawing.Point(154, 121);
            this.txtNuevoNombre.Name = "txtNuevoNombre";
            this.txtNuevoNombre.Size = new System.Drawing.Size(130, 20);
            this.txtNuevoNombre.TabIndex = 5;
            // 
            // lblNuevoNombre
            // 
            this.lblNuevoNombre.AutoSize = true;
            this.lblNuevoNombre.Location = new System.Drawing.Point(45, 124);
            this.lblNuevoNombre.Name = "lblNuevoNombre";
            this.lblNuevoNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNuevoNombre.TabIndex = 35;
            this.lblNuevoNombre.Text = "Nombre";
            this.lblNuevoNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNuevoTelefono
            // 
            this.txtNuevoTelefono.Location = new System.Drawing.Point(154, 275);
            this.txtNuevoTelefono.Name = "txtNuevoTelefono";
            this.txtNuevoTelefono.Size = new System.Drawing.Size(130, 20);
            this.txtNuevoTelefono.TabIndex = 8;
            this.txtNuevoTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarSoloNumeros_KeyPress);
            // 
            // lblNuevoDireccion
            // 
            this.lblNuevoDireccion.AutoSize = true;
            this.lblNuevoDireccion.Location = new System.Drawing.Point(45, 176);
            this.lblNuevoDireccion.Name = "lblNuevoDireccion";
            this.lblNuevoDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblNuevoDireccion.TabIndex = 36;
            this.lblNuevoDireccion.Text = "Direccion";
            this.lblNuevoDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNuevoDireccion
            // 
            this.txtNuevoDireccion.Location = new System.Drawing.Point(154, 173);
            this.txtNuevoDireccion.Name = "txtNuevoDireccion";
            this.txtNuevoDireccion.Size = new System.Drawing.Size(130, 20);
            this.txtNuevoDireccion.TabIndex = 6;
            // 
            // lblNuevoTelefono
            // 
            this.lblNuevoTelefono.AutoSize = true;
            this.lblNuevoTelefono.Location = new System.Drawing.Point(45, 278);
            this.lblNuevoTelefono.Name = "lblNuevoTelefono";
            this.lblNuevoTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblNuevoTelefono.TabIndex = 38;
            this.lblNuevoTelefono.Text = "Telefono";
            // 
            // tabModificar
            // 
            this.tabModificar.Controls.Add(this.label3);
            this.tabModificar.Controls.Add(this.txtModificarAdministrador);
            this.tabModificar.Controls.Add(this.btnModCancel);
            this.tabModificar.Controls.Add(this.txtModificarID);
            this.tabModificar.Controls.Add(this.lblModificarEdificio);
            this.tabModificar.Controls.Add(this.btnModSave);
            this.tabModificar.Controls.Add(this.txtModificarTelefono);
            this.tabModificar.Controls.Add(this.txtModificarDireccion);
            this.tabModificar.Controls.Add(this.lblModificarTelefono);
            this.tabModificar.Controls.Add(this.lblModificarDireccion);
            this.tabModificar.Controls.Add(this.txtModificarNombre);
            this.tabModificar.Controls.Add(this.lblModificarNombre);
            this.tabModificar.Location = new System.Drawing.Point(4, 22);
            this.tabModificar.Name = "tabModificar";
            this.tabModificar.Padding = new System.Windows.Forms.Padding(3);
            this.tabModificar.Size = new System.Drawing.Size(342, 432);
            this.tabModificar.TabIndex = 2;
            this.tabModificar.Text = "Modificar";
            this.tabModificar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Administrador";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtModificarAdministrador
            // 
            this.txtModificarAdministrador.Location = new System.Drawing.Point(154, 226);
            this.txtModificarAdministrador.Name = "txtModificarAdministrador";
            this.txtModificarAdministrador.Size = new System.Drawing.Size(130, 20);
            this.txtModificarAdministrador.TabIndex = 14;
            this.txtModificarAdministrador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarSoloNumeros_KeyPress);
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
            this.btnModCancel.TabIndex = 16;
            this.btnModCancel.Text = "CANCELAR";
            this.btnModCancel.UseVisualStyleBackColor = false;
            this.btnModCancel.Click += new System.EventHandler(this.btnModCancel_Click);
            // 
            // txtModificarID
            // 
            this.txtModificarID.Enabled = false;
            this.txtModificarID.Location = new System.Drawing.Point(14, 40);
            this.txtModificarID.Name = "txtModificarID";
            this.txtModificarID.Size = new System.Drawing.Size(49, 20);
            this.txtModificarID.TabIndex = 40;
            this.txtModificarID.Visible = false;
            // 
            // lblModificarEdificio
            // 
            this.lblModificarEdificio.AutoSize = true;
            this.lblModificarEdificio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarEdificio.Location = new System.Drawing.Point(69, 35);
            this.lblModificarEdificio.Name = "lblModificarEdificio";
            this.lblModificarEdificio.Size = new System.Drawing.Size(194, 25);
            this.lblModificarEdificio.TabIndex = 30;
            this.lblModificarEdificio.Text = "Modificar Edificio";
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
            this.btnModSave.TabIndex = 17;
            this.btnModSave.Text = "GUARDAR CAMBIOS";
            this.btnModSave.UseVisualStyleBackColor = false;
            this.btnModSave.Click += new System.EventHandler(this.btnModSave_Click);
            // 
            // txtModificarTelefono
            // 
            this.txtModificarTelefono.Location = new System.Drawing.Point(154, 275);
            this.txtModificarTelefono.Name = "txtModificarTelefono";
            this.txtModificarTelefono.Size = new System.Drawing.Size(130, 20);
            this.txtModificarTelefono.TabIndex = 15;
            this.txtModificarTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarSoloNumeros_KeyPress);
            // 
            // txtModificarDireccion
            // 
            this.txtModificarDireccion.Location = new System.Drawing.Point(154, 173);
            this.txtModificarDireccion.Name = "txtModificarDireccion";
            this.txtModificarDireccion.Size = new System.Drawing.Size(130, 20);
            this.txtModificarDireccion.TabIndex = 13;
            // 
            // lblModificarTelefono
            // 
            this.lblModificarTelefono.AutoSize = true;
            this.lblModificarTelefono.Location = new System.Drawing.Point(45, 278);
            this.lblModificarTelefono.Name = "lblModificarTelefono";
            this.lblModificarTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblModificarTelefono.TabIndex = 37;
            this.lblModificarTelefono.Text = "Telefono";
            // 
            // lblModificarDireccion
            // 
            this.lblModificarDireccion.AutoSize = true;
            this.lblModificarDireccion.Location = new System.Drawing.Point(45, 176);
            this.lblModificarDireccion.Name = "lblModificarDireccion";
            this.lblModificarDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblModificarDireccion.TabIndex = 35;
            this.lblModificarDireccion.Text = "Direccion";
            this.lblModificarDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtModificarNombre
            // 
            this.txtModificarNombre.Location = new System.Drawing.Point(154, 121);
            this.txtModificarNombre.Name = "txtModificarNombre";
            this.txtModificarNombre.Size = new System.Drawing.Size(130, 20);
            this.txtModificarNombre.TabIndex = 12;
            // 
            // lblModificarNombre
            // 
            this.lblModificarNombre.AutoSize = true;
            this.lblModificarNombre.Location = new System.Drawing.Point(45, 124);
            this.lblModificarNombre.Name = "lblModificarNombre";
            this.lblModificarNombre.Size = new System.Drawing.Size(44, 13);
            this.lblModificarNombre.TabIndex = 34;
            this.lblModificarNombre.Text = "Nombre";
            this.lblModificarNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabDelete
            // 
            this.tabDelete.Controls.Add(this.lblEliminarAdministrador);
            this.tabDelete.Controls.Add(this.txtEliminarAdministrador);
            this.tabDelete.Controls.Add(this.txtEliminarTelefono);
            this.tabDelete.Controls.Add(this.lblEliminarTelefono);
            this.tabDelete.Controls.Add(this.btnDelCancel);
            this.tabDelete.Controls.Add(this.btnDeleteUser);
            this.tabDelete.Controls.Add(this.label2);
            this.tabDelete.Controls.Add(this.txtEliminarID);
            this.tabDelete.Controls.Add(this.lblElimarEdificio);
            this.tabDelete.Controls.Add(this.txtEliminarDireccion);
            this.tabDelete.Controls.Add(this.lblEliminarDireccion);
            this.tabDelete.Controls.Add(this.txtEliminarNombre);
            this.tabDelete.Controls.Add(this.lblEliminarNombre);
            this.tabDelete.Location = new System.Drawing.Point(4, 22);
            this.tabDelete.Name = "tabDelete";
            this.tabDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tabDelete.Size = new System.Drawing.Size(342, 432);
            this.tabDelete.TabIndex = 3;
            this.tabDelete.Text = "Eliminar";
            this.tabDelete.UseVisualStyleBackColor = true;
            // 
            // lblEliminarAdministrador
            // 
            this.lblEliminarAdministrador.AutoSize = true;
            this.lblEliminarAdministrador.Location = new System.Drawing.Point(52, 252);
            this.lblEliminarAdministrador.Name = "lblEliminarAdministrador";
            this.lblEliminarAdministrador.Size = new System.Drawing.Size(70, 13);
            this.lblEliminarAdministrador.TabIndex = 62;
            this.lblEliminarAdministrador.Text = "Administrador";
            this.lblEliminarAdministrador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEliminarAdministrador
            // 
            this.txtEliminarAdministrador.Enabled = false;
            this.txtEliminarAdministrador.Location = new System.Drawing.Point(161, 249);
            this.txtEliminarAdministrador.Name = "txtEliminarAdministrador";
            this.txtEliminarAdministrador.Size = new System.Drawing.Size(130, 20);
            this.txtEliminarAdministrador.TabIndex = 61;
            // 
            // txtEliminarTelefono
            // 
            this.txtEliminarTelefono.Enabled = false;
            this.txtEliminarTelefono.Location = new System.Drawing.Point(161, 288);
            this.txtEliminarTelefono.Name = "txtEliminarTelefono";
            this.txtEliminarTelefono.Size = new System.Drawing.Size(130, 20);
            this.txtEliminarTelefono.TabIndex = 59;
            // 
            // lblEliminarTelefono
            // 
            this.lblEliminarTelefono.AutoSize = true;
            this.lblEliminarTelefono.Location = new System.Drawing.Point(52, 291);
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
            this.btnDeleteUser.Click += new System.EventHandler(this.btnEliminarEdificio_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "ID";
            // 
            // txtEliminarID
            // 
            this.txtEliminarID.Enabled = false;
            this.txtEliminarID.Location = new System.Drawing.Point(161, 116);
            this.txtEliminarID.Name = "txtEliminarID";
            this.txtEliminarID.Size = new System.Drawing.Size(130, 20);
            this.txtEliminarID.TabIndex = 55;
            // 
            // lblElimarEdificio
            // 
            this.lblElimarEdificio.AutoSize = true;
            this.lblElimarEdificio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElimarEdificio.Location = new System.Drawing.Point(75, 34);
            this.lblElimarEdificio.Name = "lblElimarEdificio";
            this.lblElimarEdificio.Size = new System.Drawing.Size(182, 25);
            this.lblElimarEdificio.TabIndex = 45;
            this.lblElimarEdificio.Text = "Eliminar Edificio";
            // 
            // txtEliminarDireccion
            // 
            this.txtEliminarDireccion.Enabled = false;
            this.txtEliminarDireccion.Location = new System.Drawing.Point(161, 204);
            this.txtEliminarDireccion.Name = "txtEliminarDireccion";
            this.txtEliminarDireccion.Size = new System.Drawing.Size(130, 20);
            this.txtEliminarDireccion.TabIndex = 47;
            // 
            // lblEliminarDireccion
            // 
            this.lblEliminarDireccion.AutoSize = true;
            this.lblEliminarDireccion.Location = new System.Drawing.Point(52, 207);
            this.lblEliminarDireccion.Name = "lblEliminarDireccion";
            this.lblEliminarDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblEliminarDireccion.TabIndex = 52;
            this.lblEliminarDireccion.Text = "Direccion";
            // 
            // txtEliminarNombre
            // 
            this.txtEliminarNombre.Enabled = false;
            this.txtEliminarNombre.Location = new System.Drawing.Point(161, 160);
            this.txtEliminarNombre.Name = "txtEliminarNombre";
            this.txtEliminarNombre.Size = new System.Drawing.Size(130, 20);
            this.txtEliminarNombre.TabIndex = 43;
            // 
            // lblEliminarNombre
            // 
            this.lblEliminarNombre.AutoSize = true;
            this.lblEliminarNombre.Location = new System.Drawing.Point(52, 163);
            this.lblEliminarNombre.Name = "lblEliminarNombre";
            this.lblEliminarNombre.Size = new System.Drawing.Size(44, 13);
            this.lblEliminarNombre.TabIndex = 49;
            this.lblEliminarNombre.Text = "Nombre";
            this.lblEliminarNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGestionEdificios
            // 
            this.lblGestionEdificios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGestionEdificios.AutoSize = true;
            this.lblGestionEdificios.BackColor = System.Drawing.Color.Transparent;
            this.lblGestionEdificios.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionEdificios.Location = new System.Drawing.Point(273, 59);
            this.lblGestionEdificios.Margin = new System.Windows.Forms.Padding(10);
            this.lblGestionEdificios.Name = "lblGestionEdificios";
            this.lblGestionEdificios.Size = new System.Drawing.Size(384, 42);
            this.lblGestionEdificios.TabIndex = 6;
            this.lblGestionEdificios.Text = "Gestionar Edificios";
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
            this.gpbOperador.Location = new System.Drawing.Point(106, 31);
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
            // pnlGestionEdificioDerecho
            // 
            this.pnlGestionEdificioDerecho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(85)))), ((int)(((byte)(93)))));
            this.pnlGestionEdificioDerecho.Controls.Add(this.gpbOperador);
            this.pnlGestionEdificioDerecho.Controls.Add(this.tabControl);
            this.pnlGestionEdificioDerecho.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlGestionEdificioDerecho.Location = new System.Drawing.Point(766, 30);
            this.pnlGestionEdificioDerecho.Name = "pnlGestionEdificioDerecho";
            this.pnlGestionEdificioDerecho.Size = new System.Drawing.Size(374, 653);
            this.pnlGestionEdificioDerecho.TabIndex = 52;
            // 
            // pnlGestionEdificioSuperior
            // 
            this.pnlGestionEdificioSuperior.Controls.Add(this.panel1);
            this.pnlGestionEdificioSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGestionEdificioSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlGestionEdificioSuperior.Name = "pnlGestionEdificioSuperior";
            this.pnlGestionEdificioSuperior.Size = new System.Drawing.Size(1140, 30);
            this.pnlGestionEdificioSuperior.TabIndex = 53;
            this.pnlGestionEdificioSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(85)))), ((int)(((byte)(93)))));
            this.panel1.Controls.Add(this.pctGestionEdificioMaximizar);
            this.panel1.Controls.Add(this.pctGestionEdificioRestaurar);
            this.panel1.Controls.Add(this.pctGestionEdificioMinimizar);
            this.panel1.Controls.Add(this.pctGestionEdificioCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(766, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 30);
            this.panel1.TabIndex = 54;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // pctGestionEdificioMaximizar
            // 
            this.pctGestionEdificioMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctGestionEdificioMaximizar.Image = global::Vistas.Properties.Resources.maxi;
            this.pctGestionEdificioMaximizar.Location = new System.Drawing.Point(241, 0);
            this.pctGestionEdificioMaximizar.Name = "pctGestionEdificioMaximizar";
            this.pctGestionEdificioMaximizar.Size = new System.Drawing.Size(28, 28);
            this.pctGestionEdificioMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctGestionEdificioMaximizar.TabIndex = 57;
            this.pctGestionEdificioMaximizar.TabStop = false;
            this.pctGestionEdificioMaximizar.Click += new System.EventHandler(this.pctGestionEdificiomaximizae_Click);
            // 
            // pctGestionEdificioRestaurar
            // 
            this.pctGestionEdificioRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctGestionEdificioRestaurar.Image = global::Vistas.Properties.Resources.res;
            this.pctGestionEdificioRestaurar.Location = new System.Drawing.Point(241, 0);
            this.pctGestionEdificioRestaurar.Name = "pctGestionEdificioRestaurar";
            this.pctGestionEdificioRestaurar.Size = new System.Drawing.Size(28, 28);
            this.pctGestionEdificioRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctGestionEdificioRestaurar.TabIndex = 56;
            this.pctGestionEdificioRestaurar.TabStop = false;
            this.pctGestionEdificioRestaurar.Visible = false;
            this.pctGestionEdificioRestaurar.Click += new System.EventHandler(this.pctGestionEdificioRestaurar_Click);
            // 
            // pctGestionEdificioMinimizar
            // 
            this.pctGestionEdificioMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctGestionEdificioMinimizar.Image = global::Vistas.Properties.Resources.minimazar;
            this.pctGestionEdificioMinimizar.Location = new System.Drawing.Point(291, 0);
            this.pctGestionEdificioMinimizar.Name = "pctGestionEdificioMinimizar";
            this.pctGestionEdificioMinimizar.Size = new System.Drawing.Size(28, 28);
            this.pctGestionEdificioMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctGestionEdificioMinimizar.TabIndex = 55;
            this.pctGestionEdificioMinimizar.TabStop = false;
            this.pctGestionEdificioMinimizar.Click += new System.EventHandler(this.pctGestionEdificioMinimizar_Click);
            // 
            // pctGestionEdificioCerrar
            // 
            this.pctGestionEdificioCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctGestionEdificioCerrar.Image = global::Vistas.Properties.Resources.cerrar;
            this.pctGestionEdificioCerrar.Location = new System.Drawing.Point(341, 0);
            this.pctGestionEdificioCerrar.Name = "pctGestionEdificioCerrar";
            this.pctGestionEdificioCerrar.Size = new System.Drawing.Size(28, 28);
            this.pctGestionEdificioCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctGestionEdificioCerrar.TabIndex = 54;
            this.pctGestionEdificioCerrar.TabStop = false;
            this.pctGestionEdificioCerrar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmGestionEdificio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1140, 683);
            this.ControlBox = false;
            this.Controls.Add(this.pnlGestionEdificioDerecho);
            this.Controls.Add(this.pnlGestionEdificioSuperior);
            this.Controls.Add(this.btnVolverAtras);
            this.Controls.Add(this.lblGestionEdificios);
            this.Controls.Add(this.txtPatternSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgwEdificios);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGestionEdificio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmGestionEdificio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwEdificios)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabNewUser.ResumeLayout(false);
            this.tabNewUser.PerformLayout();
            this.tabModificar.ResumeLayout(false);
            this.tabModificar.PerformLayout();
            this.tabDelete.ResumeLayout(false);
            this.tabDelete.PerformLayout();
            this.gpbOperador.ResumeLayout(false);
            this.gpbOperador.PerformLayout();
            this.pnlGestionEdificioDerecho.ResumeLayout(false);
            this.pnlGestionEdificioDerecho.PerformLayout();
            this.pnlGestionEdificioSuperior.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctGestionEdificioMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctGestionEdificioRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctGestionEdificioMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctGestionEdificioCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwEdificios;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtPatternSearch;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabNewUser;
        private System.Windows.Forms.TabPage tabModificar;
        private System.Windows.Forms.Button btnAddSaveUser;
        private System.Windows.Forms.TextBox txtNuevoNombre;
        private System.Windows.Forms.Label lblNuevoNombre;
        private System.Windows.Forms.TextBox txtNuevoTelefono;
        private System.Windows.Forms.Label lblNuevoDireccion;
        private System.Windows.Forms.TextBox txtNuevoDireccion;
        private System.Windows.Forms.Label lblNuevoTelefono;
        private System.Windows.Forms.Button btnModSave;
        private System.Windows.Forms.TextBox txtModificarTelefono;
        private System.Windows.Forms.TextBox txtModificarDireccion;
        private System.Windows.Forms.Label lblModificarTelefono;
        private System.Windows.Forms.Label lblModificarDireccion;
        private System.Windows.Forms.TextBox txtModificarNombre;
        private System.Windows.Forms.Label lblModificarNombre;
        private System.Windows.Forms.Label lblNuevoEdificios;
        private System.Windows.Forms.Label lblModificarEdificio;
        private System.Windows.Forms.TextBox txtModificarID;
        private System.Windows.Forms.Button btnModCancel;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.TabPage tabDelete;
        private System.Windows.Forms.Button btnDelCancel;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEliminarID;
        private System.Windows.Forms.Label lblElimarEdificio;
        private System.Windows.Forms.TextBox txtEliminarDireccion;
        private System.Windows.Forms.Label lblEliminarDireccion;
        private System.Windows.Forms.TextBox txtEliminarNombre;
        private System.Windows.Forms.Label lblEliminarNombre;
        private System.Windows.Forms.Label lblGestionEdificios;
        private System.Windows.Forms.Button btnVolverAtras;
        private System.Windows.Forms.TextBox txtEliminarTelefono;
        private System.Windows.Forms.Label lblEliminarTelefono;
        private System.Windows.Forms.GroupBox gpbOperador;
        private System.Windows.Forms.Label lblNuevoOperador;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.Label lblNuevoAdministrador;
        private System.Windows.Forms.TextBox txtNuevoAdministrador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtModificarAdministrador;
        private System.Windows.Forms.Label lblEliminarAdministrador;
        private System.Windows.Forms.TextBox txtEliminarAdministrador;
        private System.Windows.Forms.Panel pnlGestionEdificioDerecho;
        private System.Windows.Forms.Panel pnlGestionEdificioSuperior;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pctGestionEdificioCerrar;
        private System.Windows.Forms.PictureBox pctGestionEdificioMinimizar;
        private System.Windows.Forms.PictureBox pctGestionEdificioRestaurar;
        private System.Windows.Forms.PictureBox pctGestionEdificioMaximizar;
    }
}