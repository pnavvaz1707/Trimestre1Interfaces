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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombreGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asignaturasGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpListaGrupos = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreGrupo,
            this.asignaturasGrupo});
            this.dataGridView1.Location = new System.Drawing.Point(115, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(543, 242);
            this.dataGridView1.TabIndex = 0;
            // 
            // nombreGrupo
            // 
            this.nombreGrupo.HeaderText = "Nombre";
            this.nombreGrupo.Name = "nombreGrupo";
            this.nombreGrupo.ReadOnly = true;
            this.nombreGrupo.Width = 150;
            // 
            // asignaturasGrupo
            // 
            this.asignaturasGrupo.HeaderText = "Asignaturas";
            this.asignaturasGrupo.Name = "asignaturasGrupo";
            this.asignaturasGrupo.ReadOnly = true;
            this.asignaturasGrupo.Width = 350;
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(331, 338);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(105, 49);
            this.btnImportar.TabIndex = 1;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(553, 338);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(105, 49);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(442, 338);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(105, 49);
            this.btnSeleccionar.TabIndex = 3;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(267, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(236, 36);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Gestíon de grupos";
            // 
            // grpListaGrupos
            // 
            this.grpListaGrupos.Location = new System.Drawing.Point(81, 17);
            this.grpListaGrupos.Name = "grpListaGrupos";
            this.grpListaGrupos.Size = new System.Drawing.Size(611, 390);
            this.grpListaGrupos.TabIndex = 5;
            this.grpListaGrupos.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpListaGrupos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Gestión de grupos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nombreGrupo;
        private DataGridViewTextBoxColumn asignaturasGrupo;
        private Button btnImportar;
        private Button btnNuevo;
        private Button btnSeleccionar;
        private Label lblTitulo;
        private GroupBox grpListaGrupos;
    }
}