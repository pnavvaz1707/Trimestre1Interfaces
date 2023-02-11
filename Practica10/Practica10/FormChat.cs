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
            string mensajeLeido = puertoSerie.ReadLine();
            string archivo = puertoSerie.ReadLine();
            if (mensajeLeido == "A$rc$i$vo" && archivo != null)
            {
                DialogResult dialogResult = MessageBox.Show("¿Desea guardar el archivo o visualizarlo?","Archivo recibido",MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)
                {
                    rtboxMensajesRecibidos.Text += archivo;
                }
                else
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.FileName = "Sin título";
                    saveFileDialog.CreatePrompt = true;
                    saveFileDialog.OverwritePrompt = true;
                    saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                }
                
            }
            else
            {
                rtboxMensajesRecibidos.Text += mensajeLeido;
            }
        }

        private void btnEnviarFichero_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = File.OpenRead(openFileDialog.FileName))
                {
                    puertoSerie.WriteLine("A$rc$i$vo");
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
