namespace Practica10
{
    partial class FormCarga
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCarga));
            this.contadorCarga = new System.Windows.Forms.Timer(this.components);
            this.barraDeCarga = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // contadorCarga
            // 
            this.contadorCarga.Enabled = true;
            this.contadorCarga.Tick += new System.EventHandler(this.contadorCarga_Tick);
            // 
            // barraDeCarga
            // 
            this.barraDeCarga.Location = new System.Drawing.Point(70, 182);
            this.barraDeCarga.Name = "barraDeCarga";
            this.barraDeCarga.Size = new System.Drawing.Size(100, 23);
            this.barraDeCarga.TabIndex = 0;
            // 
            // FormCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Practica10.Properties.Resources.logoCarga;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(240, 217);
            this.Controls.Add(this.barraDeCarga);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCarga";
            this.Text = "Pantalla de carga";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer contadorCarga;
        private System.Windows.Forms.ProgressBar barraDeCarga;
    }
}

