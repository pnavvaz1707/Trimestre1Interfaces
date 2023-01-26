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
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipalInicioBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipalVerBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipalAyudaBtn = new System.Windows.Forms.ToolStripButton();
            this.menuPrincipalOcultarBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripControlHostNumFuente = new System.Windows.Forms.NumericUpDown();
            this.subMenuInicio = new System.Windows.Forms.TableLayoutPanel();
            this.subMenuInicioPortapapeles = new System.Windows.Forms.TableLayoutPanel();
            this.Pegar = new System.Windows.Forms.Label();
            this.btnPegar = new System.Windows.Forms.Button();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.btnCortar = new System.Windows.Forms.Button();
            this.fuentesComboBox = new System.Windows.Forms.ComboBox();
            this.tamanoFuenteComboBox = new System.Windows.Forms.ComboBox();
            this.btnNegrita = new System.Windows.Forms.Button();
            this.btnItalica = new System.Windows.Forms.Button();
            this.btnSubrayar = new System.Windows.Forms.Button();
            this.btnTachar = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolStripControlHostNumFuente)).BeginInit();
            this.subMenuInicio.SuspendLayout();
            this.subMenuInicioPortapapeles.SuspendLayout();
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
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.menuPrincipalArchivoBtn.Name = "menuPrincipalArchivoBtn";
            this.menuPrincipalArchivoBtn.Size = new System.Drawing.Size(60, 23);
            this.menuPrincipalArchivoBtn.Text = "&Archivo";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
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
            // toolStripControlHostNumFuente
            // 
            this.toolStripControlHostNumFuente.AccessibleName = "toolStripControlHostNumFuente";
            this.toolStripControlHostNumFuente.Location = new System.Drawing.Point(207, 1);
            this.toolStripControlHostNumFuente.Name = "toolStripControlHostNumFuente";
            this.toolStripControlHostNumFuente.Size = new System.Drawing.Size(41, 23);
            this.toolStripControlHostNumFuente.TabIndex = 1;
            // 
            // subMenuInicio
            // 
            this.subMenuInicio.ColumnCount = 7;
            this.subMenuInicio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.68511F));
            this.subMenuInicio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.subMenuInicio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.subMenuInicio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.subMenuInicio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.subMenuInicio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.subMenuInicio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 518F));
            this.subMenuInicio.Controls.Add(this.subMenuInicioPortapapeles, 0, 0);
            this.subMenuInicio.Controls.Add(this.fuentesComboBox, 1, 0);
            this.subMenuInicio.Controls.Add(this.tamanoFuenteComboBox, 6, 0);
            this.subMenuInicio.Controls.Add(this.btnNegrita, 2, 1);
            this.subMenuInicio.Controls.Add(this.btnItalica, 3, 1);
            this.subMenuInicio.Controls.Add(this.btnSubrayar, 4, 1);
            this.subMenuInicio.Controls.Add(this.btnTachar, 5, 1);
            this.subMenuInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuInicio.Location = new System.Drawing.Point(0, 27);
            this.subMenuInicio.Name = "subMenuInicio";
            this.subMenuInicio.RowCount = 3;
            this.subMenuInicio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.subMenuInicio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.subMenuInicio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.subMenuInicio.Size = new System.Drawing.Size(800, 90);
            this.subMenuInicio.TabIndex = 3;
            this.subMenuInicio.Visible = false;
            // 
            // subMenuInicioPortapapeles
            // 
            this.subMenuInicioPortapapeles.ColumnCount = 2;
            this.subMenuInicioPortapapeles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.subMenuInicioPortapapeles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.subMenuInicioPortapapeles.Controls.Add(this.Pegar, 0, 2);
            this.subMenuInicioPortapapeles.Controls.Add(this.btnPegar, 0, 0);
            this.subMenuInicioPortapapeles.Controls.Add(this.btnCopiar, 1, 1);
            this.subMenuInicioPortapapeles.Controls.Add(this.btnCortar, 1, 0);
            this.subMenuInicioPortapapeles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subMenuInicioPortapapeles.Location = new System.Drawing.Point(3, 3);
            this.subMenuInicioPortapapeles.Name = "subMenuInicioPortapapeles";
            this.subMenuInicioPortapapeles.RowCount = 3;
            this.subMenuInicio.SetRowSpan(this.subMenuInicioPortapapeles, 3);
            this.subMenuInicioPortapapeles.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.subMenuInicioPortapapeles.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.subMenuInicioPortapapeles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.subMenuInicioPortapapeles.Size = new System.Drawing.Size(148, 84);
            this.subMenuInicioPortapapeles.TabIndex = 0;
            // 
            // Pegar
            // 
            this.Pegar.AutoSize = true;
            this.Pegar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pegar.Location = new System.Drawing.Point(3, 67);
            this.Pegar.Name = "Pegar";
            this.Pegar.Size = new System.Drawing.Size(53, 15);
            this.Pegar.TabIndex = 0;
            this.Pegar.Text = "Pegar";
            this.Pegar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPegar
            // 
            this.btnPegar.Image = global::Practica9.Properties.Resources.portapapeles;
            this.btnPegar.Location = new System.Drawing.Point(3, 3);
            this.btnPegar.Name = "btnPegar";
            this.subMenuInicioPortapapeles.SetRowSpan(this.btnPegar, 2);
            this.btnPegar.Size = new System.Drawing.Size(53, 61);
            this.btnPegar.TabIndex = 1;
            this.btnPegar.UseVisualStyleBackColor = true;
            // 
            // btnCopiar
            // 
            this.btnCopiar.Image = global::Practica9.Properties.Resources.copiar;
            this.btnCopiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCopiar.Location = new System.Drawing.Point(62, 32);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(83, 23);
            this.btnCopiar.TabIndex = 3;
            this.btnCopiar.Text = "Copiar";
            this.btnCopiar.UseVisualStyleBackColor = true;
            // 
            // btnCortar
            // 
            this.btnCortar.Image = global::Practica9.Properties.Resources.tijeras;
            this.btnCortar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCortar.Location = new System.Drawing.Point(62, 3);
            this.btnCortar.Name = "btnCortar";
            this.btnCortar.Size = new System.Drawing.Size(83, 23);
            this.btnCortar.TabIndex = 2;
            this.btnCortar.Text = "Cortar";
            this.btnCortar.UseVisualStyleBackColor = true;
            // 
            // fuentesComboBox
            // 
            this.subMenuInicio.SetColumnSpan(this.fuentesComboBox, 5);
            this.fuentesComboBox.FormattingEnabled = true;
            this.fuentesComboBox.Location = new System.Drawing.Point(157, 3);
            this.fuentesComboBox.Name = "fuentesComboBox";
            this.fuentesComboBox.Size = new System.Drawing.Size(121, 23);
            this.fuentesComboBox.TabIndex = 1;
            this.fuentesComboBox.SelectedValueChanged += new System.EventHandler(this.fuentesComboBox_SelectedValueChanged);
            // 
            // tamanoFuenteComboBox
            // 
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
            this.tamanoFuenteComboBox.Location = new System.Drawing.Point(285, 3);
            this.tamanoFuenteComboBox.Name = "tamanoFuenteComboBox";
            this.tamanoFuenteComboBox.Size = new System.Drawing.Size(56, 23);
            this.tamanoFuenteComboBox.TabIndex = 2;
            this.tamanoFuenteComboBox.SelectedValueChanged += new System.EventHandler(this.tamanoFuenteComboBox_SelectedValueChanged);
            // 
            // btnNegrita
            // 
            this.btnNegrita.Image = ((System.Drawing.Image)(resources.GetObject("btnNegrita.Image")));
            this.btnNegrita.Location = new System.Drawing.Point(157, 35);
            this.btnNegrita.Name = "btnNegrita";
            this.btnNegrita.Size = new System.Drawing.Size(26, 23);
            this.btnNegrita.TabIndex = 3;
            this.btnNegrita.UseVisualStyleBackColor = true;
            this.btnNegrita.Click += new System.EventHandler(this.btnNegrita_Click);
            // 
            // btnItalica
            // 
            this.btnItalica.Image = ((System.Drawing.Image)(resources.GetObject("btnItalica.Image")));
            this.btnItalica.Location = new System.Drawing.Point(189, 35);
            this.btnItalica.Name = "btnItalica";
            this.btnItalica.Size = new System.Drawing.Size(26, 23);
            this.btnItalica.TabIndex = 4;
            this.btnItalica.UseVisualStyleBackColor = true;
            this.btnItalica.Click += new System.EventHandler(this.btnItalica_Click);
            // 
            // btnSubrayar
            // 
            this.btnSubrayar.Image = ((System.Drawing.Image)(resources.GetObject("btnSubrayar.Image")));
            this.btnSubrayar.Location = new System.Drawing.Point(221, 35);
            this.btnSubrayar.Name = "btnSubrayar";
            this.btnSubrayar.Size = new System.Drawing.Size(26, 23);
            this.btnSubrayar.TabIndex = 5;
            this.btnSubrayar.UseVisualStyleBackColor = true;
            this.btnSubrayar.Click += new System.EventHandler(this.btnSubrayar_Click);
            // 
            // btnTachar
            // 
            this.btnTachar.Image = ((System.Drawing.Image)(resources.GetObject("btnTachar.Image")));
            this.btnTachar.Location = new System.Drawing.Point(253, 35);
            this.btnTachar.Name = "btnTachar";
            this.btnTachar.Size = new System.Drawing.Size(26, 23);
            this.btnTachar.TabIndex = 6;
            this.btnTachar.UseVisualStyleBackColor = true;
            this.btnTachar.Click += new System.EventHandler(this.btnTachar_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 117);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 333);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.subMenuInicio);
            this.Controls.Add(this.menuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "FormMain";
            this.Text = "Editor de textos";
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolStripControlHostNumFuente)).EndInit();
            this.subMenuInicio.ResumeLayout(false);
            this.subMenuInicioPortapapeles.ResumeLayout(false);
            this.subMenuInicioPortapapeles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuPrincipal;
        private ToolStripMenuItem menuPrincipalArchivoBtn;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem printToolStripMenuItem;
        private ToolStripMenuItem printPreviewToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem menuPrincipalInicioBtn;
        private ToolStripMenuItem menuPrincipalVerBtn;
        private ToolStripButton menuPrincipalAyudaBtn;
        private ToolStripButton menuPrincipalOcultarBtn;
        private TableLayoutPanel subMenuInicio;
        private TableLayoutPanel subMenuInicioPortapapeles;
        private Label Pegar;
        private Button btnPegar;
        private Button btnCopiar;
        private Button btnCortar;
        private NumericUpDown toolStripControlHostNumFuente;
        private RichTextBox richTextBox1;
        private ComboBox tamanoFuenteComboBox;
        private ComboBox fuentesComboBox;
        private Button btnNegrita;
        private Button btnItalica;
        private Button btnSubrayar;
        private Button btnTachar;
    }
}