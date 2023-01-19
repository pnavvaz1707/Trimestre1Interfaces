/*
* PRÁCTICA.............: Práctica 8
* NOMBRE y APELLIDOS...: Pablo Navarro Vázquez
* CURSO y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO de la PRÁCTICA: Uso del IDE V.Studio
* FECHA de ENTREGA.....: 12 de Enero de 2023
*/

namespace Practica8
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
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dtgvGrupos = new System.Windows.Forms.DataGridView();
            this.dtgvAlumnos = new System.Windows.Forms.DataGridView();
            this.btnAgregarAlumno = new System.Windows.Forms.Button();
            this.btnBorrarAlumno = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNuevoBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbrirBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuSalirBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAcercaDeBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGrupos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAlumnos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(399, 275);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(105, 49);
            this.btnImportar.TabIndex = 1;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(510, 275);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(105, 49);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(226, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(236, 36);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Gestíon de grupos";
            // 
            // dtgvGrupos
            // 
            this.dtgvGrupos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvGrupos.Location = new System.Drawing.Point(45, 71);
            this.dtgvGrupos.Name = "dtgvGrupos";
            this.dtgvGrupos.RowTemplate.Height = 25;
            this.dtgvGrupos.Size = new System.Drawing.Size(570, 198);
            this.dtgvGrupos.TabIndex = 5;
            this.dtgvGrupos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvGrupos_RowEnter);
            // 
            // dtgvAlumnos
            // 
            this.dtgvAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAlumnos.Location = new System.Drawing.Point(45, 414);
            this.dtgvAlumnos.Name = "dtgvAlumnos";
            this.dtgvAlumnos.RowTemplate.Height = 25;
            this.dtgvAlumnos.Size = new System.Drawing.Size(570, 240);
            this.dtgvAlumnos.TabIndex = 29;
            // 
            // btnAgregarAlumno
            // 
            this.btnAgregarAlumno.Location = new System.Drawing.Point(510, 660);
            this.btnAgregarAlumno.Name = "btnAgregarAlumno";
            this.btnAgregarAlumno.Size = new System.Drawing.Size(105, 49);
            this.btnAgregarAlumno.TabIndex = 30;
            this.btnAgregarAlumno.Text = "Agregar alumno";
            this.btnAgregarAlumno.UseVisualStyleBackColor = true;
            this.btnAgregarAlumno.Click += new System.EventHandler(this.btnAgregarAlumno_Click);
            // 
            // btnBorrarAlumno
            // 
            this.btnBorrarAlumno.Location = new System.Drawing.Point(399, 660);
            this.btnBorrarAlumno.Name = "btnBorrarAlumno";
            this.btnBorrarAlumno.Size = new System.Drawing.Size(105, 49);
            this.btnBorrarAlumno.TabIndex = 31;
            this.btnBorrarAlumno.Text = "Borrar Alumno";
            this.btnBorrarAlumno.UseVisualStyleBackColor = true;
            this.btnBorrarAlumno.Click += new System.EventHandler(this.btnBorrarAlumno_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArchivo,
            this.menuAyuda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(663, 24);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuArchivo
            // 
            this.menuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNuevoBtn,
            this.menuAbrirBtn,
            this.toolStripSeparator,
            this.menuSalirBtn});
            this.menuArchivo.Name = "menuArchivo";
            this.menuArchivo.Size = new System.Drawing.Size(60, 20);
            this.menuArchivo.Text = "&Archivo";
            // 
            // menuNuevoBtn
            // 
            this.menuNuevoBtn.Image = ((System.Drawing.Image)(resources.GetObject("menuNuevoBtn.Image")));
            this.menuNuevoBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuNuevoBtn.Name = "menuNuevoBtn";
            this.menuNuevoBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuNuevoBtn.Size = new System.Drawing.Size(180, 22);
            this.menuNuevoBtn.Text = "&Nuevo";
            // 
            // menuAbrirBtn
            // 
            this.menuAbrirBtn.Image = ((System.Drawing.Image)(resources.GetObject("menuAbrirBtn.Image")));
            this.menuAbrirBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuAbrirBtn.Name = "menuAbrirBtn";
            this.menuAbrirBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuAbrirBtn.Size = new System.Drawing.Size(180, 22);
            this.menuAbrirBtn.Text = "&Abrir";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // menuSalirBtn
            // 
            this.menuSalirBtn.Name = "menuSalirBtn";
            this.menuSalirBtn.Size = new System.Drawing.Size(180, 22);
            this.menuSalirBtn.Text = "&Salir";
            // 
            // menuAyuda
            // 
            this.menuAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAcercaDeBtn});
            this.menuAyuda.Name = "menuAyuda";
            this.menuAyuda.Size = new System.Drawing.Size(53, 20);
            this.menuAyuda.Text = "&Ayuda";
            // 
            // menuAcercaDeBtn
            // 
            this.menuAcercaDeBtn.Name = "menuAcercaDeBtn";
            this.menuAcercaDeBtn.Size = new System.Drawing.Size(180, 22);
            this.menuAcercaDeBtn.Text = "&Acerca de...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(216, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 36);
            this.label1.TabIndex = 33;
            this.label1.Text = "Lista de alumnos";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(663, 749);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBorrarAlumno);
            this.Controls.Add(this.btnAgregarAlumno);
            this.Controls.Add(this.dtgvAlumnos);
            this.Controls.Add(this.dtgvGrupos);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Gestión de grupos";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGrupos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAlumnos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnImportar;
        private Button btnNuevo;
        private Label lblTitulo;
        private DataGridView dtgvGrupos;
        private DataGridView dtgvAlumnos;
        private Button btnAgregarAlumno;
        private Button btnBorrarAlumno;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuArchivo;
        private ToolStripMenuItem menuNuevoBtn;
        private ToolStripMenuItem menuAbrirBtn;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem menuSalirBtn;
        private ToolStripMenuItem menuAyuda;
        private ToolStripMenuItem menuAcercaDeBtn;
        private Label label1;
    }
}