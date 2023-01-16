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
            this.txtNombreEditarGrupo = new System.Windows.Forms.TextBox();
            this.lblNombreEditarGrupo = new System.Windows.Forms.Label();
            this.chckBoxEditarENDE = new System.Windows.Forms.CheckBox();
            this.chckBoxEditarDI = new System.Windows.Forms.CheckBox();
            this.chckBoxEditarPRO = new System.Windows.Forms.CheckBox();
            this.chckBoxEditarLEMA = new System.Windows.Forms.CheckBox();
            this.chckBoxEditarSIGE = new System.Windows.Forms.CheckBox();
            this.chckBoxEditarFOL = new System.Windows.Forms.CheckBox();
            this.btnEditarGrupo = new System.Windows.Forms.Button();
            this.dtgvAlumnos = new System.Windows.Forms.DataGridView();
            this.btnAgregarAlumno = new System.Windows.Forms.Button();
            this.btnBorrarAlumno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGrupos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(422, 312);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(105, 49);
            this.btnImportar.TabIndex = 1;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(533, 312);
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
            this.lblTitulo.Location = new System.Drawing.Point(247, 2);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(236, 36);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Gestíon de grupos";
            // 
            // dtgvGrupos
            // 
            this.dtgvGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvGrupos.Location = new System.Drawing.Point(106, 51);
            this.dtgvGrupos.Name = "dtgvGrupos";
            this.dtgvGrupos.RowTemplate.Height = 25;
            this.dtgvGrupos.Size = new System.Drawing.Size(532, 255);
            this.dtgvGrupos.TabIndex = 5;
            // 
            // txtNombreEditarGrupo
            // 
            this.txtNombreEditarGrupo.Location = new System.Drawing.Point(162, 407);
            this.txtNombreEditarGrupo.Name = "txtNombreEditarGrupo";
            this.txtNombreEditarGrupo.Size = new System.Drawing.Size(100, 23);
            this.txtNombreEditarGrupo.TabIndex = 20;
            // 
            // lblNombreEditarGrupo
            // 
            this.lblNombreEditarGrupo.AutoSize = true;
            this.lblNombreEditarGrupo.Location = new System.Drawing.Point(105, 410);
            this.lblNombreEditarGrupo.Name = "lblNombreEditarGrupo";
            this.lblNombreEditarGrupo.Size = new System.Drawing.Size(51, 15);
            this.lblNombreEditarGrupo.TabIndex = 27;
            this.lblNombreEditarGrupo.Text = "Nombre";
            // 
            // chckBoxEditarENDE
            // 
            this.chckBoxEditarENDE.AutoSize = true;
            this.chckBoxEditarENDE.Location = new System.Drawing.Point(436, 411);
            this.chckBoxEditarENDE.Name = "chckBoxEditarENDE";
            this.chckBoxEditarENDE.Size = new System.Drawing.Size(55, 19);
            this.chckBoxEditarENDE.TabIndex = 23;
            this.chckBoxEditarENDE.Text = "ENDE";
            this.chckBoxEditarENDE.UseVisualStyleBackColor = true;
            // 
            // chckBoxEditarDI
            // 
            this.chckBoxEditarDI.AutoSize = true;
            this.chckBoxEditarDI.Location = new System.Drawing.Point(605, 411);
            this.chckBoxEditarDI.Name = "chckBoxEditarDI";
            this.chckBoxEditarDI.Size = new System.Drawing.Size(37, 19);
            this.chckBoxEditarDI.TabIndex = 26;
            this.chckBoxEditarDI.Text = "DI";
            this.chckBoxEditarDI.UseVisualStyleBackColor = true;
            // 
            // chckBoxEditarPRO
            // 
            this.chckBoxEditarPRO.AutoSize = true;
            this.chckBoxEditarPRO.Location = new System.Drawing.Point(381, 411);
            this.chckBoxEditarPRO.Name = "chckBoxEditarPRO";
            this.chckBoxEditarPRO.Size = new System.Drawing.Size(49, 19);
            this.chckBoxEditarPRO.TabIndex = 22;
            this.chckBoxEditarPRO.Text = "PRO";
            this.chckBoxEditarPRO.UseVisualStyleBackColor = true;
            // 
            // chckBoxEditarLEMA
            // 
            this.chckBoxEditarLEMA.AutoSize = true;
            this.chckBoxEditarLEMA.Location = new System.Drawing.Point(316, 411);
            this.chckBoxEditarLEMA.Name = "chckBoxEditarLEMA";
            this.chckBoxEditarLEMA.Size = new System.Drawing.Size(57, 19);
            this.chckBoxEditarLEMA.TabIndex = 21;
            this.chckBoxEditarLEMA.Text = "LEMA";
            this.chckBoxEditarLEMA.UseVisualStyleBackColor = true;
            // 
            // chckBoxEditarSIGE
            // 
            this.chckBoxEditarSIGE.AutoSize = true;
            this.chckBoxEditarSIGE.Location = new System.Drawing.Point(550, 411);
            this.chckBoxEditarSIGE.Name = "chckBoxEditarSIGE";
            this.chckBoxEditarSIGE.Size = new System.Drawing.Size(49, 19);
            this.chckBoxEditarSIGE.TabIndex = 25;
            this.chckBoxEditarSIGE.Text = "SIGE";
            this.chckBoxEditarSIGE.UseVisualStyleBackColor = true;
            // 
            // chckBoxEditarFOL
            // 
            this.chckBoxEditarFOL.AutoSize = true;
            this.chckBoxEditarFOL.Location = new System.Drawing.Point(497, 411);
            this.chckBoxEditarFOL.Name = "chckBoxEditarFOL";
            this.chckBoxEditarFOL.Size = new System.Drawing.Size(47, 19);
            this.chckBoxEditarFOL.TabIndex = 24;
            this.chckBoxEditarFOL.Text = "FOL";
            this.chckBoxEditarFOL.UseVisualStyleBackColor = true;
            // 
            // btnEditarGrupo
            // 
            this.btnEditarGrupo.Location = new System.Drawing.Point(533, 688);
            this.btnEditarGrupo.Name = "btnEditarGrupo";
            this.btnEditarGrupo.Size = new System.Drawing.Size(105, 49);
            this.btnEditarGrupo.TabIndex = 28;
            this.btnEditarGrupo.Text = "Editar";
            this.btnEditarGrupo.UseVisualStyleBackColor = true;
            // 
            // dtgvAlumnos
            // 
            this.dtgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAlumnos.Location = new System.Drawing.Point(106, 446);
            this.dtgvAlumnos.Name = "dtgvAlumnos";
            this.dtgvAlumnos.RowTemplate.Height = 25;
            this.dtgvAlumnos.Size = new System.Drawing.Size(532, 162);
            this.dtgvAlumnos.TabIndex = 29;
            // 
            // btnAgregarAlumno
            // 
            this.btnAgregarAlumno.Location = new System.Drawing.Point(533, 614);
            this.btnAgregarAlumno.Name = "btnAgregarAlumno";
            this.btnAgregarAlumno.Size = new System.Drawing.Size(105, 49);
            this.btnAgregarAlumno.TabIndex = 30;
            this.btnAgregarAlumno.Text = "Agregar alumno";
            this.btnAgregarAlumno.UseVisualStyleBackColor = true;
            this.btnAgregarAlumno.Click += new System.EventHandler(this.btnAgregarAlumno_Click);
            // 
            // btnBorrarAlumno
            // 
            this.btnBorrarAlumno.Location = new System.Drawing.Point(422, 614);
            this.btnBorrarAlumno.Name = "btnBorrarAlumno";
            this.btnBorrarAlumno.Size = new System.Drawing.Size(105, 49);
            this.btnBorrarAlumno.TabIndex = 31;
            this.btnBorrarAlumno.Text = "Borrar Alumno";
            this.btnBorrarAlumno.UseVisualStyleBackColor = true;
            this.btnBorrarAlumno.Click += new System.EventHandler(this.btnBorrarAlumno_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(762, 749);
            this.Controls.Add(this.btnBorrarAlumno);
            this.Controls.Add(this.btnAgregarAlumno);
            this.Controls.Add(this.dtgvAlumnos);
            this.Controls.Add(this.txtNombreEditarGrupo);
            this.Controls.Add(this.lblNombreEditarGrupo);
            this.Controls.Add(this.chckBoxEditarENDE);
            this.Controls.Add(this.chckBoxEditarDI);
            this.Controls.Add(this.chckBoxEditarPRO);
            this.Controls.Add(this.chckBoxEditarLEMA);
            this.Controls.Add(this.chckBoxEditarSIGE);
            this.Controls.Add(this.chckBoxEditarFOL);
            this.Controls.Add(this.btnEditarGrupo);
            this.Controls.Add(this.dtgvGrupos);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnImportar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Gestión de grupos";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGrupos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnImportar;
        private Button btnNuevo;
        private Label lblTitulo;
        private DataGridView dtgvGrupos;
        private TextBox txtNombreEditarGrupo;
        private Label lblNombreEditarGrupo;
        private CheckBox chckBoxEditarENDE;
        private CheckBox chckBoxEditarDI;
        private CheckBox chckBoxEditarPRO;
        private CheckBox chckBoxEditarLEMA;
        private CheckBox chckBoxEditarSIGE;
        private CheckBox chckBoxEditarFOL;
        private Button btnEditarGrupo;
        private DataGridView dtgvAlumnos;
        private Button btnAgregarAlumno;
        private Button btnBorrarAlumno;
    }
}