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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtNumHorasExtras = new System.Windows.Forms.TextBox();
            this.lblNumHorasExtras = new System.Windows.Forms.Label();
            this.txtNumTrienios = new System.Windows.Forms.TextBox();
            this.lblNumTrienios = new System.Windows.Forms.Label();
            this.txtNumHijos = new System.Windows.Forms.TextBox();
            this.lblNumHijos = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.lblNombreEmpleado = new System.Windows.Forms.Label();
            this.txtNif = new System.Windows.Forms.TextBox();
            this.lblNif = new System.Windows.Forms.Label();
            this.grpHojaSalarial = new System.Windows.Forms.GroupBox();
            this.lblTituloCrearEmpleado = new System.Windows.Forms.Label();
            this.lblTituloHojaSalarial = new System.Windows.Forms.Label();
            this.lblTituloDevengos = new System.Windows.Forms.Label();
            this.lblTituloDescuentos = new System.Windows.Forms.Label();
            this.lblSalarioBase = new System.Windows.Forms.Label();
            this.lblAntiguedad = new System.Windows.Forms.Label();
            this.lblNumHorasExtrasDevengos = new System.Windows.Forms.Label();
            this.lblPagaExtra = new System.Windows.Forms.Label();
            this.lblTotalDevengos = new System.Windows.Forms.Label();
            this.lblLiquido = new System.Windows.Forms.Label();
            this.lblIRPF = new System.Windows.Forms.Label();
            this.lblCotizDesempleo = new System.Windows.Forms.Label();
            this.lblCotizSS = new System.Windows.Forms.Label();
            this.lblTotalDescuentos = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtSalarioBase = new System.Windows.Forms.TextBox();
            this.txtAntiguedad = new System.Windows.Forms.TextBox();
            this.txtNumHorasExtrasDevengos = new System.Windows.Forms.TextBox();
            this.txtPagaExtra = new System.Windows.Forms.TextBox();
            this.txtTotalDevengos = new System.Windows.Forms.TextBox();
            this.txtLiquido = new System.Windows.Forms.TextBox();
            this.txtIRPF = new System.Windows.Forms.TextBox();
            this.txtCotizDesempleo = new System.Windows.Forms.TextBox();
            this.txtCotizSS = new System.Windows.Forms.TextBox();
            this.txtTotalDescuentos = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
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
            this.grpFormCrearEmpleado.Controls.Add(this.dtpFecha);
            this.grpFormCrearEmpleado.Controls.Add(this.lblTituloCrearEmpleado);
            this.grpFormCrearEmpleado.Controls.Add(this.btnCalcular);
            this.grpFormCrearEmpleado.Controls.Add(this.txtNumHorasExtras);
            this.grpFormCrearEmpleado.Controls.Add(this.lblNumHorasExtras);
            this.grpFormCrearEmpleado.Controls.Add(this.txtNumTrienios);
            this.grpFormCrearEmpleado.Controls.Add(this.lblNumTrienios);
            this.grpFormCrearEmpleado.Controls.Add(this.txtNumHijos);
            this.grpFormCrearEmpleado.Controls.Add(this.lblNumHijos);
            this.grpFormCrearEmpleado.Controls.Add(this.lblFecha);
            this.grpFormCrearEmpleado.Controls.Add(this.txtCategoria);
            this.grpFormCrearEmpleado.Controls.Add(this.lblCategoria);
            this.grpFormCrearEmpleado.Controls.Add(this.txtNombreEmpleado);
            this.grpFormCrearEmpleado.Controls.Add(this.lblNombreEmpleado);
            this.grpFormCrearEmpleado.Controls.Add(this.txtNif);
            this.grpFormCrearEmpleado.Controls.Add(this.lblNif);
            this.grpFormCrearEmpleado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFormCrearEmpleado.Location = new System.Drawing.Point(39, 41);
            this.grpFormCrearEmpleado.Name = "grpFormCrearEmpleado";
            this.grpFormCrearEmpleado.Size = new System.Drawing.Size(651, 269);
            this.grpFormCrearEmpleado.TabIndex = 1;
            this.grpFormCrearEmpleado.TabStop = false;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(363, 217);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(174, 38);
            this.btnCalcular.TabIndex = 14;
            this.btnCalcular.Text = "Calcular hoja salarial";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtNumHorasExtras
            // 
            this.txtNumHorasExtras.Location = new System.Drawing.Point(589, 160);
            this.txtNumHorasExtras.Multiline = true;
            this.txtNumHorasExtras.Name = "txtNumHorasExtras";
            this.txtNumHorasExtras.Size = new System.Drawing.Size(15, 15);
            this.txtNumHorasExtras.TabIndex = 13;
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
            // txtNumTrienios
            // 
            this.txtNumTrienios.Location = new System.Drawing.Point(401, 160);
            this.txtNumTrienios.Multiline = true;
            this.txtNumTrienios.Name = "txtNumTrienios";
            this.txtNumTrienios.Size = new System.Drawing.Size(15, 15);
            this.txtNumTrienios.TabIndex = 11;
            // 
            // lblNumTrienios
            // 
            this.lblNumTrienios.AutoSize = true;
            this.lblNumTrienios.Location = new System.Drawing.Point(328, 160);
            this.lblNumTrienios.Name = "lblNumTrienios";
            this.lblNumTrienios.Size = new System.Drawing.Size(67, 15);
            this.lblNumTrienios.TabIndex = 10;
            this.lblNumTrienios.Text = "Nº Trienios";
            // 
            // txtNumHijos
            // 
            this.txtNumHijos.Location = new System.Drawing.Point(233, 160);
            this.txtNumHijos.Multiline = true;
            this.txtNumHijos.Name = "txtNumHijos";
            this.txtNumHijos.Size = new System.Drawing.Size(15, 15);
            this.txtNumHijos.TabIndex = 9;
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
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(79, 160);
            this.txtCategoria.Multiline = true;
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(15, 15);
            this.txtCategoria.TabIndex = 5;
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
            this.txtNombreEmpleado.Multiline = true;
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(247, 15);
            this.txtNombreEmpleado.TabIndex = 3;
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
            this.txtNif.Location = new System.Drawing.Point(45, 78);
            this.txtNif.Multiline = true;
            this.txtNif.Name = "txtNif";
            this.txtNif.Size = new System.Drawing.Size(83, 15);
            this.txtNif.TabIndex = 1;
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
            this.grpHojaSalarial.TabIndex = 2;
            this.grpHojaSalarial.TabStop = false;
            // 
            // lblTituloCrearEmpleado
            // 
            this.lblTituloCrearEmpleado.AutoSize = true;
            this.lblTituloCrearEmpleado.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCrearEmpleado.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTituloCrearEmpleado.Location = new System.Drawing.Point(114, 23);
            this.lblTituloCrearEmpleado.Name = "lblTituloCrearEmpleado";
            this.lblTituloCrearEmpleado.Size = new System.Drawing.Size(423, 29);
            this.lblTituloCrearEmpleado.TabIndex = 3;
            this.lblTituloCrearEmpleado.Text = "Introduce los datos del empleado";
            // 
            // lblTituloHojaSalarial
            // 
            this.lblTituloHojaSalarial.AutoSize = true;
            this.lblTituloHojaSalarial.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloHojaSalarial.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblTituloHojaSalarial.Location = new System.Drawing.Point(237, 19);
            this.lblTituloHojaSalarial.Name = "lblTituloHojaSalarial";
            this.lblTituloHojaSalarial.Size = new System.Drawing.Size(168, 29);
            this.lblTituloHojaSalarial.TabIndex = 15;
            this.lblTituloHojaSalarial.Text = "Hoja salarial";
            // 
            // lblTituloDevengos
            // 
            this.lblTituloDevengos.AutoSize = true;
            this.lblTituloDevengos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDevengos.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTituloDevengos.Location = new System.Drawing.Point(40, 69);
            this.lblTituloDevengos.Name = "lblTituloDevengos";
            this.lblTituloDevengos.Size = new System.Drawing.Size(86, 21);
            this.lblTituloDevengos.TabIndex = 16;
            this.lblTituloDevengos.Text = "Devengos";
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
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(385, 298);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(115, 39);
            this.btnModificar.TabIndex = 28;
            this.btnModificar.Text = "Modificar datos";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(528, 298);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(105, 39);
            this.btnSalir.TabIndex = 29;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // txtSalarioBase
            // 
            this.txtSalarioBase.Location = new System.Drawing.Point(137, 105);
            this.txtSalarioBase.Multiline = true;
            this.txtSalarioBase.Name = "txtSalarioBase";
            this.txtSalarioBase.Size = new System.Drawing.Size(100, 18);
            this.txtSalarioBase.TabIndex = 30;
            // 
            // txtAntiguedad
            // 
            this.txtAntiguedad.Location = new System.Drawing.Point(137, 135);
            this.txtAntiguedad.Multiline = true;
            this.txtAntiguedad.Name = "txtAntiguedad";
            this.txtAntiguedad.Size = new System.Drawing.Size(100, 18);
            this.txtAntiguedad.TabIndex = 31;
            // 
            // txtNumHorasExtrasDevengos
            // 
            this.txtNumHorasExtrasDevengos.Location = new System.Drawing.Point(137, 167);
            this.txtNumHorasExtrasDevengos.Multiline = true;
            this.txtNumHorasExtrasDevengos.Name = "txtNumHorasExtrasDevengos";
            this.txtNumHorasExtrasDevengos.Size = new System.Drawing.Size(100, 18);
            this.txtNumHorasExtrasDevengos.TabIndex = 32;
            // 
            // txtPagaExtra
            // 
            this.txtPagaExtra.Location = new System.Drawing.Point(137, 197);
            this.txtPagaExtra.Multiline = true;
            this.txtPagaExtra.Name = "txtPagaExtra";
            this.txtPagaExtra.Size = new System.Drawing.Size(100, 18);
            this.txtPagaExtra.TabIndex = 33;
            // 
            // txtTotalDevengos
            // 
            this.txtTotalDevengos.Location = new System.Drawing.Point(137, 252);
            this.txtTotalDevengos.Multiline = true;
            this.txtTotalDevengos.Name = "txtTotalDevengos";
            this.txtTotalDevengos.Size = new System.Drawing.Size(100, 18);
            this.txtTotalDevengos.TabIndex = 34;
            // 
            // txtLiquido
            // 
            this.txtLiquido.Location = new System.Drawing.Point(137, 307);
            this.txtLiquido.Multiline = true;
            this.txtLiquido.Name = "txtLiquido";
            this.txtLiquido.Size = new System.Drawing.Size(100, 18);
            this.txtLiquido.TabIndex = 35;
            // 
            // txtIRPF
            // 
            this.txtIRPF.Location = new System.Drawing.Point(533, 167);
            this.txtIRPF.Multiline = true;
            this.txtIRPF.Name = "txtIRPF";
            this.txtIRPF.Size = new System.Drawing.Size(100, 18);
            this.txtIRPF.TabIndex = 38;
            // 
            // txtCotizDesempleo
            // 
            this.txtCotizDesempleo.Location = new System.Drawing.Point(533, 135);
            this.txtCotizDesempleo.Multiline = true;
            this.txtCotizDesempleo.Name = "txtCotizDesempleo";
            this.txtCotizDesempleo.Size = new System.Drawing.Size(100, 18);
            this.txtCotizDesempleo.TabIndex = 37;
            // 
            // txtCotizSS
            // 
            this.txtCotizSS.Location = new System.Drawing.Point(533, 105);
            this.txtCotizSS.Multiline = true;
            this.txtCotizSS.Name = "txtCotizSS";
            this.txtCotizSS.Size = new System.Drawing.Size(100, 18);
            this.txtCotizSS.TabIndex = 36;
            // 
            // txtTotalDescuentos
            // 
            this.txtTotalDescuentos.Location = new System.Drawing.Point(533, 252);
            this.txtTotalDescuentos.Multiline = true;
            this.txtTotalDescuentos.Name = "txtTotalDescuentos";
            this.txtTotalDescuentos.Size = new System.Drawing.Size(100, 18);
            this.txtTotalDescuentos.TabIndex = 39;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "MM/yyyy";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(185, 223);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(86, 23);
            this.dtpFecha.TabIndex = 15;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 710);
            this.Controls.Add(this.grpHojaSalarial);
            this.Controls.Add(this.grpFormCrearEmpleado);
            this.Controls.Add(this.lblTitulo);
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
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.Label lblNombreEmpleado;
        private System.Windows.Forms.TextBox txtNif;
        private System.Windows.Forms.Label lblNif;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtNumHorasExtras;
        private System.Windows.Forms.Label lblNumHorasExtras;
        private System.Windows.Forms.TextBox txtNumTrienios;
        private System.Windows.Forms.Label lblNumTrienios;
        private System.Windows.Forms.TextBox txtNumHijos;
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
    }
}

