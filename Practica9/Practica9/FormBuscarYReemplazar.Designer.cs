namespace Practica9
{
    partial class FormBuscarYReemplazar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscarYReemplazar));
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBoxBuscar = new System.Windows.Forms.TextBox();
            this.txtBoxReemplazar = new System.Windows.Forms.TextBox();
            this.lblReemplazar = new System.Windows.Forms.Label();
            this.btnBuscarSiguiente = new System.Windows.Forms.Button();
            this.btnReemplazar = new System.Windows.Forms.Button();
            this.btnReemplazarTodo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(12, 23);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(42, 15);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Buscar";
            // 
            // txtBoxBuscar
            // 
            this.txtBoxBuscar.Location = new System.Drawing.Point(86, 20);
            this.txtBoxBuscar.Name = "txtBoxBuscar";
            this.txtBoxBuscar.Size = new System.Drawing.Size(100, 23);
            this.txtBoxBuscar.TabIndex = 1;
            this.txtBoxBuscar.TextChanged += new System.EventHandler(this.txtBoxBuscar_TextChanged);
            // 
            // txtBoxReemplazar
            // 
            this.txtBoxReemplazar.Enabled = false;
            this.txtBoxReemplazar.Location = new System.Drawing.Point(86, 55);
            this.txtBoxReemplazar.Name = "txtBoxReemplazar";
            this.txtBoxReemplazar.Size = new System.Drawing.Size(100, 23);
            this.txtBoxReemplazar.TabIndex = 3;
            this.txtBoxReemplazar.TextChanged += new System.EventHandler(this.txtBoxReemplazar_TextChanged);
            // 
            // lblReemplazar
            // 
            this.lblReemplazar.AutoSize = true;
            this.lblReemplazar.Location = new System.Drawing.Point(12, 58);
            this.lblReemplazar.Name = "lblReemplazar";
            this.lblReemplazar.Size = new System.Drawing.Size(68, 15);
            this.lblReemplazar.TabIndex = 2;
            this.lblReemplazar.Text = "Reemplazar";
            // 
            // btnBuscarSiguiente
            // 
            this.btnBuscarSiguiente.Enabled = false;
            this.btnBuscarSiguiente.Location = new System.Drawing.Point(204, 15);
            this.btnBuscarSiguiente.Name = "btnBuscarSiguiente";
            this.btnBuscarSiguiente.Size = new System.Drawing.Size(118, 23);
            this.btnBuscarSiguiente.TabIndex = 4;
            this.btnBuscarSiguiente.Text = "Buscar Siguiente";
            this.btnBuscarSiguiente.UseVisualStyleBackColor = true;
            this.btnBuscarSiguiente.Click += new System.EventHandler(this.btnBuscarSiguiente_Click);
            // 
            // btnReemplazar
            // 
            this.btnReemplazar.Enabled = false;
            this.btnReemplazar.Location = new System.Drawing.Point(204, 46);
            this.btnReemplazar.Name = "btnReemplazar";
            this.btnReemplazar.Size = new System.Drawing.Size(118, 23);
            this.btnReemplazar.TabIndex = 5;
            this.btnReemplazar.Text = "Reemplazar";
            this.btnReemplazar.UseVisualStyleBackColor = true;
            this.btnReemplazar.Click += new System.EventHandler(this.btnReemplazar_Click);
            // 
            // btnReemplazarTodo
            // 
            this.btnReemplazarTodo.Enabled = false;
            this.btnReemplazarTodo.Location = new System.Drawing.Point(204, 75);
            this.btnReemplazarTodo.Name = "btnReemplazarTodo";
            this.btnReemplazarTodo.Size = new System.Drawing.Size(118, 23);
            this.btnReemplazarTodo.TabIndex = 6;
            this.btnReemplazarTodo.Text = "Reemplazar todo";
            this.btnReemplazarTodo.UseVisualStyleBackColor = true;
            this.btnReemplazarTodo.Click += new System.EventHandler(this.btnReemplazarTodo_Click);
            // 
            // FormBuscarYReemplazar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 123);
            this.Controls.Add(this.btnReemplazarTodo);
            this.Controls.Add(this.btnReemplazar);
            this.Controls.Add(this.btnBuscarSiguiente);
            this.Controls.Add(this.txtBoxReemplazar);
            this.Controls.Add(this.lblReemplazar);
            this.Controls.Add(this.txtBoxBuscar);
            this.Controls.Add(this.lblBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBuscarYReemplazar";
            this.Text = "FormBuscarYReemplazar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblBuscar;
        private TextBox txtBoxBuscar;
        private TextBox txtBoxReemplazar;
        private Label lblReemplazar;
        private Button btnBuscarSiguiente;
        private Button btnReemplazar;
        private Button btnReemplazarTodo;
    }
}