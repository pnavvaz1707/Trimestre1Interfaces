/*
* PRÁCTICA.............: Práctica 6.
* NOMBRE Y APELLIDOS...: Pablo Navarro Vázquez
* CURSO Y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO DE LA PRÁCTICA: Aplicaciones de Formulario. Controles Básicos.
* FECHA DE ENTREGA.....: 07 de diciembre de 2022
*/

namespace Practica6
{
    partial class FormMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpFormCrearEmpleado = new System.Windows.Forms.GroupBox();
            this.cboNumHorasExtras = new System.Windows.Forms.ComboBox();
            this.cboNumTrienios = new System.Windows.Forms.ComboBox();
            this.cboNumHijos = new System.Windows.Forms.ComboBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblTituloCrearEmpleado = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblNumHorasExtras = new System.Windows.Forms.Label();
            this.lblNumTrienios = new System.Windows.Forms.Label();
            this.lblNumHijos = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.lblNombreEmpleado = new System.Windows.Forms.Label();
            this.txtNif = new System.Windows.Forms.TextBox();
            this.lblNif = new System.Windows.Forms.Label();
            this.grpHojaSalarial = new System.Windows.Forms.GroupBox();
            this.txtTotalDescuentos = new System.Windows.Forms.TextBox();
            this.txtIRPF = new System.Windows.Forms.TextBox();
            this.txtCotizDesempleo = new System.Windows.Forms.TextBox();
            this.txtCotizSS = new System.Windows.Forms.TextBox();
            this.txtLiquido = new System.Windows.Forms.TextBox();
            this.txtTotalDevengos = new System.Windows.Forms.TextBox();
            this.txtPagaExtra = new System.Windows.Forms.TextBox();
            this.txtNumHorasExtrasDevengos = new System.Windows.Forms.TextBox();
            this.txtAntiguedad = new System.Windows.Forms.TextBox();
            this.txtSalarioBase = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblTotalDescuentos = new System.Windows.Forms.Label();
            this.lblIRPF = new System.Windows.Forms.Label();
            this.lblCotizDesempleo = new System.Windows.Forms.Label();
            this.lblCotizSS = new System.Windows.Forms.Label();
            this.lblLiquido = new System.Windows.Forms.Label();
            this.lblTotalDevengos = new System.Windows.Forms.Label();
            this.lblPagaExtra = new System.Windows.Forms.Label();
            this.lblNumHorasExtrasDevengos = new System.Windows.Forms.Label();
            this.lblAntiguedad = new System.Windows.Forms.Label();
            this.lblSalarioBase = new System.Windows.Forms.Label();
            this.lblTituloDescuentos = new System.Windows.Forms.Label();
            this.lblTituloDevengos = new System.Windows.Forms.Label();
            this.lblTituloHojaSalarial = new System.Windows.Forms.Label();
            this.grpFormCrearEmpleado.SuspendLayout();
            this.grpHojaSalarial.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Georgia", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTitulo.Location = new System.Drawing.Point(199, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(324, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cálculo de la hoja salarial";
            // 
            // grpFormCrearEmpleado
            // 
            this.grpFormCrearEmpleado.Controls.Add(this.cboNumHorasExtras);
            this.grpFormCrearEmpleado.Controls.Add(this.cboNumTrienios);
            this.grpFormCrearEmpleado.Controls.Add(this.cboNumHijos);
            this.grpFormCrearEmpleado.Controls.Add(this.cboCategoria);
            this.grpFormCrearEmpleado.Controls.Add(this.dtpFecha);
            this.grpFormCrearEmpleado.Controls.Add(this.lblTituloCrearEmpleado);
            this.grpFormCrearEmpleado.Controls.Add(this.btnCalcular);
            this.grpFormCrearEmpleado.Controls.Add(this.lblNumHorasExtras);
            this.grpFormCrearEmpleado.Controls.Add(this.lblNumTrienios);
            this.grpFormCrearEmpleado.Controls.Add(this.lblNumHijos);
            this.grpFormCrearEmpleado.Controls.Add(this.lblFecha);
            this.grpFormCrearEmpleado.Controls.Add(this.lblCategoria);
            this.grpFormCrearEmpleado.Controls.Add(this.txtNombreEmpleado);
            this.grpFormCrearEmpleado.Controls.Add(this.lblNombreEmpleado);
            this.grpFormCrearEmpleado.Controls.Add(this.txtNif);
            this.grpFormCrearEmpleado.Controls.Add(this.lblNif);
            this.grpFormCrearEmpleado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFormCrearEmpleado.Location = new System.Drawing.Point(39, 41);
            this.grpFormCrearEmpleado.Name = "grpFormCrearEmpleado";
            this.grpFormCrearEmpleado.Size = new System.Drawing.Size(651, 269);
            this.grpFormCrearEmpleado.TabIndex = 24;
            this.grpFormCrearEmpleado.TabStop = false;
            // 
            // cboNumHorasExtras
            // 
            this.cboNumHorasExtras.FormattingEnabled = true;
            this.cboNumHorasExtras.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cboNumHorasExtras.Location = new System.Drawing.Point(589, 157);
            this.cboNumHorasExtras.Name = "cboNumHorasExtras";
            this.cboNumHorasExtras.Size = new System.Drawing.Size(34, 23);
            this.cboNumHorasExtras.TabIndex = 7;
            this.cboNumHorasExtras.Text = "2";
            this.cboNumHorasExtras.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pasarAlSigControl);
            this.cboNumHorasExtras.Leave += new System.EventHandler(this.cboNumHorasExtras_Leave);
            // 
            // cboNumTrienios
            // 
            this.cboNumTrienios.FormattingEnabled = true;
            this.cboNumTrienios.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cboNumTrienios.Location = new System.Drawing.Point(383, 157);
            this.cboNumTrienios.Name = "cboNumTrienios";
            this.cboNumTrienios.Size = new System.Drawing.Size(46, 23);
            this.cboNumTrienios.TabIndex = 6;
            this.cboNumTrienios.Text = "4";
            this.cboNumTrienios.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pasarAlSigControl);
            this.cboNumTrienios.Leave += new System.EventHandler(this.cboNumTrienios_Leave);
            // 
            // cboNumHijos
            // 
            this.cboNumHijos.FormattingEnabled = true;
            this.cboNumHijos.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.cboNumHijos.Location = new System.Drawing.Point(233, 157);
            this.cboNumHijos.Name = "cboNumHijos";
            this.cboNumHijos.Size = new System.Drawing.Size(38, 23);
            this.cboNumHijos.TabIndex = 5;
            this.cboNumHijos.Text = "2";
            this.cboNumHijos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pasarAlSigControl);
            this.cboNumHijos.Leave += new System.EventHandler(this.cboNumHijos_Leave);
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cboCategoria.Location = new System.Drawing.Point(83, 157);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(34, 23);
            this.cboCategoria.TabIndex = 4;
            this.cboCategoria.Text = "1";
            this.cboCategoria.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pasarAlSigControl);
            this.cboCategoria.Leave += new System.EventHandler(this.cboCategoria_Leave);
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "MM/yyyy";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(185, 223);
            this.dtpFecha.MaxDate = new System.DateTime(2022, 12, 2, 17, 36, 55, 512);
            this.dtpFecha.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(86, 23);
            this.dtpFecha.TabIndex = 8;
            this.dtpFecha.Value = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtpFecha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pasarAlSigControl);
            // 
            // lblTituloCrearEmpleado
            // 
            this.lblTituloCrearEmpleado.AutoSize = true;
            this.lblTituloCrearEmpleado.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCrearEmpleado.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTituloCrearEmpleado.Location = new System.Drawing.Point(114, 23);
            this.lblTituloCrearEmpleado.Name = "lblTituloCrearEmpleado";
            this.lblTituloCrearEmpleado.Size = new System.Drawing.Size(423, 29);
            this.lblTituloCrearEmpleado.TabIndex = 1;
            this.lblTituloCrearEmpleado.Text = "Introduce los datos del empleado";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(385, 217);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(174, 38);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular hoja salarial";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblNumHorasExtras
            // 
            this.lblNumHorasExtras.AutoSize = true;
            this.lblNumHorasExtras.Location = new System.Drawing.Point(489, 160);
            this.lblNumHorasExtras.Name = "lblNumHorasExtras";
            this.lblNumHorasExtras.Size = new System.Drawing.Size(94, 15);
            this.lblNumHorasExtras.TabIndex = 12;
            this.lblNumHorasExtras.Text = "Nº Horas extras";
            // 
            // lblNumTrienios
            // 
            this.lblNumTrienios.AutoSize = true;
            this.lblNumTrienios.Location = new System.Drawing.Point(310, 160);
            this.lblNumTrienios.Name = "lblNumTrienios";
            this.lblNumTrienios.Size = new System.Drawing.Size(67, 15);
            this.lblNumTrienios.TabIndex = 10;
            this.lblNumTrienios.Text = "Nº Trienios";
            // 
            // lblNumHijos
            // 
            this.lblNumHijos.AutoSize = true;
            this.lblNumHijos.Location = new System.Drawing.Point(176, 160);
            this.lblNumHijos.Name = "lblNumHijos";
            this.lblNumHijos.Size = new System.Drawing.Size(51, 15);
            this.lblNumHijos.TabIndex = 8;
            this.lblNumHijos.Text = "Nº Hijos";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(13, 229);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(166, 15);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha liquidación (mm/aaaa) ";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(13, 160);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(60, 15);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "Categoría";
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Location = new System.Drawing.Point(130, 114);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(247, 23);
            this.txtNombreEmpleado.TabIndex = 3;
            this.txtNombreEmpleado.Text = "P";
            this.txtNombreEmpleado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pasarAlSigControl);
            this.txtNombreEmpleado.Leave += new System.EventHandler(this.txtNombreEmpleado_Leave);
            // 
            // lblNombreEmpleado
            // 
            this.lblNombreEmpleado.AutoSize = true;
            this.lblNombreEmpleado.Location = new System.Drawing.Point(13, 114);
            this.lblNombreEmpleado.Name = "lblNombreEmpleado";
            this.lblNombreEmpleado.Size = new System.Drawing.Size(111, 15);
            this.lblNombreEmpleado.TabIndex = 2;
            this.lblNombreEmpleado.Text = "Nombre empleado";
            // 
            // txtNif
            // 
            this.txtNif.Location = new System.Drawing.Point(41, 75);
            this.txtNif.Name = "txtNif";
            this.txtNif.Size = new System.Drawing.Size(83, 23);
            this.txtNif.TabIndex = 2;
            this.txtNif.Text = "12345678Z";
            this.txtNif.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pasarAlSigControl);
            this.txtNif.Leave += new System.EventHandler(this.txtNif_Leave);
            // 
            // lblNif
            // 
            this.lblNif.AutoSize = true;
            this.lblNif.Location = new System.Drawing.Point(13, 78);
            this.lblNif.Name = "lblNif";
            this.lblNif.Size = new System.Drawing.Size(26, 15);
            this.lblNif.TabIndex = 0;
            this.lblNif.Text = "NIF";
            // 
            // grpHojaSalarial
            // 
            this.grpHojaSalarial.Controls.Add(this.txtTotalDescuentos);
            this.grpHojaSalarial.Controls.Add(this.txtIRPF);
            this.grpHojaSalarial.Controls.Add(this.txtCotizDesempleo);
            this.grpHojaSalarial.Controls.Add(this.txtCotizSS);
            this.grpHojaSalarial.Controls.Add(this.txtLiquido);
            this.grpHojaSalarial.Controls.Add(this.txtTotalDevengos);
            this.grpHojaSalarial.Controls.Add(this.txtPagaExtra);
            this.grpHojaSalarial.Controls.Add(this.txtNumHorasExtrasDevengos);
            this.grpHojaSalarial.Controls.Add(this.txtAntiguedad);
            this.grpHojaSalarial.Controls.Add(this.txtSalarioBase);
            this.grpHojaSalarial.Controls.Add(this.btnSalir);
            this.grpHojaSalarial.Controls.Add(this.btnModificar);
            this.grpHojaSalarial.Controls.Add(this.lblTotalDescuentos);
            this.grpHojaSalarial.Controls.Add(this.lblIRPF);
            this.grpHojaSalarial.Controls.Add(this.lblCotizDesempleo);
            this.grpHojaSalarial.Controls.Add(this.lblCotizSS);
            this.grpHojaSalarial.Controls.Add(this.lblLiquido);
            this.grpHojaSalarial.Controls.Add(this.lblTotalDevengos);
            this.grpHojaSalarial.Controls.Add(this.lblPagaExtra);
            this.grpHojaSalarial.Controls.Add(this.lblNumHorasExtrasDevengos);
            this.grpHojaSalarial.Controls.Add(this.lblAntiguedad);
            this.grpHojaSalarial.Controls.Add(this.lblSalarioBase);
            this.grpHojaSalarial.Controls.Add(this.lblTituloDescuentos);
            this.grpHojaSalarial.Controls.Add(this.lblTituloDevengos);
            this.grpHojaSalarial.Controls.Add(this.lblTituloHojaSalarial);
            this.grpHojaSalarial.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpHojaSalarial.Location = new System.Drawing.Point(39, 316);
            this.grpHojaSalarial.Name = "grpHojaSalarial";
            this.grpHojaSalarial.Size = new System.Drawing.Size(651, 364);
            this.grpHojaSalarial.TabIndex = 25;
            this.grpHojaSalarial.TabStop = false;
            this.grpHojaSalarial.Visible = false;
            // 
            // txtTotalDescuentos
            // 
            this.txtTotalDescuentos.Location = new System.Drawing.Point(533, 252);
            this.txtTotalDescuentos.Multiline = true;
            this.txtTotalDescuentos.Name = "txtTotalDescuentos";
            this.txtTotalDescuentos.ReadOnly = true;
            this.txtTotalDescuentos.Size = new System.Drawing.Size(100, 18);
            this.txtTotalDescuentos.TabIndex = 20;
            // 
            // txtIRPF
            // 
            this.txtIRPF.Location = new System.Drawing.Point(533, 167);
            this.txtIRPF.Multiline = true;
            this.txtIRPF.Name = "txtIRPF";
            this.txtIRPF.ReadOnly = true;
            this.txtIRPF.Size = new System.Drawing.Size(100, 18);
            this.txtIRPF.TabIndex = 19;
            // 
            // txtCotizDesempleo
            // 
            this.txtCotizDesempleo.Location = new System.Drawing.Point(533, 135);
            this.txtCotizDesempleo.Multiline = true;
            this.txtCotizDesempleo.Name = "txtCotizDesempleo";
            this.txtCotizDesempleo.ReadOnly = true;
            this.txtCotizDesempleo.Size = new System.Drawing.Size(100, 18);
            this.txtCotizDesempleo.TabIndex = 18;
            // 
            // txtCotizSS
            // 
            this.txtCotizSS.Location = new System.Drawing.Point(533, 105);
            this.txtCotizSS.Multiline = true;
            this.txtCotizSS.Name = "txtCotizSS";
            this.txtCotizSS.ReadOnly = true;
            this.txtCotizSS.Size = new System.Drawing.Size(100, 18);
            this.txtCotizSS.TabIndex = 17;
            // 
            // txtLiquido
            // 
            this.txtLiquido.Location = new System.Drawing.Point(137, 307);
            this.txtLiquido.Multiline = true;
            this.txtLiquido.Name = "txtLiquido";
            this.txtLiquido.ReadOnly = true;
            this.txtLiquido.Size = new System.Drawing.Size(100, 18);
            this.txtLiquido.TabIndex = 21;
            // 
            // txtTotalDevengos
            // 
            this.txtTotalDevengos.Location = new System.Drawing.Point(137, 252);
            this.txtTotalDevengos.Multiline = true;
            this.txtTotalDevengos.Name = "txtTotalDevengos";
            this.txtTotalDevengos.ReadOnly = true;
            this.txtTotalDevengos.Size = new System.Drawing.Size(100, 18);
            this.txtTotalDevengos.TabIndex = 16;
            // 
            // txtPagaExtra
            // 
            this.txtPagaExtra.Location = new System.Drawing.Point(137, 197);
            this.txtPagaExtra.Multiline = true;
            this.txtPagaExtra.Name = "txtPagaExtra";
            this.txtPagaExtra.ReadOnly = true;
            this.txtPagaExtra.Size = new System.Drawing.Size(100, 18);
            this.txtPagaExtra.TabIndex = 15;
            // 
            // txtNumHorasExtrasDevengos
            // 
            this.txtNumHorasExtrasDevengos.Location = new System.Drawing.Point(137, 167);
            this.txtNumHorasExtrasDevengos.Multiline = true;
            this.txtNumHorasExtrasDevengos.Name = "txtNumHorasExtrasDevengos";
            this.txtNumHorasExtrasDevengos.ReadOnly = true;
            this.txtNumHorasExtrasDevengos.Size = new System.Drawing.Size(100, 18);
            this.txtNumHorasExtrasDevengos.TabIndex = 14;
            // 
            // txtAntiguedad
            // 
            this.txtAntiguedad.Location = new System.Drawing.Point(137, 135);
            this.txtAntiguedad.Multiline = true;
            this.txtAntiguedad.Name = "txtAntiguedad";
            this.txtAntiguedad.ReadOnly = true;
            this.txtAntiguedad.Size = new System.Drawing.Size(100, 18);
            this.txtAntiguedad.TabIndex = 13;
            // 
            // txtSalarioBase
            // 
            this.txtSalarioBase.Location = new System.Drawing.Point(137, 105);
            this.txtSalarioBase.Multiline = true;
            this.txtSalarioBase.Name = "txtSalarioBase";
            this.txtSalarioBase.ReadOnly = true;
            this.txtSalarioBase.Size = new System.Drawing.Size(100, 18);
            this.txtSalarioBase.TabIndex = 12;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(528, 298);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(105, 39);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(385, 298);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(115, 39);
            this.btnModificar.TabIndex = 22;
            this.btnModificar.Text = "Modificar datos";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblTotalDescuentos
            // 
            this.lblTotalDescuentos.AutoSize = true;
            this.lblTotalDescuentos.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTotalDescuentos.Location = new System.Drawing.Point(382, 252);
            this.lblTotalDescuentos.Name = "lblTotalDescuentos";
            this.lblTotalDescuentos.Size = new System.Drawing.Size(100, 15);
            this.lblTotalDescuentos.TabIndex = 27;
            this.lblTotalDescuentos.Text = "Total descuentos";
            // 
            // lblIRPF
            // 
            this.lblIRPF.AutoSize = true;
            this.lblIRPF.ForeColor = System.Drawing.Color.Firebrick;
            this.lblIRPF.Location = new System.Drawing.Point(382, 167);
            this.lblIRPF.Name = "lblIRPF";
            this.lblIRPF.Size = new System.Drawing.Size(92, 15);
            this.lblIRPF.TabIndex = 26;
            this.lblIRPF.Text = "Retención IRPF";
            // 
            // lblCotizDesempleo
            // 
            this.lblCotizDesempleo.AutoSize = true;
            this.lblCotizDesempleo.ForeColor = System.Drawing.Color.Firebrick;
            this.lblCotizDesempleo.Location = new System.Drawing.Point(382, 135);
            this.lblCotizDesempleo.Name = "lblCotizDesempleo";
            this.lblCotizDesempleo.Size = new System.Drawing.Size(147, 15);
            this.lblCotizDesempleo.TabIndex = 25;
            this.lblCotizDesempleo.Text = "Cotiz. Seguro Desempleo";
            // 
            // lblCotizSS
            // 
            this.lblCotizSS.AutoSize = true;
            this.lblCotizSS.ForeColor = System.Drawing.Color.Firebrick;
            this.lblCotizSS.Location = new System.Drawing.Point(382, 105);
            this.lblCotizSS.Name = "lblCotizSS";
            this.lblCotizSS.Size = new System.Drawing.Size(132, 15);
            this.lblCotizSS.TabIndex = 24;
            this.lblCotizSS.Text = "Cotiz. Seguridad Social";
            // 
            // lblLiquido
            // 
            this.lblLiquido.AutoSize = true;
            this.lblLiquido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLiquido.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblLiquido.Location = new System.Drawing.Point(63, 305);
            this.lblLiquido.Name = "lblLiquido";
            this.lblLiquido.Size = new System.Drawing.Size(68, 21);
            this.lblLiquido.TabIndex = 23;
            this.lblLiquido.Text = "Líquido";
            // 
            // lblTotalDevengos
            // 
            this.lblTotalDevengos.AutoSize = true;
            this.lblTotalDevengos.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTotalDevengos.Location = new System.Drawing.Point(40, 252);
            this.lblTotalDevengos.Name = "lblTotalDevengos";
            this.lblTotalDevengos.Size = new System.Drawing.Size(91, 15);
            this.lblTotalDevengos.TabIndex = 22;
            this.lblTotalDevengos.Text = "Total devengos";
            // 
            // lblPagaExtra
            // 
            this.lblPagaExtra.AutoSize = true;
            this.lblPagaExtra.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPagaExtra.Location = new System.Drawing.Point(40, 197);
            this.lblPagaExtra.Name = "lblPagaExtra";
            this.lblPagaExtra.Size = new System.Drawing.Size(66, 15);
            this.lblPagaExtra.TabIndex = 21;
            this.lblPagaExtra.Text = "Paga extra";
            // 
            // lblNumHorasExtrasDevengos
            // 
            this.lblNumHorasExtrasDevengos.AutoSize = true;
            this.lblNumHorasExtrasDevengos.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNumHorasExtrasDevengos.Location = new System.Drawing.Point(40, 167);
            this.lblNumHorasExtrasDevengos.Name = "lblNumHorasExtrasDevengos";
            this.lblNumHorasExtrasDevengos.Size = new System.Drawing.Size(77, 15);
            this.lblNumHorasExtrasDevengos.TabIndex = 20;
            this.lblNumHorasExtrasDevengos.Text = "Horas extras";
            // 
            // lblAntiguedad
            // 
            this.lblAntiguedad.AutoSize = true;
            this.lblAntiguedad.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblAntiguedad.Location = new System.Drawing.Point(40, 135);
            this.lblAntiguedad.Name = "lblAntiguedad";
            this.lblAntiguedad.Size = new System.Drawing.Size(71, 15);
            this.lblAntiguedad.TabIndex = 19;
            this.lblAntiguedad.Text = "Antiguedad";
            // 
            // lblSalarioBase
            // 
            this.lblSalarioBase.AutoSize = true;
            this.lblSalarioBase.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblSalarioBase.Location = new System.Drawing.Point(40, 105);
            this.lblSalarioBase.Name = "lblSalarioBase";
            this.lblSalarioBase.Size = new System.Drawing.Size(72, 15);
            this.lblSalarioBase.TabIndex = 18;
            this.lblSalarioBase.Text = "Salario base";
            // 
            // lblTituloDescuentos
            // 
            this.lblTituloDescuentos.AutoSize = true;
            this.lblTituloDescuentos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDescuentos.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTituloDescuentos.Location = new System.Drawing.Point(382, 69);
            this.lblTituloDescuentos.Name = "lblTituloDescuentos";
            this.lblTituloDescuentos.Size = new System.Drawing.Size(98, 21);
            this.lblTituloDescuentos.TabIndex = 17;
            this.lblTituloDescuentos.Text = "Descuentos";
            // 
            // lblTituloDevengos
            // 
            this.lblTituloDevengos.AutoSize = true;
            this.lblTituloDevengos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDevengos.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTituloDevengos.Location = new System.Drawing.Point(40, 69);
            this.lblTituloDevengos.Name = "lblTituloDevengos";
            this.lblTituloDevengos.Size = new System.Drawing.Size(86, 21);
            this.lblTituloDevengos.TabIndex = 11;
            this.lblTituloDevengos.Text = "Devengos";
            // 
            // lblTituloHojaSalarial
            // 
            this.lblTituloHojaSalarial.AutoSize = true;
            this.lblTituloHojaSalarial.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloHojaSalarial.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblTituloHojaSalarial.Location = new System.Drawing.Point(237, 19);
            this.lblTituloHojaSalarial.Name = "lblTituloHojaSalarial";
            this.lblTituloHojaSalarial.Size = new System.Drawing.Size(168, 29);
            this.lblTituloHojaSalarial.TabIndex = 10;
            this.lblTituloHojaSalarial.Text = "Hoja salarial";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 710);
            this.Controls.Add(this.grpHojaSalarial);
            this.Controls.Add(this.grpFormCrearEmpleado);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.Text = "Formulario de creación de empleados";
            this.grpFormCrearEmpleado.ResumeLayout(false);
            this.grpFormCrearEmpleado.PerformLayout();
            this.grpHojaSalarial.ResumeLayout(false);
            this.grpHojaSalarial.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
            

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpFormCrearEmpleado;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.Label lblNombreEmpleado;
        private System.Windows.Forms.TextBox txtNif;
        private System.Windows.Forms.Label lblNif;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblNumHorasExtras;
        private System.Windows.Forms.Label lblNumTrienios;
        private System.Windows.Forms.Label lblNumHijos;
        private System.Windows.Forms.GroupBox grpHojaSalarial;
        private System.Windows.Forms.Label lblTituloCrearEmpleado;
        private System.Windows.Forms.Label lblTituloHojaSalarial;
        private System.Windows.Forms.TextBox txtTotalDescuentos;
        private System.Windows.Forms.TextBox txtIRPF;
        private System.Windows.Forms.TextBox txtCotizDesempleo;
        private System.Windows.Forms.TextBox txtCotizSS;
        private System.Windows.Forms.TextBox txtLiquido;
        private System.Windows.Forms.TextBox txtTotalDevengos;
        private System.Windows.Forms.TextBox txtPagaExtra;
        private System.Windows.Forms.TextBox txtNumHorasExtrasDevengos;
        private System.Windows.Forms.TextBox txtAntiguedad;
        private System.Windows.Forms.TextBox txtSalarioBase;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblTotalDescuentos;
        private System.Windows.Forms.Label lblIRPF;
        private System.Windows.Forms.Label lblCotizDesempleo;
        private System.Windows.Forms.Label lblCotizSS;
        private System.Windows.Forms.Label lblLiquido;
        private System.Windows.Forms.Label lblTotalDevengos;
        private System.Windows.Forms.Label lblPagaExtra;
        private System.Windows.Forms.Label lblNumHorasExtrasDevengos;
        private System.Windows.Forms.Label lblAntiguedad;
        private System.Windows.Forms.Label lblSalarioBase;
        private System.Windows.Forms.Label lblTituloDescuentos;
        private System.Windows.Forms.Label lblTituloDevengos;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.ComboBox cboNumHorasExtras;
        private System.Windows.Forms.ComboBox cboNumTrienios;
        private System.Windows.Forms.ComboBox cboNumHijos;
    }
}

