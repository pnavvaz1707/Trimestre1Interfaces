namespace Practica8
{
    partial class FormEditarGrupo
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
            this.chckBoxENDE = new System.Windows.Forms.CheckBox();
            this.chckBoxDI = new System.Windows.Forms.CheckBox();
            this.chckBoxPRO = new System.Windows.Forms.CheckBox();
            this.chckBoxLEMA = new System.Windows.Forms.CheckBox();
            this.chckBoxSIGE = new System.Windows.Forms.CheckBox();
            this.chckBoxFOL = new System.Windows.Forms.CheckBox();
            this.btnCrearGrupo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombreNuevoGrupo
            // 
            this.txtNombreNuevoGrupo.Location = new System.Drawing.Point(166, 76);
            this.txtNombreNuevoGrupo.Name = "txtNombreNuevoGrupo";
            this.txtNombreNuevoGrupo.Size = new System.Drawing.Size(100, 23);
            this.txtNombreNuevoGrupo.TabIndex = 12;
            // 
            // lblNombreNuevoGrupo
            // 
            this.lblNombreNuevoGrupo.AutoSize = true;
            this.lblNombreNuevoGrupo.Location = new System.Drawing.Point(109, 79);
            this.lblNombreNuevoGrupo.Name = "lblNombreNuevoGrupo";
            this.lblNombreNuevoGrupo.Size = new System.Drawing.Size(51, 15);
            this.lblNombreNuevoGrupo.TabIndex = 19;
            this.lblNombreNuevoGrupo.Text = "Nombre";
            // 
            // chckBoxENDE
            // 
            this.chckBoxENDE.AutoSize = true;
            this.chckBoxENDE.Location = new System.Drawing.Point(440, 80);
            this.chckBoxENDE.Name = "chckBoxENDE";
            this.chckBoxENDE.Size = new System.Drawing.Size(55, 19);
            this.chckBoxENDE.TabIndex = 15;
            this.chckBoxENDE.Text = "ENDE";
            this.chckBoxENDE.UseVisualStyleBackColor = true;
            // 
            // chckBoxDI
            // 
            this.chckBoxDI.AutoSize = true;
            this.chckBoxDI.Location = new System.Drawing.Point(609, 80);
            this.chckBoxDI.Name = "chckBoxDI";
            this.chckBoxDI.Size = new System.Drawing.Size(37, 19);
            this.chckBoxDI.TabIndex = 18;
            this.chckBoxDI.Text = "DI";
            this.chckBoxDI.UseVisualStyleBackColor = true;
            // 
            // chckBoxPRO
            // 
            this.chckBoxPRO.AutoSize = true;
            this.chckBoxPRO.Location = new System.Drawing.Point(385, 80);
            this.chckBoxPRO.Name = "chckBoxPRO";
            this.chckBoxPRO.Size = new System.Drawing.Size(49, 19);
            this.chckBoxPRO.TabIndex = 14;
            this.chckBoxPRO.Text = "PRO";
            this.chckBoxPRO.UseVisualStyleBackColor = true;
            // 
            // chckBoxLEMA
            // 
            this.chckBoxLEMA.AutoSize = true;
            this.chckBoxLEMA.Location = new System.Drawing.Point(320, 80);
            this.chckBoxLEMA.Name = "chckBoxLEMA";
            this.chckBoxLEMA.Size = new System.Drawing.Size(57, 19);
            this.chckBoxLEMA.TabIndex = 13;
            this.chckBoxLEMA.Text = "LEMA";
            this.chckBoxLEMA.UseVisualStyleBackColor = true;
            // 
            // chckBoxSIGE
            // 
            this.chckBoxSIGE.AutoSize = true;
            this.chckBoxSIGE.Location = new System.Drawing.Point(554, 80);
            this.chckBoxSIGE.Name = "chckBoxSIGE";
            this.chckBoxSIGE.Size = new System.Drawing.Size(49, 19);
            this.chckBoxSIGE.TabIndex = 17;
            this.chckBoxSIGE.Text = "SIGE";
            this.chckBoxSIGE.UseVisualStyleBackColor = true;
            // 
            // chckBoxFOL
            // 
            this.chckBoxFOL.AutoSize = true;
            this.chckBoxFOL.Location = new System.Drawing.Point(501, 80);
            this.chckBoxFOL.Name = "chckBoxFOL";
            this.chckBoxFOL.Size = new System.Drawing.Size(47, 19);
            this.chckBoxFOL.TabIndex = 16;
            this.chckBoxFOL.Text = "FOL";
            this.chckBoxFOL.UseVisualStyleBackColor = true;
            // 
            // btnCrearGrupo
            // 
            this.btnCrearGrupo.Location = new System.Drawing.Point(331, 146);
            this.btnCrearGrupo.Name = "btnCrearGrupo";
            this.btnCrearGrupo.Size = new System.Drawing.Size(105, 49);
            this.btnCrearGrupo.TabIndex = 19;
            this.btnCrearGrupo.Text = "Crear";
            this.btnCrearGrupo.UseVisualStyleBackColor = true;
            this.btnCrearGrupo.Click += new System.EventHandler(this.btnCrearGrupo_Click);
            // 
            // FormEditarGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNombreNuevoGrupo);
            this.Controls.Add(this.lblNombreNuevoGrupo);
            this.Controls.Add(this.chckBoxENDE);
            this.Controls.Add(this.chckBoxDI);
            this.Controls.Add(this.chckBoxPRO);
            this.Controls.Add(this.chckBoxLEMA);
            this.Controls.Add(this.chckBoxSIGE);
            this.Controls.Add(this.chckBoxFOL);
            this.Controls.Add(this.btnCrearGrupo);
            this.Name = "FormEditarGrupo";
            this.Text = "FormEditarGrupo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNombreNuevoGrupo;
        private Label lblNombreNuevoGrupo;
        private CheckBox chckBoxENDE;
        private CheckBox chckBoxDI;
        private CheckBox chckBoxPRO;
        private CheckBox chckBoxLEMA;
        private CheckBox chckBoxSIGE;
        private CheckBox chckBoxFOL;
        private Button btnCrearGrupo;
    }
}