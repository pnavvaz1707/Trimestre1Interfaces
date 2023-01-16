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
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGrupos)).BeginInit();
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
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(762, 681);
            this.Controls.Add(this.dtgvGrupos);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnImportar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Gestión de grupos";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGrupos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnImportar;
        private Button btnNuevo;
        private Label lblTitulo;
        private DataGridView dtgvGrupos;
    }
}