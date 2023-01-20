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
            this.lblNota1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblNota4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnCrearAlumno = new System.Windows.Forms.Button();
            this.grpNotas = new System.Windows.Forms.GroupBox();
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
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Location = new System.Drawing.Point(219, 46);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(27, 15);
            this.lblNota1.TabIndex = 3;
            this.lblNota1.Text = "----";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(263, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(38, 23);
            this.textBox1.TabIndex = 2;
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Location = new System.Drawing.Point(313, 46);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(27, 15);
            this.lblNota2.TabIndex = 5;
            this.lblNota2.Text = "----";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(357, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(38, 23);
            this.textBox2.TabIndex = 4;
            // 
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.Location = new System.Drawing.Point(410, 46);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(27, 15);
            this.lblNota3.TabIndex = 7;
            this.lblNota3.Text = "----";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(443, 43);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(38, 23);
            this.textBox3.TabIndex = 6;
            // 
            // lblNota4
            // 
            this.lblNota4.AutoSize = true;
            this.lblNota4.Location = new System.Drawing.Point(499, 46);
            this.lblNota4.Name = "lblNota4";
            this.lblNota4.Size = new System.Drawing.Size(27, 15);
            this.lblNota4.TabIndex = 9;
            this.lblNota4.Text = "----";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(541, 43);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(38, 23);
            this.textBox4.TabIndex = 8;
            // 
            // btnCrearAlumno
            // 
            this.btnCrearAlumno.Location = new System.Drawing.Point(628, 30);
            this.btnCrearAlumno.Name = "btnCrearAlumno";
            this.btnCrearAlumno.Size = new System.Drawing.Size(109, 46);
            this.btnCrearAlumno.TabIndex = 10;
            this.btnCrearAlumno.Text = "Crear";
            this.btnCrearAlumno.UseVisualStyleBackColor = true;
            this.btnCrearAlumno.Click += new System.EventHandler(this.btnCrearAlumno_Click);
            // 
            // grpNotas
            // 
            this.grpNotas.Location = new System.Drawing.Point(205, 13);
            this.grpNotas.Name = "grpNotas";
            this.grpNotas.Size = new System.Drawing.Size(382, 83);
            this.grpNotas.TabIndex = 11;
            this.grpNotas.TabStop = false;
            // 
            // FormCrearAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 108);
            this.Controls.Add(this.btnCrearAlumno);
            this.Controls.Add(this.lblNota4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lblNota3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblNota2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblNota1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNombreAlumnoNuevo);
            this.Controls.Add(this.txtNombreAlumnoNuevo);
            this.Controls.Add(this.grpNotas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCrearAlumno";
            this.Text = "FormCrearAlumno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNombreAlumnoNuevo;
        private Label lblNombreAlumnoNuevo;
        private Label lblNota1;
        private TextBox textBox1;
        private Label lblNota2;
        private TextBox textBox2;
        private Label lblNota3;
        private TextBox textBox3;
        private Label lblNota4;
        private TextBox textBox4;
        private Button btnCrearAlumno;
        private GroupBox grpNotas;
    }
}