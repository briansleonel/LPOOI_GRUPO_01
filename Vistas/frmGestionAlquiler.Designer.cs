﻿namespace Vistas {
    partial class frmGestionAlquiler
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
            this.dgwAlquileres = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtPatternSearch = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabNewUser = new System.Windows.Forms.TabPage();
            this.dtpNuevoFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.lblNuevoFechafinal = new System.Windows.Forms.Label();
            this.dtpNuevoFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.cmbAddInquilino = new System.Windows.Forms.ComboBox();
            this.cmbAddDepartamento = new System.Windows.Forms.ComboBox();
            this.txtNuevoPrecio = new System.Windows.Forms.TextBox();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.lblNuevoAlquiler = new System.Windows.Forms.Label();
            this.btnAddSaveUser = new System.Windows.Forms.Button();
            this.cmbAddEdificio = new System.Windows.Forms.ComboBox();
            this.lblNuevoEdificio = new System.Windows.Forms.Label();
            this.lblNuevoDepartamento = new System.Windows.Forms.Label();
            this.lblNuevoInquilino = new System.Windows.Forms.Label();
            this.lblNuevoFechaInicio = new System.Windows.Forms.Label();
            this.lblNuevoPrecio = new System.Windows.Forms.Label();
            this.tabModificar = new System.Windows.Forms.TabPage();
            this.dtpModFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.lblModFechaFinal = new System.Windows.Forms.Label();
            this.dtpModFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.cmbModInquilino = new System.Windows.Forms.ComboBox();
            this.cmbModDepartamento = new System.Windows.Forms.ComboBox();
            this.txtModPrecio = new System.Windows.Forms.TextBox();
            this.cmbModEdificio = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblModFechaInicio = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnModCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtModId = new System.Windows.Forms.TextBox();
            this.lblModificarAlquiler = new System.Windows.Forms.Label();
            this.btnModSave = new System.Windows.Forms.Button();
            this.tabDelete = new System.Windows.Forms.TabPage();
            this.dtpEliminarFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.lblEliminarFechaFinal = new System.Windows.Forms.Label();
            this.dtpEliminarFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.cmbEliminarInquilino = new System.Windows.Forms.ComboBox();
            this.cmbEliminarDepartamento = new System.Windows.Forms.ComboBox();
            this.txtEliminarPrecio = new System.Windows.Forms.TextBox();
            this.cmbEliminarEdificio = new System.Windows.Forms.ComboBox();
            this.lblEliminarEdificio = new System.Windows.Forms.Label();
            this.lblEliminarDepartamento = new System.Windows.Forms.Label();
            this.lblEliminarInquilino = new System.Windows.Forms.Label();
            this.lblEliminarFechaInicio = new System.Windows.Forms.Label();
            this.lblEliminarPrecio = new System.Windows.Forms.Label();
            this.lblEliminarID = new System.Windows.Forms.Label();
            this.txtEliminarId = new System.Windows.Forms.TextBox();
            this.btnDelCancel = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.lblEliminarAlquiler = new System.Windows.Forms.Label();
            this.lblNuevoOperador = new System.Windows.Forms.Label();
            this.lblalquileres = new System.Windows.Forms.Label();
            this.btnVolverAtras = new System.Windows.Forms.Button();
            this.lblOperador = new System.Windows.Forms.Label();
            this.gpbOperador = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAlquileres)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabNewUser.SuspendLayout();
            this.tabModificar.SuspendLayout();
            this.tabDelete.SuspendLayout();
            this.gpbOperador.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwAlquileres
            // 
            this.dgwAlquileres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAlquileres.Location = new System.Drawing.Point(15, 196);
            this.dgwAlquileres.Margin = new System.Windows.Forms.Padding(6);
            this.dgwAlquileres.Name = "dgwAlquileres";
            this.dgwAlquileres.Size = new System.Drawing.Size(748, 450);
            this.dgwAlquileres.TabIndex = 1;
            this.dgwAlquileres.CurrentCellChanged += new System.EventHandler(this.dgwAlquileres_CurrentCellChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(615, 145);
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
            this.txtPatternSearch.Size = new System.Drawing.Size(588, 29);
            this.txtPatternSearch.TabIndex = 4;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabNewUser);
            this.tabControl.Controls.Add(this.tabModificar);
            this.tabControl.Controls.Add(this.tabDelete);
            this.tabControl.Location = new System.Drawing.Point(775, 196);
            this.tabControl.Margin = new System.Windows.Forms.Padding(6);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(350, 450);
            this.tabControl.TabIndex = 5;
            // 
            // tabNewUser
            // 
            this.tabNewUser.Controls.Add(this.dtpNuevoFechaFinal);
            this.tabNewUser.Controls.Add(this.lblNuevoFechafinal);
            this.tabNewUser.Controls.Add(this.dtpNuevoFechaInicio);
            this.tabNewUser.Controls.Add(this.cmbAddInquilino);
            this.tabNewUser.Controls.Add(this.cmbAddDepartamento);
            this.tabNewUser.Controls.Add(this.txtNuevoPrecio);
            this.tabNewUser.Controls.Add(this.btnAddCancel);
            this.tabNewUser.Controls.Add(this.lblNuevoAlquiler);
            this.tabNewUser.Controls.Add(this.btnAddSaveUser);
            this.tabNewUser.Controls.Add(this.cmbAddEdificio);
            this.tabNewUser.Controls.Add(this.lblNuevoEdificio);
            this.tabNewUser.Controls.Add(this.lblNuevoDepartamento);
            this.tabNewUser.Controls.Add(this.lblNuevoInquilino);
            this.tabNewUser.Controls.Add(this.lblNuevoFechaInicio);
            this.tabNewUser.Controls.Add(this.lblNuevoPrecio);
            this.tabNewUser.Location = new System.Drawing.Point(4, 22);
            this.tabNewUser.Name = "tabNewUser";
            this.tabNewUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabNewUser.Size = new System.Drawing.Size(342, 424);
            this.tabNewUser.TabIndex = 1;
            this.tabNewUser.Text = "Nuevo";
            this.tabNewUser.UseVisualStyleBackColor = true;
            // 
            // dtpNuevoFechaFinal
            // 
            this.dtpNuevoFechaFinal.Location = new System.Drawing.Point(125, 274);
            this.dtpNuevoFechaFinal.Name = "dtpNuevoFechaFinal";
            this.dtpNuevoFechaFinal.Size = new System.Drawing.Size(201, 20);
            this.dtpNuevoFechaFinal.TabIndex = 48;
            // 
            // lblNuevoFechafinal
            // 
            this.lblNuevoFechafinal.AutoSize = true;
            this.lblNuevoFechafinal.Location = new System.Drawing.Point(28, 274);
            this.lblNuevoFechafinal.Name = "lblNuevoFechafinal";
            this.lblNuevoFechafinal.Size = new System.Drawing.Size(62, 13);
            this.lblNuevoFechafinal.TabIndex = 47;
            this.lblNuevoFechafinal.Text = "Fecha Final";
            // 
            // dtpNuevoFechaInicio
            // 
            this.dtpNuevoFechaInicio.Location = new System.Drawing.Point(125, 227);
            this.dtpNuevoFechaInicio.Name = "dtpNuevoFechaInicio";
            this.dtpNuevoFechaInicio.Size = new System.Drawing.Size(201, 20);
            this.dtpNuevoFechaInicio.TabIndex = 46;
            // 
            // cmbAddInquilino
            // 
            this.cmbAddInquilino.FormattingEnabled = true;
            this.cmbAddInquilino.Location = new System.Drawing.Point(125, 179);
            this.cmbAddInquilino.Name = "cmbAddInquilino";
            this.cmbAddInquilino.Size = new System.Drawing.Size(201, 21);
            this.cmbAddInquilino.TabIndex = 45;
            this.cmbAddInquilino.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cmbAddInquilino_Format);
            // 
            // cmbAddDepartamento
            // 
            this.cmbAddDepartamento.FormattingEnabled = true;
            this.cmbAddDepartamento.Location = new System.Drawing.Point(125, 131);
            this.cmbAddDepartamento.Name = "cmbAddDepartamento";
            this.cmbAddDepartamento.Size = new System.Drawing.Size(201, 21);
            this.cmbAddDepartamento.TabIndex = 44;
            this.cmbAddDepartamento.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cmbAddDepartamento_Format);
            // 
            // txtNuevoPrecio
            // 
            this.txtNuevoPrecio.Enabled = false;
            this.txtNuevoPrecio.Location = new System.Drawing.Point(125, 321);
            this.txtNuevoPrecio.Name = "txtNuevoPrecio";
            this.txtNuevoPrecio.Size = new System.Drawing.Size(201, 20);
            this.txtNuevoPrecio.TabIndex = 43;
            this.txtNuevoPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNuevoPrecio_KeyPress);
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
            // lblNuevoAlquiler
            // 
            this.lblNuevoAlquiler.AutoSize = true;
            this.lblNuevoAlquiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoAlquiler.Location = new System.Drawing.Point(88, 21);
            this.lblNuevoAlquiler.Name = "lblNuevoAlquiler";
            this.lblNuevoAlquiler.Size = new System.Drawing.Size(166, 25);
            this.lblNuevoAlquiler.TabIndex = 30;
            this.lblNuevoAlquiler.Text = "Nuevo Alquiler";
            // 
            // btnAddSaveUser
            // 
            this.btnAddSaveUser.Location = new System.Drawing.Point(179, 367);
            this.btnAddSaveUser.Name = "btnAddSaveUser";
            this.btnAddSaveUser.Size = new System.Drawing.Size(120, 30);
            this.btnAddSaveUser.TabIndex = 40;
            this.btnAddSaveUser.Text = "GUARDAR";
            this.btnAddSaveUser.UseVisualStyleBackColor = true;
            this.btnAddSaveUser.Click += new System.EventHandler(this.btnAddSaveInquilino_Click);
            // 
            // cmbAddEdificio
            // 
            this.cmbAddEdificio.FormattingEnabled = true;
            this.cmbAddEdificio.Location = new System.Drawing.Point(125, 83);
            this.cmbAddEdificio.Name = "cmbAddEdificio";
            this.cmbAddEdificio.Size = new System.Drawing.Size(201, 21);
            this.cmbAddEdificio.TabIndex = 34;
            this.cmbAddEdificio.SelectedIndexChanged += new System.EventHandler(this.cmbAddEdificio_SelectedIndexChanged);
            // 
            // lblNuevoEdificio
            // 
            this.lblNuevoEdificio.AutoSize = true;
            this.lblNuevoEdificio.Location = new System.Drawing.Point(49, 86);
            this.lblNuevoEdificio.Name = "lblNuevoEdificio";
            this.lblNuevoEdificio.Size = new System.Drawing.Size(41, 13);
            this.lblNuevoEdificio.TabIndex = 35;
            this.lblNuevoEdificio.Text = "Edificio";
            this.lblNuevoEdificio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNuevoDepartamento
            // 
            this.lblNuevoDepartamento.AutoSize = true;
            this.lblNuevoDepartamento.Location = new System.Drawing.Point(16, 133);
            this.lblNuevoDepartamento.Name = "lblNuevoDepartamento";
            this.lblNuevoDepartamento.Size = new System.Drawing.Size(74, 13);
            this.lblNuevoDepartamento.TabIndex = 36;
            this.lblNuevoDepartamento.Text = "Departamento";
            this.lblNuevoDepartamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNuevoInquilino
            // 
            this.lblNuevoInquilino.AutoSize = true;
            this.lblNuevoInquilino.Location = new System.Drawing.Point(44, 180);
            this.lblNuevoInquilino.Name = "lblNuevoInquilino";
            this.lblNuevoInquilino.Size = new System.Drawing.Size(46, 13);
            this.lblNuevoInquilino.TabIndex = 37;
            this.lblNuevoInquilino.Text = "Inquilino";
            // 
            // lblNuevoFechaInicio
            // 
            this.lblNuevoFechaInicio.AutoSize = true;
            this.lblNuevoFechaInicio.Location = new System.Drawing.Point(27, 227);
            this.lblNuevoFechaInicio.Name = "lblNuevoFechaInicio";
            this.lblNuevoFechaInicio.Size = new System.Drawing.Size(63, 13);
            this.lblNuevoFechaInicio.TabIndex = 38;
            this.lblNuevoFechaInicio.Text = "Fecha Inico";
            // 
            // lblNuevoPrecio
            // 
            this.lblNuevoPrecio.AutoSize = true;
            this.lblNuevoPrecio.Location = new System.Drawing.Point(53, 321);
            this.lblNuevoPrecio.Name = "lblNuevoPrecio";
            this.lblNuevoPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblNuevoPrecio.TabIndex = 39;
            this.lblNuevoPrecio.Text = "Precio";
            // 
            // tabModificar
            // 
            this.tabModificar.Controls.Add(this.dtpModFechaFinal);
            this.tabModificar.Controls.Add(this.lblModFechaFinal);
            this.tabModificar.Controls.Add(this.dtpModFechaInicio);
            this.tabModificar.Controls.Add(this.cmbModInquilino);
            this.tabModificar.Controls.Add(this.cmbModDepartamento);
            this.tabModificar.Controls.Add(this.txtModPrecio);
            this.tabModificar.Controls.Add(this.cmbModEdificio);
            this.tabModificar.Controls.Add(this.label6);
            this.tabModificar.Controls.Add(this.label7);
            this.tabModificar.Controls.Add(this.label8);
            this.tabModificar.Controls.Add(this.lblModFechaInicio);
            this.tabModificar.Controls.Add(this.label10);
            this.tabModificar.Controls.Add(this.btnModCancel);
            this.tabModificar.Controls.Add(this.label1);
            this.tabModificar.Controls.Add(this.txtModId);
            this.tabModificar.Controls.Add(this.lblModificarAlquiler);
            this.tabModificar.Controls.Add(this.btnModSave);
            this.tabModificar.Location = new System.Drawing.Point(4, 22);
            this.tabModificar.Name = "tabModificar";
            this.tabModificar.Padding = new System.Windows.Forms.Padding(3);
            this.tabModificar.Size = new System.Drawing.Size(342, 424);
            this.tabModificar.TabIndex = 2;
            this.tabModificar.Text = "Modificar";
            this.tabModificar.UseVisualStyleBackColor = true;
            // 
            // dtpModFechaFinal
            // 
            this.dtpModFechaFinal.Location = new System.Drawing.Point(126, 286);
            this.dtpModFechaFinal.Name = "dtpModFechaFinal";
            this.dtpModFechaFinal.Size = new System.Drawing.Size(201, 20);
            this.dtpModFechaFinal.TabIndex = 60;
            // 
            // lblModFechaFinal
            // 
            this.lblModFechaFinal.AutoSize = true;
            this.lblModFechaFinal.Location = new System.Drawing.Point(28, 290);
            this.lblModFechaFinal.Name = "lblModFechaFinal";
            this.lblModFechaFinal.Size = new System.Drawing.Size(62, 13);
            this.lblModFechaFinal.TabIndex = 59;
            this.lblModFechaFinal.Text = "Fecha Final";
            // 
            // dtpModFechaInicio
            // 
            this.dtpModFechaInicio.Location = new System.Drawing.Point(126, 245);
            this.dtpModFechaInicio.Name = "dtpModFechaInicio";
            this.dtpModFechaInicio.Size = new System.Drawing.Size(201, 20);
            this.dtpModFechaInicio.TabIndex = 58;
            // 
            // cmbModInquilino
            // 
            this.cmbModInquilino.FormattingEnabled = true;
            this.cmbModInquilino.Location = new System.Drawing.Point(126, 203);
            this.cmbModInquilino.Name = "cmbModInquilino";
            this.cmbModInquilino.Size = new System.Drawing.Size(201, 21);
            this.cmbModInquilino.TabIndex = 57;
            this.cmbModInquilino.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cmbModInquilino_Format);
            // 
            // cmbModDepartamento
            // 
            this.cmbModDepartamento.FormattingEnabled = true;
            this.cmbModDepartamento.Location = new System.Drawing.Point(126, 161);
            this.cmbModDepartamento.Name = "cmbModDepartamento";
            this.cmbModDepartamento.Size = new System.Drawing.Size(201, 21);
            this.cmbModDepartamento.TabIndex = 56;
            this.cmbModDepartamento.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cmbModDepartamento_Format);
            // 
            // txtModPrecio
            // 
            this.txtModPrecio.Enabled = false;
            this.txtModPrecio.Location = new System.Drawing.Point(126, 327);
            this.txtModPrecio.Name = "txtModPrecio";
            this.txtModPrecio.Size = new System.Drawing.Size(201, 20);
            this.txtModPrecio.TabIndex = 55;
            // 
            // cmbModEdificio
            // 
            this.cmbModEdificio.FormattingEnabled = true;
            this.cmbModEdificio.Location = new System.Drawing.Point(126, 119);
            this.cmbModEdificio.Name = "cmbModEdificio";
            this.cmbModEdificio.Size = new System.Drawing.Size(201, 21);
            this.cmbModEdificio.TabIndex = 48;
            this.cmbModEdificio.SelectedIndexChanged += new System.EventHandler(this.cmbModEdificio_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Edificio";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Departamento";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 51;
            this.label8.Text = "Inquilino";
            // 
            // lblModFechaInicio
            // 
            this.lblModFechaInicio.AutoSize = true;
            this.lblModFechaInicio.Location = new System.Drawing.Point(25, 248);
            this.lblModFechaInicio.Name = "lblModFechaInicio";
            this.lblModFechaInicio.Size = new System.Drawing.Size(65, 13);
            this.lblModFechaInicio.TabIndex = 52;
            this.lblModFechaInicio.Text = "Fecha Inicio";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(53, 332);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 53;
            this.label10.Text = "Precio";
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
            this.label1.Location = new System.Drawing.Point(72, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "ID";
            // 
            // txtModId
            // 
            this.txtModId.Enabled = false;
            this.txtModId.Location = new System.Drawing.Point(126, 78);
            this.txtModId.Name = "txtModId";
            this.txtModId.Size = new System.Drawing.Size(201, 20);
            this.txtModId.TabIndex = 40;
            // 
            // lblModificarAlquiler
            // 
            this.lblModificarAlquiler.AutoSize = true;
            this.lblModificarAlquiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarAlquiler.Location = new System.Drawing.Point(73, 19);
            this.lblModificarAlquiler.Name = "lblModificarAlquiler";
            this.lblModificarAlquiler.Size = new System.Drawing.Size(196, 25);
            this.lblModificarAlquiler.TabIndex = 30;
            this.lblModificarAlquiler.Text = "Modificar Alquiler";
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
            // tabDelete
            // 
            this.tabDelete.Controls.Add(this.dtpEliminarFechaFinal);
            this.tabDelete.Controls.Add(this.lblEliminarFechaFinal);
            this.tabDelete.Controls.Add(this.dtpEliminarFechaInicio);
            this.tabDelete.Controls.Add(this.cmbEliminarInquilino);
            this.tabDelete.Controls.Add(this.cmbEliminarDepartamento);
            this.tabDelete.Controls.Add(this.txtEliminarPrecio);
            this.tabDelete.Controls.Add(this.cmbEliminarEdificio);
            this.tabDelete.Controls.Add(this.lblEliminarEdificio);
            this.tabDelete.Controls.Add(this.lblEliminarDepartamento);
            this.tabDelete.Controls.Add(this.lblEliminarInquilino);
            this.tabDelete.Controls.Add(this.lblEliminarFechaInicio);
            this.tabDelete.Controls.Add(this.lblEliminarPrecio);
            this.tabDelete.Controls.Add(this.lblEliminarID);
            this.tabDelete.Controls.Add(this.txtEliminarId);
            this.tabDelete.Controls.Add(this.btnDelCancel);
            this.tabDelete.Controls.Add(this.btnDeleteUser);
            this.tabDelete.Controls.Add(this.lblEliminarAlquiler);
            this.tabDelete.Location = new System.Drawing.Point(4, 22);
            this.tabDelete.Name = "tabDelete";
            this.tabDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tabDelete.Size = new System.Drawing.Size(342, 424);
            this.tabDelete.TabIndex = 3;
            this.tabDelete.Text = "Eliminar";
            this.tabDelete.UseVisualStyleBackColor = true;
            // 
            // dtpEliminarFechaFinal
            // 
            this.dtpEliminarFechaFinal.Enabled = false;
            this.dtpEliminarFechaFinal.Location = new System.Drawing.Point(126, 279);
            this.dtpEliminarFechaFinal.Name = "dtpEliminarFechaFinal";
            this.dtpEliminarFechaFinal.Size = new System.Drawing.Size(201, 20);
            this.dtpEliminarFechaFinal.TabIndex = 76;
            // 
            // lblEliminarFechaFinal
            // 
            this.lblEliminarFechaFinal.AutoSize = true;
            this.lblEliminarFechaFinal.Location = new System.Drawing.Point(28, 283);
            this.lblEliminarFechaFinal.Name = "lblEliminarFechaFinal";
            this.lblEliminarFechaFinal.Size = new System.Drawing.Size(62, 13);
            this.lblEliminarFechaFinal.TabIndex = 75;
            this.lblEliminarFechaFinal.Text = "Fecha Final";
            // 
            // dtpEliminarFechaInicio
            // 
            this.dtpEliminarFechaInicio.Enabled = false;
            this.dtpEliminarFechaInicio.Location = new System.Drawing.Point(126, 238);
            this.dtpEliminarFechaInicio.Name = "dtpEliminarFechaInicio";
            this.dtpEliminarFechaInicio.Size = new System.Drawing.Size(201, 20);
            this.dtpEliminarFechaInicio.TabIndex = 74;
            // 
            // cmbEliminarInquilino
            // 
            this.cmbEliminarInquilino.Enabled = false;
            this.cmbEliminarInquilino.FormattingEnabled = true;
            this.cmbEliminarInquilino.Location = new System.Drawing.Point(126, 196);
            this.cmbEliminarInquilino.Name = "cmbEliminarInquilino";
            this.cmbEliminarInquilino.Size = new System.Drawing.Size(201, 21);
            this.cmbEliminarInquilino.TabIndex = 73;
            this.cmbEliminarInquilino.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cmbEliminarInquilino_Format);
            // 
            // cmbEliminarDepartamento
            // 
            this.cmbEliminarDepartamento.Enabled = false;
            this.cmbEliminarDepartamento.FormattingEnabled = true;
            this.cmbEliminarDepartamento.Location = new System.Drawing.Point(126, 154);
            this.cmbEliminarDepartamento.Name = "cmbEliminarDepartamento";
            this.cmbEliminarDepartamento.Size = new System.Drawing.Size(201, 21);
            this.cmbEliminarDepartamento.TabIndex = 72;
            this.cmbEliminarDepartamento.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cmbEliminarDepartamento_Format);
            // 
            // txtEliminarPrecio
            // 
            this.txtEliminarPrecio.Enabled = false;
            this.txtEliminarPrecio.Location = new System.Drawing.Point(126, 320);
            this.txtEliminarPrecio.Name = "txtEliminarPrecio";
            this.txtEliminarPrecio.Size = new System.Drawing.Size(201, 20);
            this.txtEliminarPrecio.TabIndex = 71;
            // 
            // cmbEliminarEdificio
            // 
            this.cmbEliminarEdificio.Enabled = false;
            this.cmbEliminarEdificio.FormattingEnabled = true;
            this.cmbEliminarEdificio.Location = new System.Drawing.Point(126, 112);
            this.cmbEliminarEdificio.Name = "cmbEliminarEdificio";
            this.cmbEliminarEdificio.Size = new System.Drawing.Size(201, 21);
            this.cmbEliminarEdificio.TabIndex = 64;
            this.cmbEliminarEdificio.TextChanged += new System.EventHandler(this.cmbEliminarEdificio_TextChanged);
            // 
            // lblEliminarEdificio
            // 
            this.lblEliminarEdificio.AutoSize = true;
            this.lblEliminarEdificio.Location = new System.Drawing.Point(49, 115);
            this.lblEliminarEdificio.Name = "lblEliminarEdificio";
            this.lblEliminarEdificio.Size = new System.Drawing.Size(41, 13);
            this.lblEliminarEdificio.TabIndex = 65;
            this.lblEliminarEdificio.Text = "Edificio";
            this.lblEliminarEdificio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEliminarDepartamento
            // 
            this.lblEliminarDepartamento.AutoSize = true;
            this.lblEliminarDepartamento.Location = new System.Drawing.Point(16, 157);
            this.lblEliminarDepartamento.Name = "lblEliminarDepartamento";
            this.lblEliminarDepartamento.Size = new System.Drawing.Size(74, 13);
            this.lblEliminarDepartamento.TabIndex = 66;
            this.lblEliminarDepartamento.Text = "Departamento";
            this.lblEliminarDepartamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEliminarInquilino
            // 
            this.lblEliminarInquilino.AutoSize = true;
            this.lblEliminarInquilino.Location = new System.Drawing.Point(44, 199);
            this.lblEliminarInquilino.Name = "lblEliminarInquilino";
            this.lblEliminarInquilino.Size = new System.Drawing.Size(46, 13);
            this.lblEliminarInquilino.TabIndex = 67;
            this.lblEliminarInquilino.Text = "Inquilino";
            // 
            // lblEliminarFechaInicio
            // 
            this.lblEliminarFechaInicio.AutoSize = true;
            this.lblEliminarFechaInicio.Location = new System.Drawing.Point(25, 241);
            this.lblEliminarFechaInicio.Name = "lblEliminarFechaInicio";
            this.lblEliminarFechaInicio.Size = new System.Drawing.Size(65, 13);
            this.lblEliminarFechaInicio.TabIndex = 68;
            this.lblEliminarFechaInicio.Text = "Fecha Inicio";
            // 
            // lblEliminarPrecio
            // 
            this.lblEliminarPrecio.AutoSize = true;
            this.lblEliminarPrecio.Location = new System.Drawing.Point(53, 325);
            this.lblEliminarPrecio.Name = "lblEliminarPrecio";
            this.lblEliminarPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblEliminarPrecio.TabIndex = 69;
            this.lblEliminarPrecio.Text = "Precio";
            // 
            // lblEliminarID
            // 
            this.lblEliminarID.AutoSize = true;
            this.lblEliminarID.Location = new System.Drawing.Point(72, 73);
            this.lblEliminarID.Name = "lblEliminarID";
            this.lblEliminarID.Size = new System.Drawing.Size(18, 13);
            this.lblEliminarID.TabIndex = 62;
            this.lblEliminarID.Text = "ID";
            // 
            // txtEliminarId
            // 
            this.txtEliminarId.Enabled = false;
            this.txtEliminarId.Location = new System.Drawing.Point(126, 71);
            this.txtEliminarId.Name = "txtEliminarId";
            this.txtEliminarId.Size = new System.Drawing.Size(201, 20);
            this.txtEliminarId.TabIndex = 61;
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
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteAlquiler_Click);
            // 
            // lblEliminarAlquiler
            // 
            this.lblEliminarAlquiler.AutoSize = true;
            this.lblEliminarAlquiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminarAlquiler.Location = new System.Drawing.Point(73, 16);
            this.lblEliminarAlquiler.Name = "lblEliminarAlquiler";
            this.lblEliminarAlquiler.Size = new System.Drawing.Size(184, 25);
            this.lblEliminarAlquiler.TabIndex = 45;
            this.lblEliminarAlquiler.Text = "Eliminar Alquiler";
            // 
            // lblNuevoOperador
            // 
            this.lblNuevoOperador.AutoSize = true;
            this.lblNuevoOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoOperador.Location = new System.Drawing.Point(6, 20);
            this.lblNuevoOperador.Name = "lblNuevoOperador";
            this.lblNuevoOperador.Size = new System.Drawing.Size(78, 16);
            this.lblNuevoOperador.TabIndex = 42;
            this.lblNuevoOperador.Text = "Operador:";
            // 
            // lblalquileres
            // 
            this.lblalquileres.AutoSize = true;
            this.lblalquileres.BackColor = System.Drawing.Color.Transparent;
            this.lblalquileres.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblalquileres.Location = new System.Drawing.Point(297, 31);
            this.lblalquileres.Margin = new System.Windows.Forms.Padding(10);
            this.lblalquileres.Name = "lblalquileres";
            this.lblalquileres.Size = new System.Drawing.Size(415, 42);
            this.lblalquileres.TabIndex = 6;
            this.lblalquileres.Text = "Gestionar Alquileres";
            // 
            // btnVolverAtras
            // 
            this.btnVolverAtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btnVolverAtras.ForeColor = System.Drawing.Color.White;
            this.btnVolverAtras.Location = new System.Drawing.Point(971, 145);
            this.btnVolverAtras.Name = "btnVolverAtras";
            this.btnVolverAtras.Size = new System.Drawing.Size(150, 29);
            this.btnVolverAtras.TabIndex = 7;
            this.btnVolverAtras.Text = "VOLVER ATRÁS";
            this.btnVolverAtras.UseVisualStyleBackColor = false;
            this.btnVolverAtras.Click += new System.EventHandler(this.btnVolverAtras_Click);
            // 
            // lblOperador
            // 
            this.lblOperador.AutoSize = true;
            this.lblOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperador.Location = new System.Drawing.Point(87, 20);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(0, 16);
            this.lblOperador.TabIndex = 49;
            // 
            // gpbOperador
            // 
            this.gpbOperador.AutoSize = true;
            this.gpbOperador.BackColor = System.Drawing.Color.Transparent;
            this.gpbOperador.Controls.Add(this.lblNuevoOperador);
            this.gpbOperador.Controls.Add(this.lblOperador);
            this.gpbOperador.Location = new System.Drawing.Point(848, 31);
            this.gpbOperador.Name = "gpbOperador";
            this.gpbOperador.Size = new System.Drawing.Size(147, 52);
            this.gpbOperador.TabIndex = 50;
            this.gpbOperador.TabStop = false;
            // 
            // frmGestionAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vistas.Properties.Resources.background_2344222_640;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1140, 661);
            this.ControlBox = false;
            this.Controls.Add(this.gpbOperador);
            this.Controls.Add(this.btnVolverAtras);
            this.Controls.Add(this.lblalquileres);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.txtPatternSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgwAlquileres);
            this.DoubleBuffered = true;
            this.Name = "frmGestionAlquiler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Usuarios";
            this.Load += new System.EventHandler(this.frmGestionAlquiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwAlquileres)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabNewUser.ResumeLayout(false);
            this.tabNewUser.PerformLayout();
            this.tabModificar.ResumeLayout(false);
            this.tabModificar.PerformLayout();
            this.tabDelete.ResumeLayout(false);
            this.tabDelete.PerformLayout();
            this.gpbOperador.ResumeLayout(false);
            this.gpbOperador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwAlquileres;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtPatternSearch;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabNewUser;
        private System.Windows.Forms.TabPage tabModificar;
        private System.Windows.Forms.Button btnAddSaveUser;
        private System.Windows.Forms.ComboBox cmbAddEdificio;
        private System.Windows.Forms.Label lblNuevoEdificio;
        private System.Windows.Forms.Label lblNuevoDepartamento;
        private System.Windows.Forms.Label lblNuevoInquilino;
        private System.Windows.Forms.Label lblNuevoFechaInicio;
        private System.Windows.Forms.Label lblNuevoPrecio;
        private System.Windows.Forms.Button btnModSave;
        private System.Windows.Forms.Label lblNuevoAlquiler;
        private System.Windows.Forms.Label lblModificarAlquiler;
        private System.Windows.Forms.TextBox txtModId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModCancel;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.TabPage tabDelete;
        private System.Windows.Forms.Button btnDelCancel;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Label lblEliminarAlquiler;
        private System.Windows.Forms.Label lblalquileres;
        private System.Windows.Forms.Button btnVolverAtras;
        private System.Windows.Forms.DateTimePicker dtpNuevoFechaInicio;
        private System.Windows.Forms.ComboBox cmbAddInquilino;
        private System.Windows.Forms.ComboBox cmbAddDepartamento;
        private System.Windows.Forms.TextBox txtNuevoPrecio;
        private System.Windows.Forms.Label lblNuevoOperador;
        private System.Windows.Forms.DateTimePicker dtpModFechaInicio;
        private System.Windows.Forms.ComboBox cmbModInquilino;
        private System.Windows.Forms.ComboBox cmbModDepartamento;
        private System.Windows.Forms.TextBox txtModPrecio;
        private System.Windows.Forms.ComboBox cmbModEdificio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblModFechaInicio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpNuevoFechaFinal;
        private System.Windows.Forms.Label lblNuevoFechafinal;
        private System.Windows.Forms.DateTimePicker dtpModFechaFinal;
        private System.Windows.Forms.Label lblModFechaFinal;
        private System.Windows.Forms.DateTimePicker dtpEliminarFechaFinal;
        private System.Windows.Forms.Label lblEliminarFechaFinal;
        private System.Windows.Forms.DateTimePicker dtpEliminarFechaInicio;
        private System.Windows.Forms.ComboBox cmbEliminarInquilino;
        private System.Windows.Forms.ComboBox cmbEliminarDepartamento;
        private System.Windows.Forms.TextBox txtEliminarPrecio;
        private System.Windows.Forms.ComboBox cmbEliminarEdificio;
        private System.Windows.Forms.Label lblEliminarEdificio;
        private System.Windows.Forms.Label lblEliminarDepartamento;
        private System.Windows.Forms.Label lblEliminarInquilino;
        private System.Windows.Forms.Label lblEliminarFechaInicio;
        private System.Windows.Forms.Label lblEliminarPrecio;
        private System.Windows.Forms.Label lblEliminarID;
        private System.Windows.Forms.TextBox txtEliminarId;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.GroupBox gpbOperador;
    }
}