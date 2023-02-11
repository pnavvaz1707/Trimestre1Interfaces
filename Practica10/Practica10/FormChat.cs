using System;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;

/*
* PRÁCTICA.............: Práctica 10
* NOMBRE y APELLIDOS...: Pablo Navarro Vázquez
* CURSO y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO de la PRÁCTICA: Uso del IDE V.Studio
* FECHA de ENTREGA.....: 10 de Febrero de 2023
*/

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
            string cabecera = puertoSerie.ReadLine();
            string mensaje = puertoSerie.ReadExisting();
            if (cabecera == "--- Archivo ---" && mensaje != null)
            {
                FormRecibeArchivo formRecibeArchivo = new FormRecibeArchivo();
                DialogResult dialogResult = formRecibeArchivo.ShowDialog();
                MessageBox.Show(dialogResult.ToString());
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Va a guardar");
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Todos los archivos (*.*)|*.*";
                    saveFileDialog.FileName = "Sin título";
                    saveFileDialog.CreatePrompt = true;
                    saveFileDialog.OverwritePrompt = true;
                    saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    MessageBox.Show("Va a guardar11");
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        MessageBox.Show("Se ha guardado correctamente el archivo", "Archivo guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    MessageBox.Show("Va a guardar222");
                }
                else
                {
                    rtboxMensajesRecibidos.Text += mensaje;
                }

            }
            else if (cabecera == "--- Texto ---")
            {
                rtboxMensajesRecibidos.Text += mensaje;
            }
        }

        private void btnEnviarFichero_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = File.OpenRead(openFileDialog.FileName))
                {
                    puertoSerie.WriteLine("--- Archivo ---");
                    puertoSerie.Write((new BinaryReader(fs)).ReadBytes((int)fs.Length), 0, (int)fs.Length);
                }
                //port.Write(File.OpenText(openFileDialog.FileName).ReadToEnd());
            }
        }

        private void btnEnviarMensaje_Click(object sender, EventArgs e)
        {
            puertoSerie.WriteLine("--- Texto ---");
            puertoSerie.WriteLine(tboxMensajeAEnviar.Text);
        }

        private void configurarPuertoMenuItem_Click(object sender, EventArgs e)
        {
            FormConfg formConfg = new FormConfg("Configurar");
            if (formConfg.ShowDialog() == DialogResult.OK)
            {
                puertoSerie = FormConfg.puertoSerieAux;
                MessageBox.Show("Se ha modificado correctamente el puerto", "Puerto modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
