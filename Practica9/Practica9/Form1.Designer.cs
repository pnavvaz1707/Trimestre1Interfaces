namespace Practica9
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.subMenuInicio = new System.Windows.Forms.ToolStrip();
            this.subMenuVer = new System.Windows.Forms.ToolStrip();
            this.menuPrincipal.SuspendLayout();
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
            this.menuPrincipalOcultarBtn.Image = ((System.Drawing.Image)(resources.GetObject("flecha_arriba")));
            this.menuPrincipalOcultarBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuPrincipalOcultarBtn.Name = "menuPrincipalOcultarBtn";
            this.menuPrincipalOcultarBtn.Size = new System.Drawing.Size(23, 20);
            this.menuPrincipalOcultarBtn.Text = "Ocultar";
            this.menuPrincipalOcultarBtn.Click += new System.EventHandler(this.menuPrincipalOcultarBtn_Click);
            // 
            // subMenuInicio
            // 
            this.subMenuInicio.Location = new System.Drawing.Point(0, 27);
            this.subMenuInicio.Name = "subMenuInicio";
            this.subMenuInicio.Size = new System.Drawing.Size(800, 25);
            this.subMenuInicio.TabIndex = 1;
            this.subMenuInicio.Text = "toolStrip1";
            this.subMenuInicio.Visible = false;
            // 
            // subMenuVer
            // 
            this.subMenuVer.Location = new System.Drawing.Point(0, 27);
            this.subMenuVer.Name = "subMenuVer";
            this.subMenuVer.Size = new System.Drawing.Size(800, 25);
            this.subMenuVer.TabIndex = 2;
            this.subMenuVer.Text = "toolStrip1";
            this.subMenuVer.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.subMenuVer);
            this.Controls.Add(this.subMenuInicio);
            this.Controls.Add(this.menuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "Form1";
            this.Text = "Editor de textos";
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
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
        private ToolStrip subMenuInicio;
        private ToolStrip subMenuVer;
    }
}