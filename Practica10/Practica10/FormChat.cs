using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica10
{
    public partial class FormChat : Form
    {
        private SerialPort puertoSerie;
        public FormChat(SerialPort puertoSerie)
        {
            InitializeComponent();
            CenterToScreen();
            this.puertoSerie = puertoSerie;
            this.puertoSerie.DataReceived += new SerialDataReceivedEventHandler(this.recibirMensajes);
            CheckForIllegalCrossThreadCalls = false;
        }

        private void FormChat_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void acercadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programa realizado por Pablo Navarro Vázquez" + "\nVersión: 1.0.0", "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void recibirMensajes(object sender, EventArgs e)
        {
            rtboxMensajesRecibidos.Text += puertoSerie.ReadLine();
        }

        private void btnEnviarFichero_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = File.OpenRead(openFileDialog.FileName))
                {
                    puertoSerie.Write((new BinaryReader(fs)).ReadBytes((int)fs.Length), 0, (int)fs.Length);
                }
                //port.Write(File.OpenText(openFileDialog.FileName).ReadToEnd());
            }
        }

        private void btnEnviarMensaje_Click(object sender, EventArgs e)
        {
            puertoSerie.WriteLine(tboxMensajeAEnviar.Text);
        }
    }
}
