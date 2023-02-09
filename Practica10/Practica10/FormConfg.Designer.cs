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
            this.cbVelocidad = new System.Windows.Forms.ComboBox();
            this.lblVelocidad = new System.Windows.Forms.Label();
            this.cbNumBits = new System.Windows.Forms.ComboBox();
            this.lblNumBits = new System.Windows.Forms.Label();
            this.cbBitStop = new System.Windows.Forms.ComboBox();
            this.lblBitStop = new System.Windows.Forms.Label();
            this.cbParidad = new System.Windows.Forms.ComboBox();
            this.lblParidad = new System.Windows.Forms.Label();
            this.btnConfgPuerto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPuerto
            // 
            this.lblPuerto.AutoSize = true;
            this.lblPuerto.Location = new System.Drawing.Point(21, 35);
            this.lblPuerto.Name = "lblPuerto";
            this.lblPuerto.Size = new System.Drawing.Size(38, 13);
            this.lblPuerto.TabIndex = 0;
            this.lblPuerto.Text = "Puerto";
            // 
            // cbPuerto
            // 
            this.cbPuerto.FormattingEnabled = true;
            this.cbPuerto.Location = new System.Drawing.Point(62, 32);
            this.cbPuerto.Name = "cbPuerto";
            this.cbPuerto.Size = new System.Drawing.Size(121, 21);
            this.cbPuerto.TabIndex = 1;
            // 
            // cbVelocidad
            // 
            this.cbVelocidad.FormattingEnabled = true;
            this.cbVelocidad.Location = new System.Drawing.Point(268, 32);
            this.cbVelocidad.Name = "cbVelocidad";
            this.cbVelocidad.Size = new System.Drawing.Size(121, 21);
            this.cbVelocidad.TabIndex = 3;
            // 
            // lblVelocidad
            // 
            this.lblVelocidad.AutoSize = true;
            this.lblVelocidad.Location = new System.Drawing.Point(208, 35);
            this.lblVelocidad.Name = "lblVelocidad";
            this.lblVelocidad.Size = new System.Drawing.Size(54, 13);
            this.lblVelocidad.TabIndex = 2;
            this.lblVelocidad.Text = "Velocidad";
            // 
            // cbNumBits
            // 
            this.cbNumBits.FormattingEnabled = true;
            this.cbNumBits.Location = new System.Drawing.Point(62, 71);
            this.cbNumBits.Name = "cbNumBits";
            this.cbNumBits.Size = new System.Drawing.Size(121, 21);
            this.cbNumBits.TabIndex = 5;
            // 
            // lblNumBits
            // 
            this.lblNumBits.AutoSize = true;
            this.lblNumBits.Location = new System.Drawing.Point(20, 74);
            this.lblNumBits.Name = "lblNumBits";
            this.lblNumBits.Size = new System.Drawing.Size(39, 13);
            this.lblNumBits.TabIndex = 4;
            this.lblNumBits.Text = "Nº Bits";
            // 
            // cbBitStop
            // 
            this.cbBitStop.FormattingEnabled = true;
            this.cbBitStop.Location = new System.Drawing.Point(62, 107);
            this.cbBitStop.Name = "cbBitStop";
            this.cbBitStop.Size = new System.Drawing.Size(121, 21);
            this.cbBitStop.TabIndex = 7;
            // 
            // lblBitStop
            // 
            this.lblBitStop.AutoSize = true;
            this.lblBitStop.Location = new System.Drawing.Point(15, 110);
            this.lblBitStop.Name = "lblBitStop";
            this.lblBitStop.Size = new System.Drawing.Size(44, 13);
            this.lblBitStop.TabIndex = 6;
            this.lblBitStop.Text = "Bit Stop";
            // 
            // cbParidad
            // 
            this.cbParidad.FormattingEnabled = true;
            this.cbParidad.Location = new System.Drawing.Point(268, 71);
            this.cbParidad.Name = "cbParidad";
            this.cbParidad.Size = new System.Drawing.Size(121, 21);
            this.cbParidad.TabIndex = 9;
            // 
            // lblParidad
            // 
            this.lblParidad.AutoSize = true;
            this.lblParidad.Location = new System.Drawing.Point(219, 74);
            this.lblParidad.Name = "lblParidad";
            this.lblParidad.Size = new System.Drawing.Size(43, 13);
            this.lblParidad.TabIndex = 8;
            this.lblParidad.Text = "Paridad";
            // 
            // btnConfgPuerto
            // 
            this.btnConfgPuerto.Location = new System.Drawing.Point(314, 147);
            this.btnConfgPuerto.Name = "btnConfgPuerto";
            this.btnConfgPuerto.Size = new System.Drawing.Size(75, 23);
            this.btnConfgPuerto.TabIndex = 10;
            this.btnConfgPuerto.Text = "OK";
            this.btnConfgPuerto.UseVisualStyleBackColor = true;
            this.btnConfgPuerto.Click += new System.EventHandler(this.btnConfgPuerto_Click);
            // 
            // FormConfg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 182);
            this.Controls.Add(this.btnConfgPuerto);
            this.Controls.Add(this.cbParidad);
            this.Controls.Add(this.lblParidad);
            this.Controls.Add(this.cbBitStop);
            this.Controls.Add(this.lblBitStop);
            this.Controls.Add(this.cbNumBits);
            this.Controls.Add(this.lblNumBits);
            this.Controls.Add(this.cbVelocidad);
            this.Controls.Add(this.lblVelocidad);
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
        private System.Windows.Forms.ComboBox cbVelocidad;
        private System.Windows.Forms.Label lblVelocidad;
        private System.Windows.Forms.ComboBox cbNumBits;
        private System.Windows.Forms.Label lblNumBits;
        private System.Windows.Forms.ComboBox cbBitStop;
        private System.Windows.Forms.Label lblBitStop;
        private System.Windows.Forms.ComboBox cbParidad;
        private System.Windows.Forms.Label lblParidad;
        private System.Windows.Forms.Button btnConfgPuerto;
    }
}