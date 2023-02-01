namespace Practica9
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.menuPrincipalArchivoBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.btnArchivoNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnArchivoAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.btnGuardarArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGuardarComoArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipalInicioBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipalVerBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipalAyudaBtn = new System.Windows.Forms.ToolStripButton();
            this.menuPrincipalOcultarBtn = new System.Windows.Forms.ToolStripButton();
            this.subMenuInicio = new System.Windows.Forms.TableLayoutPanel();
            this.btnSumarTamanoFuente = new System.Windows.Forms.Button();
            this.btnRestarTamanoFuente = new System.Windows.Forms.Button();
            this.btnPegar = new System.Windows.Forms.Button();
            this.tamanoFuenteComboBox = new System.Windows.Forms.ComboBox();
            this.fuentesComboBox = new System.Windows.Forms.ComboBox();
            this.btnCortar = new System.Windows.Forms.Button();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.chckBoxNegrita = new System.Windows.Forms.CheckBox();
            this.chckBoxItalica = new System.Windows.Forms.CheckBox();
            this.chckBoxSubrayado = new System.Windows.Forms.CheckBox();
            this.chckBoxStrikeout = new System.Windows.Forms.CheckBox();
            this.btnResaltarTexto = new System.Windows.Forms.Button();
            this.btnColorearTexto = new System.Windows.Forms.Button();
            this.chckBoxSubIndice = new System.Windows.Forms.CheckBox();
            this.chckBoxSuperIndice = new System.Windows.Forms.CheckBox();
            this.btnReemplazar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSeleccionarTodo = new System.Windows.Forms.Button();
            this.btnAlinearCentro = new System.Windows.Forms.Button();
            this.btnAlinearIzquierda = new System.Windows.Forms.Button();
            this.btnAlinearJustificado = new System.Windows.Forms.Button();
            this.btnAlinearDerecha = new System.Windows.Forms.Button();
            editorTextBox = new System.Windows.Forms.RichTextBox();
            this.subMenuVer = new System.Windows.Forms.TableLayoutPanel();
            this.btnAlejar = new System.Windows.Forms.Button();
            this.btnAcercar = new System.Windows.Forms.Button();
            this.btnZoom100 = new System.Windows.Forms.Button();
            this.lblReiniciarZoom = new System.Windows.Forms.Label();
            this.lblAlejar = new System.Windows.Forms.Label();
            this.lblAcercar = new System.Windows.Forms.Label();
            this.menuPrincipal.SuspendLayout();
            this.subMenuInicio.SuspendLayout();
            this.subMenuVer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrincipalArchivoBtn,
            this.menuPrincipalInicioBtn,
            this.menuPrincipalVerBtn,
            this.menuPrincipalAyudaBtn,
            this.menuPrincipalOcultarBtn});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(800, 27);
            this.menuPrincipal.TabIndex = 0;
            // 
            // menuPrincipalArchivoBtn
            // 
            this.menuPrincipalArchivoBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnArchivoNuevo,
            this.btnArchivoAbrir,
            this.toolStripSeparator,
            this.btnGuardarArchivo,
            this.btnGuardarComoArchivo,
            this.toolStripSeparator1,
            this.btnSalir});
            this.menuPrincipalArchivoBtn.Name = "menuPrincipalArchivoBtn";
            this.menuPrincipalArchivoBtn.Size = new System.Drawing.Size(60, 23);
            this.menuPrincipalArchivoBtn.Text = "&Archivo";
            // 
            // btnArchivoNuevo
            // 
            this.btnArchivoNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnArchivoNuevo.Image")));
            this.btnArchivoNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnArchivoNuevo.Name = "btnArchivoNuevo";
            this.btnArchivoNuevo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.btnArchivoNuevo.Size = new System.Drawing.Size(156, 22);
            this.btnArchivoNuevo.Text = "&Nuevo";
            this.btnArchivoNuevo.Click += new System.EventHandler(this.btnArchivoNuevo_Click);
            // 
            // btnArchivoAbrir
            // 
            this.btnArchivoAbrir.Image = ((System.Drawing.Image)(resources.GetObject("btnArchivoAbrir.Image")));
            this.btnArchivoAbrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnArchivoAbrir.Name = "btnArchivoAbrir";
            this.btnArchivoAbrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.btnArchivoAbrir.Size = new System.Drawing.Size(156, 22);
            this.btnArchivoAbrir.Text = "&Abrir";
            this.btnArchivoAbrir.Click += new System.EventHandler(this.btnArchivoAbrir_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(153, 6);
            // 
            // btnGuardarArchivo
            // 
            this.btnGuardarArchivo.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarArchivo.Image")));
            this.btnGuardarArchivo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardarArchivo.Name = "btnGuardarArchivo";
            this.btnGuardarArchivo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.btnGuardarArchivo.Size = new System.Drawing.Size(156, 22);
            this.btnGuardarArchivo.Text = "&Guardar";
            this.btnGuardarArchivo.Click += new System.EventHandler(this.btnGuardarArchivo_Click);
            // 
            // btnGuardarComoArchivo
            // 
            this.btnGuardarComoArchivo.Name = "btnGuardarComoArchivo";
            this.btnGuardarComoArchivo.Size = new System.Drawing.Size(156, 22);
            this.btnGuardarComoArchivo.Text = "G&uardar como";
            this.btnGuardarComoArchivo.Click += new System.EventHandler(this.btnGuardarComoArchivo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(153, 6);
            // 
            // btnSalir
            // 
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(156, 22);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // menuPrincipalInicioBtn
            // 
            this.menuPrincipalInicioBtn.Name = "menuPrincipalInicioBtn";
            this.menuPrincipalInicioBtn.Size = new System.Drawing.Size(48, 23);
            this.menuPrincipalInicioBtn.Text = "&Inicio";
            this.menuPrincipalInicioBtn.Click += new System.EventHandler(this.menuPrincipalInicioBtn_Click);
            // 
            // menuPrincipalVerBtn
            // 
            this.menuPrincipalVerBtn.Name = "menuPrincipalVerBtn";
            this.menuPrincipalVerBtn.Size = new System.Drawing.Size(35, 23);
            this.menuPrincipalVerBtn.Text = "&Ver";
            this.menuPrincipalVerBtn.Click += new System.EventHandler(this.menuPrincipalVerBtn_Click);
            // 
            // menuPrincipalAyudaBtn
            // 
            this.menuPrincipalAyudaBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menuPrincipalAyudaBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuPrincipalAyudaBtn.Image = ((System.Drawing.Image)(resources.GetObject("menuPrincipalAyudaBtn.Image")));
            this.menuPrincipalAyudaBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuPrincipalAyudaBtn.Name = "menuPrincipalAyudaBtn";
            this.menuPrincipalAyudaBtn.Size = new System.Drawing.Size(23, 20);
            this.menuPrincipalAyudaBtn.Text = "A&yuda";
            this.menuPrincipalAyudaBtn.Click += new System.EventHandler(this.menuPrincipalAyudaBtn_Click);
            // 
            // menuPrincipalOcultarBtn
            // 
            this.menuPrincipalOcultarBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menuPrincipalOcultarBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuPrincipalOcultarBtn.Image = ((System.Drawing.Image)(resources.GetObject("menuPrincipalOcultarBtn.Image")));
            this.menuPrincipalOcultarBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuPrincipalOcultarBtn.Name = "menuPrincipalOcultarBtn";
            this.menuPrincipalOcultarBtn.Size = new System.Drawing.Size(23, 20);
            this.menuPrincipalOcultarBtn.Text = "Ocultar";
            this.menuPrincipalOcultarBtn.Click += new System.EventHandler(this.menuPrincipalOcultarBtn_Click);
            // 
            // subMenuInicio
            // 
            this.subMenuInicio.ColumnCount = 14;
            this.subMenuInicio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.subMenuInicio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.subMenuInicio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.subMenuInicio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.subMenuInicio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.subMenuInicio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.subMenuInicio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.subMenuInicio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.subMenuInicio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.subMenuInicio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.subMenuInicio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.subMenuInicio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.subMenuInicio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.subMenuInicio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 361F));
            this.subMenuInicio.Controls.Add(this.btnSumarTamanoFuente, 9, 0);
            this.subMenuInicio.Controls.Add(this.btnRestarTamanoFuente, 10, 0);
            this.subMenuInicio.Controls.Add(this.btnPegar, 0, 0);
            this.subMenuInicio.Controls.Add(this.tamanoFuenteComboBox, 7, 0);
            this.subMenuInicio.Controls.Add(this.fuentesComboBox, 3, 0);
            this.subMenuInicio.Controls.Add(this.btnCortar, 2, 0);
            this.subMenuInicio.Controls.Add(this.btnCopiar, 2, 1);
            this.subMenuInicio.Controls.Add(this.chckBoxNegrita, 3, 1);
            this.subMenuInicio.Controls.Add(this.chckBoxItalica, 4, 1);
            this.subMenuInicio.Controls.Add(this.chckBoxSubrayado, 5, 1);
            this.subMenuInicio.Controls.Add(this.chckBoxStrikeout, 6, 1);
            this.subMenuInicio.Controls.Add(this.btnResaltarTexto, 10, 1);
            this.subMenuInicio.Controls.Add(this.btnColorearTexto, 9, 1);
            this.subMenuInicio.Controls.Add(this.chckBoxSubIndice, 7, 1);
            this.subMenuInicio.Controls.Add(this.chckBoxSuperIndice, 8, 1);
            this.subMenuInicio.Controls.Add(this.btnReemplazar, 13, 1);
            this.subMenuInicio.Controls.Add(this.btnBuscar, 13, 0);
            this.subMenuInicio.Controls.Add(this.btnSeleccionarTodo, 13, 2);
            this.subMenuInicio.Controls.Add(this.btnAlinearCentro, 11, 1);
            this.subMenuInicio.Controls.Add(this.btnAlinearIzquierda, 11, 0);
            this.subMenuInicio.Controls.Add(this.btnAlinearJustificado, 12, 1);
            this.subMenuInicio.Controls.Add(this.btnAlinearDerecha, 12, 0);
            this.subMenuInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuInicio.Location = new System.Drawing.Point(0, 27);
            this.subMenuInicio.Name = "subMenuInicio";
            this.subMenuInicio.RowCount = 3;
            this.subMenuInicio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.subMenuInicio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.subMenuInicio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.subMenuInicio.Size = new System.Drawing.Size(800, 90);
            this.subMenuInicio.TabIndex = 3;
            this.subMenuInicio.Visible = false;
            // 
            // btnSumarTamanoFuente
            // 
            this.btnSumarTamanoFuente.Image = global::Practica9.Properties.Resources.incrementar_fuente;
            this.btnSumarTamanoFuente.Location = new System.Drawing.Point(320, 3);
            this.btnSumarTamanoFuente.Name = "btnSumarTamanoFuente";
            this.btnSumarTamanoFuente.Size = new System.Drawing.Size(25, 23);
            this.btnSumarTamanoFuente.TabIndex = 10;
            this.btnSumarTamanoFuente.UseVisualStyleBackColor = true;
            this.btnSumarTamanoFuente.Click += new System.EventHandler(this.btnSumarTamanoFuente_Click);
            // 
            // btnRestarTamanoFuente
            // 
            this.btnRestarTamanoFuente.Image = global::Practica9.Properties.Resources.decrementar_fuente;
            this.btnRestarTamanoFuente.Location = new System.Drawing.Point(351, 3);
            this.btnRestarTamanoFuente.Name = "btnRestarTamanoFuente";
            this.btnRestarTamanoFuente.Size = new System.Drawing.Size(26, 23);
            this.btnRestarTamanoFuente.TabIndex = 9;
            this.btnRestarTamanoFuente.UseVisualStyleBackColor = true;
            this.btnRestarTamanoFuente.Click += new System.EventHandler(this.btnRestarTamanoFuente_Click);
            // 
            // btnPegar
            // 
            this.btnPegar.Image = ((System.Drawing.Image)(resources.GetObject("btnPegar.Image")));
            this.btnPegar.Location = new System.Drawing.Point(3, 3);
            this.btnPegar.Name = "btnPegar";
            this.subMenuInicio.SetRowSpan(this.btnPegar, 2);
            this.btnPegar.Size = new System.Drawing.Size(48, 55);
            this.btnPegar.TabIndex = 1;
            this.btnPegar.UseVisualStyleBackColor = true;
            this.btnPegar.Click += new System.EventHandler(this.btnPegar_Click);
            // 
            // tamanoFuenteComboBox
            // 
            this.subMenuInicio.SetColumnSpan(this.tamanoFuenteComboBox, 2);
            this.tamanoFuenteComboBox.FormattingEnabled = true;
            this.tamanoFuenteComboBox.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.tamanoFuenteComboBox.Location = new System.Drawing.Point(261, 3);
            this.tamanoFuenteComboBox.Name = "tamanoFuenteComboBox";
            this.tamanoFuenteComboBox.Size = new System.Drawing.Size(53, 23);
            this.tamanoFuenteComboBox.TabIndex = 2;
            this.tamanoFuenteComboBox.SelectedValueChanged += new System.EventHandler(this.tamanoFuenteComboBox_SelectedValueChanged);
            // 
            // fuentesComboBox
            // 
            this.subMenuInicio.SetColumnSpan(this.fuentesComboBox, 4);
            this.fuentesComboBox.FormattingEnabled = true;
            this.fuentesComboBox.Location = new System.Drawing.Point(144, 3);
            this.fuentesComboBox.Name = "fuentesComboBox";
            this.fuentesComboBox.Size = new System.Drawing.Size(111, 23);
            this.fuentesComboBox.TabIndex = 1;
            this.fuentesComboBox.SelectedValueChanged += new System.EventHandler(this.fuentesComboBox_SelectedValueChanged);
            // 
            // btnCortar
            // 
            this.btnCortar.Image = ((System.Drawing.Image)(resources.GetObject("btnCortar.Image")));
            this.btnCortar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCortar.Location = new System.Drawing.Point(57, 3);
            this.btnCortar.Name = "btnCortar";
            this.btnCortar.Size = new System.Drawing.Size(81, 23);
            this.btnCortar.TabIndex = 2;
            this.btnCortar.Text = "Cortar";
            this.btnCortar.UseVisualStyleBackColor = true;
            this.btnCortar.Click += new System.EventHandler(this.btnCortar_Click);
            // 
            // btnCopiar
            // 
            this.btnCopiar.Image = global::Practica9.Properties.Resources.copiar;
            this.btnCopiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCopiar.Location = new System.Drawing.Point(57, 35);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(81, 23);
            this.btnCopiar.TabIndex = 3;
            this.btnCopiar.Text = "Copiar";
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // chckBoxNegrita
            // 
            this.chckBoxNegrita.Appearance = System.Windows.Forms.Appearance.Button;
            this.chckBoxNegrita.AutoSize = true;
            this.chckBoxNegrita.Image = global::Practica9.Properties.Resources.negrita;
            this.chckBoxNegrita.Location = new System.Drawing.Point(144, 35);
            this.chckBoxNegrita.Name = "chckBoxNegrita";
            this.chckBoxNegrita.Size = new System.Drawing.Size(23, 23);
            this.chckBoxNegrita.TabIndex = 9;
            this.chckBoxNegrita.UseVisualStyleBackColor = true;
            this.chckBoxNegrita.CheckedChanged += new System.EventHandler(this.chckBoxNegrita_CheckedChanged);
            // 
            // chckBoxItalica
            // 
            this.chckBoxItalica.Appearance = System.Windows.Forms.Appearance.Button;
            this.chckBoxItalica.AutoSize = true;
            this.chckBoxItalica.Image = global::Practica9.Properties.Resources.italica;
            this.chckBoxItalica.Location = new System.Drawing.Point(173, 35);
            this.chckBoxItalica.Name = "chckBoxItalica";
            this.chckBoxItalica.Size = new System.Drawing.Size(23, 23);
            this.chckBoxItalica.TabIndex = 10;
            this.chckBoxItalica.UseVisualStyleBackColor = true;
            this.chckBoxItalica.CheckedChanged += new System.EventHandler(this.chckBoxItalica_CheckedChanged);
            // 
            // chckBoxSubrayado
            // 
            this.chckBoxSubrayado.Appearance = System.Windows.Forms.Appearance.Button;
            this.chckBoxSubrayado.AutoSize = true;
            this.chckBoxSubrayado.Image = global::Practica9.Properties.Resources.subrayado;
            this.chckBoxSubrayado.Location = new System.Drawing.Point(204, 35);
            this.chckBoxSubrayado.Name = "chckBoxSubrayado";
            this.chckBoxSubrayado.Size = new System.Drawing.Size(23, 23);
            this.chckBoxSubrayado.TabIndex = 11;
            this.chckBoxSubrayado.UseVisualStyleBackColor = true;
            this.chckBoxSubrayado.CheckedChanged += new System.EventHandler(this.chckBoxSubrayado_CheckedChanged);
            // 
            // chckBoxStrikeout
            // 
            this.chckBoxStrikeout.Appearance = System.Windows.Forms.Appearance.Button;
            this.chckBoxStrikeout.AutoSize = true;
            this.chckBoxStrikeout.Image = global::Practica9.Properties.Resources.tachado;
            this.chckBoxStrikeout.Location = new System.Drawing.Point(233, 35);
            this.chckBoxStrikeout.Name = "chckBoxStrikeout";
            this.chckBoxStrikeout.Size = new System.Drawing.Size(22, 23);
            this.chckBoxStrikeout.TabIndex = 12;
            this.chckBoxStrikeout.UseVisualStyleBackColor = true;
            this.chckBoxStrikeout.CheckedChanged += new System.EventHandler(this.chckBoxStrikeout_CheckedChanged);
            // 
            // btnResaltarTexto
            // 
            this.btnResaltarTexto.Image = global::Practica9.Properties.Resources.resaltar_texto;
            this.btnResaltarTexto.Location = new System.Drawing.Point(351, 35);
            this.btnResaltarTexto.Name = "btnResaltarTexto";
            this.btnResaltarTexto.Size = new System.Drawing.Size(26, 23);
            this.btnResaltarTexto.TabIndex = 8;
            this.btnResaltarTexto.UseVisualStyleBackColor = true;
            this.btnResaltarTexto.Click += new System.EventHandler(this.btnResaltarTexto_Click);
            // 
            // btnColorearTexto
            // 
            this.btnColorearTexto.Image = global::Practica9.Properties.Resources.colorear_texto;
            this.btnColorearTexto.Location = new System.Drawing.Point(320, 35);
            this.btnColorearTexto.Name = "btnColorearTexto";
            this.btnColorearTexto.Size = new System.Drawing.Size(25, 23);
            this.btnColorearTexto.TabIndex = 7;
            this.btnColorearTexto.UseVisualStyleBackColor = true;
            this.btnColorearTexto.Click += new System.EventHandler(this.btnColorearTexto_Click);
            // 
            // chckBoxSubIndice
            // 
            this.chckBoxSubIndice.Appearance = System.Windows.Forms.Appearance.Button;
            this.chckBoxSubIndice.AutoSize = true;
            this.chckBoxSubIndice.Image = global::Practica9.Properties.Resources.subindice;
            this.chckBoxSubIndice.Location = new System.Drawing.Point(261, 35);
            this.chckBoxSubIndice.Name = "chckBoxSubIndice";
            this.chckBoxSubIndice.Size = new System.Drawing.Size(22, 23);
            this.chckBoxSubIndice.TabIndex = 14;
            this.chckBoxSubIndice.UseVisualStyleBackColor = true;
            this.chckBoxSubIndice.CheckedChanged += new System.EventHandler(this.chckBoxSubIndice_CheckedChanged);
            // 
            // chckBoxSuperIndice
            // 
            this.chckBoxSuperIndice.Appearance = System.Windows.Forms.Appearance.Button;
            this.chckBoxSuperIndice.AutoSize = true;
            this.chckBoxSuperIndice.Image = global::Practica9.Properties.Resources.superindice;
            this.chckBoxSuperIndice.Location = new System.Drawing.Point(289, 35);
            this.chckBoxSuperIndice.Name = "chckBoxSuperIndice";
            this.chckBoxSuperIndice.Size = new System.Drawing.Size(23, 23);
            this.chckBoxSuperIndice.TabIndex = 13;
            this.chckBoxSuperIndice.UseVisualStyleBackColor = true;
            this.chckBoxSuperIndice.CheckedChanged += new System.EventHandler(this.chckBoxSuperIndice_CheckedChanged);
            // 
            // btnReemplazar
            // 
            this.btnReemplazar.Image = global::Practica9.Properties.Resources.prismaticos;
            this.btnReemplazar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReemplazar.Location = new System.Drawing.Point(448, 35);
            this.btnReemplazar.Name = "btnReemplazar";
            this.btnReemplazar.Size = new System.Drawing.Size(112, 23);
            this.btnReemplazar.TabIndex = 16;
            this.btnReemplazar.Text = "Reemplazar";
            this.btnReemplazar.UseVisualStyleBackColor = true;
            this.btnReemplazar.Click += new System.EventHandler(this.btnReemplazar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::Practica9.Properties.Resources.buscar_texto;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(448, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(84, 23);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnSeleccionarTodo
            // 
            this.btnSeleccionarTodo.Image = global::Practica9.Properties.Resources.seleccionar_todo;
            this.btnSeleccionarTodo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionarTodo.Location = new System.Drawing.Point(448, 64);
            this.btnSeleccionarTodo.Name = "btnSeleccionarTodo";
            this.btnSeleccionarTodo.Size = new System.Drawing.Size(137, 23);
            this.btnSeleccionarTodo.TabIndex = 17;
            this.btnSeleccionarTodo.Text = "Seleccionar todo";
            this.btnSeleccionarTodo.UseVisualStyleBackColor = true;
            this.btnSeleccionarTodo.Click += new System.EventHandler(this.btnSeleccionarTodo_Click);
            // 
            // btnAlinearCentro
            // 
            this.btnAlinearCentro.Image = global::Practica9.Properties.Resources.alinear_centro;
            this.btnAlinearCentro.Location = new System.Drawing.Point(385, 35);
            this.btnAlinearCentro.Name = "btnAlinearCentro";
            this.btnAlinearCentro.Size = new System.Drawing.Size(26, 23);
            this.btnAlinearCentro.TabIndex = 18;
            this.btnAlinearCentro.UseVisualStyleBackColor = true;
            this.btnAlinearCentro.Click += new System.EventHandler(this.btnAlinearCentro_Click);
            // 
            // btnAlinearIzquierda
            // 
            this.btnAlinearIzquierda.Image = global::Practica9.Properties.Resources.alinear_izquierda;
            this.btnAlinearIzquierda.Location = new System.Drawing.Point(385, 3);
            this.btnAlinearIzquierda.Name = "btnAlinearIzquierda";
            this.btnAlinearIzquierda.Size = new System.Drawing.Size(26, 23);
            this.btnAlinearIzquierda.TabIndex = 19;
            this.btnAlinearIzquierda.UseVisualStyleBackColor = true;
            this.btnAlinearIzquierda.Click += new System.EventHandler(this.btnAlinearIzquierda_Click);
            // 
            // btnAlinearJustificado
            // 
            this.btnAlinearJustificado.Image = global::Practica9.Properties.Resources.alinear_justificado;
            this.btnAlinearJustificado.Location = new System.Drawing.Point(417, 35);
            this.btnAlinearJustificado.Name = "btnAlinearJustificado";
            this.btnAlinearJustificado.Size = new System.Drawing.Size(25, 23);
            this.btnAlinearJustificado.TabIndex = 20;
            this.btnAlinearJustificado.UseVisualStyleBackColor = true;
            this.btnAlinearJustificado.Click += new System.EventHandler(this.btnAlinearJustificado_Click);
            // 
            // btnAlinearDerecha
            // 
            this.btnAlinearDerecha.Image = global::Practica9.Properties.Resources.alinear_derecha;
            this.btnAlinearDerecha.Location = new System.Drawing.Point(417, 3);
            this.btnAlinearDerecha.Name = "btnAlinearDerecha";
            this.btnAlinearDerecha.Size = new System.Drawing.Size(25, 23);
            this.btnAlinearDerecha.TabIndex = 21;
            this.btnAlinearDerecha.UseVisualStyleBackColor = true;
            this.btnAlinearDerecha.Click += new System.EventHandler(this.btnAlinearDerecha_Click);
            // 
            // editorTextBox
            // 
            editorTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            editorTextBox.Location = new System.Drawing.Point(0, 207);
            editorTextBox.Name = "editorTextBox";
            editorTextBox.Size = new System.Drawing.Size(800, 243);
            editorTextBox.TabIndex = 4;
            editorTextBox.Text = "";
            editorTextBox.TextChanged += new System.EventHandler(this.editorTextBox_TextChanged);
            // 
            // subMenuVer
            // 
            this.subMenuVer.ColumnCount = 4;
            this.subMenuVer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.subMenuVer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.subMenuVer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.subMenuVer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 434F));
            this.subMenuVer.Controls.Add(this.btnAlejar, 1, 0);
            this.subMenuVer.Controls.Add(this.btnAcercar, 0, 0);
            this.subMenuVer.Controls.Add(this.btnZoom100, 2, 0);
            this.subMenuVer.Controls.Add(this.lblReiniciarZoom, 2, 1);
            this.subMenuVer.Controls.Add(this.lblAlejar, 1, 1);
            this.subMenuVer.Controls.Add(this.lblAcercar, 0, 1);
            this.subMenuVer.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuVer.Location = new System.Drawing.Point(0, 117);
            this.subMenuVer.Name = "subMenuVer";
            this.subMenuVer.RowCount = 2;
            this.subMenuVer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.subMenuVer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.subMenuVer.Size = new System.Drawing.Size(800, 90);
            this.subMenuVer.TabIndex = 5;
            this.subMenuVer.Visible = false;
            // 
            // btnAlejar
            // 
            this.btnAlejar.Image = global::Practica9.Properties.Resources.zoom_out;
            this.btnAlejar.Location = new System.Drawing.Point(57, 3);
            this.btnAlejar.Name = "btnAlejar";
            this.btnAlejar.Size = new System.Drawing.Size(49, 55);
            this.btnAlejar.TabIndex = 0;
            this.btnAlejar.UseVisualStyleBackColor = true;
            this.btnAlejar.Click += new System.EventHandler(this.btnAlejar_Click);
            // 
            // btnAcercar
            // 
            this.btnAcercar.Image = global::Practica9.Properties.Resources.zoom_in;
            this.btnAcercar.Location = new System.Drawing.Point(3, 3);
            this.btnAcercar.Name = "btnAcercar";
            this.btnAcercar.Size = new System.Drawing.Size(48, 55);
            this.btnAcercar.TabIndex = 1;
            this.btnAcercar.UseVisualStyleBackColor = true;
            this.btnAcercar.Click += new System.EventHandler(this.btnAcercar_Click);
            // 
            // btnZoom100
            // 
            this.btnZoom100.Image = global::Practica9.Properties.Resources.zoom_reiniciar;
            this.btnZoom100.Location = new System.Drawing.Point(112, 3);
            this.btnZoom100.Name = "btnZoom100";
            this.btnZoom100.Size = new System.Drawing.Size(49, 55);
            this.btnZoom100.TabIndex = 2;
            this.btnZoom100.UseVisualStyleBackColor = true;
            this.btnZoom100.Click += new System.EventHandler(this.btnZoom100_Click);
            // 
            // lblReiniciarZoom
            // 
            this.lblReiniciarZoom.AutoSize = true;
            this.lblReiniciarZoom.Location = new System.Drawing.Point(112, 61);
            this.lblReiniciarZoom.Name = "lblReiniciarZoom";
            this.lblReiniciarZoom.Size = new System.Drawing.Size(52, 29);
            this.lblReiniciarZoom.TabIndex = 3;
            this.lblReiniciarZoom.Text = "Reiniciar zoom";
            // 
            // lblAlejar
            // 
            this.lblAlejar.AutoSize = true;
            this.lblAlejar.Location = new System.Drawing.Point(57, 61);
            this.lblAlejar.Name = "lblAlejar";
            this.lblAlejar.Size = new System.Drawing.Size(37, 15);
            this.lblAlejar.TabIndex = 4;
            this.lblAlejar.Text = "Alejar";
            // 
            // lblAcercar
            // 
            this.lblAcercar.AutoSize = true;
            this.lblAcercar.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAcercar.Location = new System.Drawing.Point(3, 61);
            this.lblAcercar.Name = "lblAcercar";
            this.lblAcercar.Size = new System.Drawing.Size(48, 15);
            this.lblAcercar.TabIndex = 5;
            this.lblAcercar.Text = "Acercar";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(editorTextBox);
            this.Controls.Add(this.subMenuVer);
            this.Controls.Add(this.subMenuInicio);
            this.Controls.Add(this.menuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "FormMain";
            this.Text = "Editor de textos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.subMenuInicio.ResumeLayout(false);
            this.subMenuInicio.PerformLayout();
            this.subMenuVer.ResumeLayout(false);
            this.subMenuVer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuPrincipal;
        private ToolStripMenuItem menuPrincipalArchivoBtn;
        private ToolStripMenuItem btnArchivoNuevo;
        private ToolStripMenuItem btnArchivoAbrir;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem btnGuardarArchivo;
        private ToolStripMenuItem btnGuardarComoArchivo;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem btnSalir;
        private ToolStripMenuItem menuPrincipalInicioBtn;
        private ToolStripMenuItem menuPrincipalVerBtn;
        private ToolStripButton menuPrincipalAyudaBtn;
        private ToolStripButton menuPrincipalOcultarBtn;
        private TableLayoutPanel subMenuInicio;
        private Button btnPegar;
        private Button btnCopiar;
        private Button btnCortar;
        private ComboBox tamanoFuenteComboBox;
        private ComboBox fuentesComboBox;
        private Button btnColorearTexto;
        private Button btnResaltarTexto;
        private CheckBox chckBoxNegrita;
        private CheckBox chckBoxItalica;
        private CheckBox chckBoxSubrayado;
        private CheckBox chckBoxStrikeout;
        private Button btnSumarTamanoFuente;
        private Button btnRestarTamanoFuente;
        private CheckBox chckBoxSubIndice;
        private CheckBox chckBoxSuperIndice;
        private Button btnBuscar;
        private Button btnReemplazar;
        private Button btnSeleccionarTodo;
        private Button btnAlinearCentro;
        private Button btnAlinearIzquierda;
        private Button btnAlinearJustificado;
        private Button btnAlinearDerecha;
        private TableLayoutPanel subMenuVer;
        private Button btnAlejar;
        private Button btnAcercar;
        private Button btnZoom100;
        private Label lblReiniciarZoom;
        private Label lblAlejar;
        private Label lblAcercar;
        public static RichTextBox editorTextBox;
    }
}