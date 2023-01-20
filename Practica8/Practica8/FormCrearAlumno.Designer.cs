namespace Practica8
{
    partial class FormCrearAlumno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCrearAlumno));
            this.txtNombreAlumnoNuevo = new System.Windows.Forms.TextBox();
            this.lblNombreAlumnoNuevo = new System.Windows.Forms.Label();
            this.btnCrearAlumno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombreAlumnoNuevo
            // 
            this.txtNombreAlumnoNuevo.Location = new System.Drawing.Point(99, 43);
            this.txtNombreAlumnoNuevo.Name = "txtNombreAlumnoNuevo";
            this.txtNombreAlumnoNuevo.Size = new System.Drawing.Size(100, 23);
            this.txtNombreAlumnoNuevo.TabIndex = 0;
            // 
            // lblNombreAlumnoNuevo
            // 
            this.lblNombreAlumnoNuevo.AutoSize = true;
            this.lblNombreAlumnoNuevo.Location = new System.Drawing.Point(42, 46);
            this.lblNombreAlumnoNuevo.Name = "lblNombreAlumnoNuevo";
            this.lblNombreAlumnoNuevo.Size = new System.Drawing.Size(51, 15);
            this.lblNombreAlumnoNuevo.TabIndex = 1;
            this.lblNombreAlumnoNuevo.Text = "Nombre";
            // 
            // btnCrearAlumno
            // 
            this.btnCrearAlumno.Location = new System.Drawing.Point(654, 30);
            this.btnCrearAlumno.Name = "btnCrearAlumno";
            this.btnCrearAlumno.Size = new System.Drawing.Size(109, 46);
            this.btnCrearAlumno.TabIndex = 10;
            this.btnCrearAlumno.Text = "Crear";
            this.btnCrearAlumno.UseVisualStyleBackColor = true;
            this.btnCrearAlumno.Click += new System.EventHandler(this.btnCrearAlumno_Click);
            // 
            // FormCrearAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 188);
            this.Controls.Add(this.btnCrearAlumno);
            this.Controls.Add(this.lblNombreAlumnoNuevo);
            this.Controls.Add(this.txtNombreAlumnoNuevo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCrearAlumno";
            this.Text = "FormCrearAlumno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNombreAlumnoNuevo;
        private Label lblNombreAlumnoNuevo;
        private Button btnCrearAlumno;
    }
}