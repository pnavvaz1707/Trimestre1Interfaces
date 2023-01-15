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
            this.chckBoxCrearENDE = new System.Windows.Forms.CheckBox();
            this.chckBoxCrearDI = new System.Windows.Forms.CheckBox();
            this.chckBoxCrearPRO = new System.Windows.Forms.CheckBox();
            this.chckBoxCrearLEMA = new System.Windows.Forms.CheckBox();
            this.chckBoxCrearSIGE = new System.Windows.Forms.CheckBox();
            this.chckBoxCrearFOL = new System.Windows.Forms.CheckBox();
            this.btnCrearGrupo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombreNuevoGrupo
            // 
            this.txtNombreNuevoGrupo.Location = new System.Drawing.Point(90, 66);
            this.txtNombreNuevoGrupo.Name = "txtNombreNuevoGrupo";
            this.txtNombreNuevoGrupo.Size = new System.Drawing.Size(100, 23);
            this.txtNombreNuevoGrupo.TabIndex = 12;
            // 
            // lblNombreNuevoGrupo
            // 
            this.lblNombreNuevoGrupo.AutoSize = true;
            this.lblNombreNuevoGrupo.Location = new System.Drawing.Point(33, 69);
            this.lblNombreNuevoGrupo.Name = "lblNombreNuevoGrupo";
            this.lblNombreNuevoGrupo.Size = new System.Drawing.Size(51, 15);
            this.lblNombreNuevoGrupo.TabIndex = 19;
            this.lblNombreNuevoGrupo.Text = "Nombre";
            // 
            // chckBoxCrearENDE
            // 
            this.chckBoxCrearENDE.AutoSize = true;
            this.chckBoxCrearENDE.Location = new System.Drawing.Point(364, 70);
            this.chckBoxCrearENDE.Name = "chckBoxCrearENDE";
            this.chckBoxCrearENDE.Size = new System.Drawing.Size(55, 19);
            this.chckBoxCrearENDE.TabIndex = 15;
            this.chckBoxCrearENDE.Text = "ENDE";
            this.chckBoxCrearENDE.UseVisualStyleBackColor = true;
            // 
            // chckBoxCrearDI
            // 
            this.chckBoxCrearDI.AutoSize = true;
            this.chckBoxCrearDI.Location = new System.Drawing.Point(533, 70);
            this.chckBoxCrearDI.Name = "chckBoxCrearDI";
            this.chckBoxCrearDI.Size = new System.Drawing.Size(37, 19);
            this.chckBoxCrearDI.TabIndex = 18;
            this.chckBoxCrearDI.Text = "DI";
            this.chckBoxCrearDI.UseVisualStyleBackColor = true;
            // 
            // chckBoxCrearPRO
            // 
            this.chckBoxCrearPRO.AutoSize = true;
            this.chckBoxCrearPRO.Location = new System.Drawing.Point(309, 70);
            this.chckBoxCrearPRO.Name = "chckBoxCrearPRO";
            this.chckBoxCrearPRO.Size = new System.Drawing.Size(49, 19);
            this.chckBoxCrearPRO.TabIndex = 14;
            this.chckBoxCrearPRO.Text = "PRO";
            this.chckBoxCrearPRO.UseVisualStyleBackColor = true;
            // 
            // chckBoxCrearLEMA
            // 
            this.chckBoxCrearLEMA.AutoSize = true;
            this.chckBoxCrearLEMA.Location = new System.Drawing.Point(244, 70);
            this.chckBoxCrearLEMA.Name = "chckBoxCrearLEMA";
            this.chckBoxCrearLEMA.Size = new System.Drawing.Size(57, 19);
            this.chckBoxCrearLEMA.TabIndex = 13;
            this.chckBoxCrearLEMA.Text = "LEMA";
            this.chckBoxCrearLEMA.UseVisualStyleBackColor = true;
            // 
            // chckBoxCrearSIGE
            // 
            this.chckBoxCrearSIGE.AutoSize = true;
            this.chckBoxCrearSIGE.Location = new System.Drawing.Point(478, 70);
            this.chckBoxCrearSIGE.Name = "chckBoxCrearSIGE";
            this.chckBoxCrearSIGE.Size = new System.Drawing.Size(49, 19);
            this.chckBoxCrearSIGE.TabIndex = 17;
            this.chckBoxCrearSIGE.Text = "SIGE";
            this.chckBoxCrearSIGE.UseVisualStyleBackColor = true;
            // 
            // chckBoxCrearFOL
            // 
            this.chckBoxCrearFOL.AutoSize = true;
            this.chckBoxCrearFOL.Location = new System.Drawing.Point(425, 70);
            this.chckBoxCrearFOL.Name = "chckBoxCrearFOL";
            this.chckBoxCrearFOL.Size = new System.Drawing.Size(47, 19);
            this.chckBoxCrearFOL.TabIndex = 16;
            this.chckBoxCrearFOL.Text = "FOL";
            this.chckBoxCrearFOL.UseVisualStyleBackColor = true;
            // 
            // btnCrearGrupo
            // 
            this.btnCrearGrupo.Location = new System.Drawing.Point(255, 136);
            this.btnCrearGrupo.Name = "btnCrearGrupo";
            this.btnCrearGrupo.Size = new System.Drawing.Size(105, 49);
            this.btnCrearGrupo.TabIndex = 19;
            this.btnCrearGrupo.Text = "Crear";
            this.btnCrearGrupo.UseVisualStyleBackColor = true;
            this.btnCrearGrupo.Click += new System.EventHandler(this.btnCrearGrupo_Click);
            // 
            // FormCrearGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 224);
            this.Controls.Add(this.txtNombreNuevoGrupo);
            this.Controls.Add(this.lblNombreNuevoGrupo);
            this.Controls.Add(this.chckBoxCrearENDE);
            this.Controls.Add(this.chckBoxCrearDI);
            this.Controls.Add(this.chckBoxCrearPRO);
            this.Controls.Add(this.chckBoxCrearLEMA);
            this.Controls.Add(this.chckBoxCrearSIGE);
            this.Controls.Add(this.chckBoxCrearFOL);
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
        private CheckBox chckBoxCrearENDE;
        private CheckBox chckBoxCrearDI;
        private CheckBox chckBoxCrearPRO;
        private CheckBox chckBoxCrearLEMA;
        private CheckBox chckBoxCrearSIGE;
        private CheckBox chckBoxCrearFOL;
        private Button btnCrearGrupo;
    }
}