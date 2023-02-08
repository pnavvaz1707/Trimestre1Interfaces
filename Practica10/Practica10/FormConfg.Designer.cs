namespace Practica10
{
    partial class FormConfg
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfg));
            this.puertoSerie = new System.IO.Ports.SerialPort(this.components);
            this.lblPuerto = new System.Windows.Forms.Label();
            this.cbPuerto = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblPuerto
            // 
            this.lblPuerto.AutoSize = true;
            this.lblPuerto.Location = new System.Drawing.Point(29, 38);
            this.lblPuerto.Name = "lblPuerto";
            this.lblPuerto.Size = new System.Drawing.Size(38, 13);
            this.lblPuerto.TabIndex = 0;
            this.lblPuerto.Text = "Puerto";
            // 
            // cbPuerto
            // 
            this.cbPuerto.FormattingEnabled = true;
            this.cbPuerto.Location = new System.Drawing.Point(70, 35);
            this.cbPuerto.Name = "cbPuerto";
            this.cbPuerto.Size = new System.Drawing.Size(121, 21);
            this.cbPuerto.TabIndex = 1;
            // 
            // FormConfg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbPuerto);
            this.Controls.Add(this.lblPuerto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormConfg";
            this.Text = "Configuración del puerto";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormConfg_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort puertoSerie;
        private System.Windows.Forms.Label lblPuerto;
        private System.Windows.Forms.ComboBox cbPuerto;
    }
}