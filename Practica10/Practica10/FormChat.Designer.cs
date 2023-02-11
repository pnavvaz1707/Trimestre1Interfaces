namespace Practica10
{
    partial class FormChat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChat));
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarPuertoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rtboxMensajesRecibidos = new System.Windows.Forms.RichTextBox();
            this.tboxMensajeAEnviar = new System.Windows.Forms.TextBox();
            this.btnEnviarFichero = new System.Windows.Forms.Button();
            this.lblMensajesRecibidos = new System.Windows.Forms.Label();
            this.btnEnviarMensaje = new System.Windows.Forms.Button();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.acercadeToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(446, 24);
            this.menuPrincipal.TabIndex = 1;
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurarPuertoMenuItem,
            this.toolStripSeparator2,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // configurarPuertoMenuItem
            // 
            this.configurarPuertoMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("configurarPuertoMenuItem.Image")));
            this.configurarPuertoMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.configurarPuertoMenuItem.Name = "configurarPuertoMenuItem";
            this.configurarPuertoMenuItem.Size = new System.Drawing.Size(205, 22);
            this.configurarPuertoMenuItem.Text = "Configurar nuevo puerto";
            this.configurarPuertoMenuItem.Click += new System.EventHandler(this.configurarPuertoMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(202, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            // 
            // acercadeToolStripMenuItem
            // 
            this.acercadeToolStripMenuItem.Name = "acercadeToolStripMenuItem";
            this.acercadeToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.acercadeToolStripMenuItem.Text = "&Acerca de...";
            this.acercadeToolStripMenuItem.Click += new System.EventHandler(this.acercadeToolStripMenuItem_Click);
            // 
            // rtboxMensajesRecibidos
            // 
            this.rtboxMensajesRecibidos.Enabled = false;
            this.rtboxMensajesRecibidos.Location = new System.Drawing.Point(12, 51);
            this.rtboxMensajesRecibidos.Name = "rtboxMensajesRecibidos";
            this.rtboxMensajesRecibidos.Size = new System.Drawing.Size(422, 262);
            this.rtboxMensajesRecibidos.TabIndex = 2;
            this.rtboxMensajesRecibidos.Text = "";
            // 
            // tboxMensajeAEnviar
            // 
            this.tboxMensajeAEnviar.Location = new System.Drawing.Point(15, 337);
            this.tboxMensajeAEnviar.Name = "tboxMensajeAEnviar";
            this.tboxMensajeAEnviar.Size = new System.Drawing.Size(325, 20);
            this.tboxMensajeAEnviar.TabIndex = 3;
            // 
            // btnEnviarFichero
            // 
            this.btnEnviarFichero.Location = new System.Drawing.Point(346, 374);
            this.btnEnviarFichero.Name = "btnEnviarFichero";
            this.btnEnviarFichero.Size = new System.Drawing.Size(88, 23);
            this.btnEnviarFichero.TabIndex = 5;
            this.btnEnviarFichero.Text = "Enviar fichero";
            this.btnEnviarFichero.UseVisualStyleBackColor = true;
            this.btnEnviarFichero.Click += new System.EventHandler(this.btnEnviarFichero_Click);
            // 
            // lblMensajesRecibidos
            // 
            this.lblMensajesRecibidos.AutoSize = true;
            this.lblMensajesRecibidos.Location = new System.Drawing.Point(12, 35);
            this.lblMensajesRecibidos.Name = "lblMensajesRecibidos";
            this.lblMensajesRecibidos.Size = new System.Drawing.Size(97, 13);
            this.lblMensajesRecibidos.TabIndex = 6;
            this.lblMensajesRecibidos.Text = "Mensajes recibidos";
            // 
            // btnEnviarMensaje
            // 
            this.btnEnviarMensaje.Location = new System.Drawing.Point(346, 337);
            this.btnEnviarMensaje.Name = "btnEnviarMensaje";
            this.btnEnviarMensaje.Size = new System.Drawing.Size(88, 23);
            this.btnEnviarMensaje.TabIndex = 7;
            this.btnEnviarMensaje.Text = "Enviar mensaje";
            this.btnEnviarMensaje.UseVisualStyleBackColor = true;
            this.btnEnviarMensaje.Click += new System.EventHandler(this.btnEnviarMensaje_Click);
            // 
            // FormChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 409);
            this.Controls.Add(this.btnEnviarMensaje);
            this.Controls.Add(this.lblMensajesRecibidos);
            this.Controls.Add(this.btnEnviarFichero);
            this.Controls.Add(this.tboxMensajeAEnviar);
            this.Controls.Add(this.rtboxMensajesRecibidos);
            this.Controls.Add(this.menuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "FormChat";
            this.Text = "Hiperterminal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormChat_FormClosed);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurarPuertoMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercadeToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rtboxMensajesRecibidos;
        private System.Windows.Forms.TextBox tboxMensajeAEnviar;
        private System.Windows.Forms.Button btnEnviarFichero;
        private System.Windows.Forms.Label lblMensajesRecibidos;
        private System.Windows.Forms.Button btnEnviarMensaje;
    }
}