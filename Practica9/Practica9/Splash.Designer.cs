namespace Practica9
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.barraProgresoSplash = new System.Windows.Forms.ProgressBar();
            this.contadorSplash = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // barraProgresoSplash
            // 
            this.barraProgresoSplash.Location = new System.Drawing.Point(78, 254);
            this.barraProgresoSplash.Name = "barraProgresoSplash";
            this.barraProgresoSplash.Size = new System.Drawing.Size(151, 23);
            this.barraProgresoSplash.TabIndex = 0;
            // 
            // contadorSplash
            // 
            this.contadorSplash.Enabled = true;
            this.contadorSplash.Interval = 50;
            this.contadorSplash.Tick += new System.EventHandler(this.contadorSplash_Tick);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Practica9.Properties.Resources.notepad;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(306, 289);
            this.Controls.Add(this.barraProgresoSplash);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Splash";
            this.Text = "Splash";
            this.ResumeLayout(false);

        }

        #endregion

        private ProgressBar barraProgresoSplash;
        private System.Windows.Forms.Timer contadorSplash;
    }
}