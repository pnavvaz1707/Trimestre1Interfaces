namespace Practica8
{
    partial class FormCrearGrupo
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
            this.txtNombreNuevoGrupo = new System.Windows.Forms.TextBox();
            this.lblNombreNuevoGrupo = new System.Windows.Forms.Label();
            this.btnCrearGrupo = new System.Windows.Forms.Button();
            this.lstAsignaturasCrearGrupo = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // txtNombreNuevoGrupo
            // 
            this.txtNombreNuevoGrupo.Location = new System.Drawing.Point(86, 40);
            this.txtNombreNuevoGrupo.Name = "txtNombreNuevoGrupo";
            this.txtNombreNuevoGrupo.Size = new System.Drawing.Size(100, 23);
            this.txtNombreNuevoGrupo.TabIndex = 12;
            // 
            // lblNombreNuevoGrupo
            // 
            this.lblNombreNuevoGrupo.AutoSize = true;
            this.lblNombreNuevoGrupo.Location = new System.Drawing.Point(29, 43);
            this.lblNombreNuevoGrupo.Name = "lblNombreNuevoGrupo";
            this.lblNombreNuevoGrupo.Size = new System.Drawing.Size(51, 15);
            this.lblNombreNuevoGrupo.TabIndex = 19;
            this.lblNombreNuevoGrupo.Text = "Nombre";
            // 
            // btnCrearGrupo
            // 
            this.btnCrearGrupo.Location = new System.Drawing.Point(81, 201);
            this.btnCrearGrupo.Name = "btnCrearGrupo";
            this.btnCrearGrupo.Size = new System.Drawing.Size(105, 49);
            this.btnCrearGrupo.TabIndex = 19;
            this.btnCrearGrupo.Text = "Crear";
            this.btnCrearGrupo.UseVisualStyleBackColor = true;
            this.btnCrearGrupo.Click += new System.EventHandler(this.btnCrearGrupo_Click);
            // 
            // lstAsignaturasCrearGrupo
            // 
            this.lstAsignaturasCrearGrupo.FormattingEnabled = true;
            this.lstAsignaturasCrearGrupo.Items.AddRange(new object[] {
            "LEMA",
            "PRO",
            "ENDE",
            "FOL",
            "SIGE",
            "DI"});
            this.lstAsignaturasCrearGrupo.Location = new System.Drawing.Point(81, 83);
            this.lstAsignaturasCrearGrupo.Name = "lstAsignaturasCrearGrupo";
            this.lstAsignaturasCrearGrupo.Size = new System.Drawing.Size(105, 94);
            this.lstAsignaturasCrearGrupo.TabIndex = 20;
            // 
            // FormCrearGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 288);
            this.Controls.Add(this.lstAsignaturasCrearGrupo);
            this.Controls.Add(this.txtNombreNuevoGrupo);
            this.Controls.Add(this.lblNombreNuevoGrupo);
            this.Controls.Add(this.btnCrearGrupo);
            this.Name = "FormCrearGrupo";
            this.RightToLeftLayout = true;
            this.Text = "FormCrearGrupo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNombreNuevoGrupo;
        private Label lblNombreNuevoGrupo;
        private Button btnCrearGrupo;
        private CheckedListBox lstAsignaturasCrearGrupo;
    }
}