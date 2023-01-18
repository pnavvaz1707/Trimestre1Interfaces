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
            this.btnEditarGrupo = new System.Windows.Forms.Button();
            this.dtgvAlumnos = new System.Windows.Forms.DataGridView();
            this.btnAgregarAlumno = new System.Windows.Forms.Button();
            this.btnBorrarAlumno = new System.Windows.Forms.Button();
            this.lstAsignaturasEditarGrupo = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGrupos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(399, 306);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(105, 49);
            this.btnImportar.TabIndex = 1;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(510, 306);
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
            this.lblTitulo.Location = new System.Drawing.Point(226, 3);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(236, 36);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Gestíon de grupos";
            // 
            // dtgvGrupos
            // 
            this.dtgvGrupos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvGrupos.Location = new System.Drawing.Point(45, 45);
            this.dtgvGrupos.Name = "dtgvGrupos";
            this.dtgvGrupos.RowTemplate.Height = 25;
            this.dtgvGrupos.Size = new System.Drawing.Size(570, 255);
            this.dtgvGrupos.TabIndex = 5;
            this.dtgvGrupos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvGrupos_RowEnter);
            // 
            // txtNombreEditarGrupo
            // 
            this.txtNombreEditarGrupo.Location = new System.Drawing.Point(101, 401);
            this.txtNombreEditarGrupo.Name = "txtNombreEditarGrupo";
            this.txtNombreEditarGrupo.Size = new System.Drawing.Size(100, 23);
            this.txtNombreEditarGrupo.TabIndex = 20;
            // 
            // lblNombreEditarGrupo
            // 
            this.lblNombreEditarGrupo.AutoSize = true;
            this.lblNombreEditarGrupo.Location = new System.Drawing.Point(44, 404);
            this.lblNombreEditarGrupo.Name = "lblNombreEditarGrupo";
            this.lblNombreEditarGrupo.Size = new System.Drawing.Size(51, 15);
            this.lblNombreEditarGrupo.TabIndex = 27;
            this.lblNombreEditarGrupo.Text = "Nombre";
            // 
            // btnEditarGrupo
            // 
            this.btnEditarGrupo.Location = new System.Drawing.Point(510, 688);
            this.btnEditarGrupo.Name = "btnEditarGrupo";
            this.btnEditarGrupo.Size = new System.Drawing.Size(105, 49);
            this.btnEditarGrupo.TabIndex = 28;
            this.btnEditarGrupo.Text = "Guardar";
            this.btnEditarGrupo.UseVisualStyleBackColor = true;
            // 
            // dtgvAlumnos
            // 
            this.dtgvAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAlumnos.Location = new System.Drawing.Point(226, 404);
            this.dtgvAlumnos.Name = "dtgvAlumnos";
            this.dtgvAlumnos.RowTemplate.Height = 25;
            this.dtgvAlumnos.Size = new System.Drawing.Size(389, 198);
            this.dtgvAlumnos.TabIndex = 29;
            // 
            // btnAgregarAlumno
            // 
            this.btnAgregarAlumno.Location = new System.Drawing.Point(510, 608);
            this.btnAgregarAlumno.Name = "btnAgregarAlumno";
            this.btnAgregarAlumno.Size = new System.Drawing.Size(105, 49);
            this.btnAgregarAlumno.TabIndex = 30;
            this.btnAgregarAlumno.Text = "Agregar alumno";
            this.btnAgregarAlumno.UseVisualStyleBackColor = true;
            this.btnAgregarAlumno.Click += new System.EventHandler(this.btnAgregarAlumno_Click);
            // 
            // btnBorrarAlumno
            // 
            this.btnBorrarAlumno.Location = new System.Drawing.Point(399, 608);
            this.btnBorrarAlumno.Name = "btnBorrarAlumno";
            this.btnBorrarAlumno.Size = new System.Drawing.Size(105, 49);
            this.btnBorrarAlumno.TabIndex = 31;
            this.btnBorrarAlumno.Text = "Borrar Alumno";
            this.btnBorrarAlumno.UseVisualStyleBackColor = true;
            this.btnBorrarAlumno.Click += new System.EventHandler(this.btnBorrarAlumno_Click);
            // 
            // lstAsignaturasEditarGrupo
            // 
            this.lstAsignaturasEditarGrupo.FormattingEnabled = true;
            this.lstAsignaturasEditarGrupo.Items.AddRange(new object[] {
            "LEMA",
            "PRO",
            "ENDE",
            "FOL",
            "SIGE",
            "DI"});
            this.lstAsignaturasEditarGrupo.Location = new System.Drawing.Point(45, 456);
            this.lstAsignaturasEditarGrupo.Name = "lstAsignaturasEditarGrupo";
            this.lstAsignaturasEditarGrupo.Size = new System.Drawing.Size(120, 94);
            this.lstAsignaturasEditarGrupo.TabIndex = 32;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(663, 749);
            this.Controls.Add(this.lstAsignaturasEditarGrupo);
            this.Controls.Add(this.btnBorrarAlumno);
            this.Controls.Add(this.btnAgregarAlumno);
            this.Controls.Add(this.dtgvAlumnos);
            this.Controls.Add(this.txtNombreEditarGrupo);
            this.Controls.Add(this.lblNombreEditarGrupo);
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
        private Button btnEditarGrupo;
        private DataGridView dtgvAlumnos;
        private Button btnAgregarAlumno;
        private Button btnBorrarAlumno;
        private CheckedListBox lstAsignaturasEditarGrupo;
    }
}