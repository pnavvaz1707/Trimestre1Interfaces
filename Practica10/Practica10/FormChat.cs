using System;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;
using DLLPractica10;

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
            this.Text += " (" + puertoSerie.PortName + ")";
        }

        private void FormChat_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void acercadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programa realizado por Pablo Navarro Vázquez" + "\nVersión: 3.0.0", "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void recibirMensajes(object sender, EventArgs e)
        {
            string cabecera = puertoSerie.ReadLine();

            if (cabecera.Contains("--- Archivo ---"))
            {
                int indexInicio = cabecera.IndexOf('*');
                int indexFinal = cabecera.IndexOf(' ', indexInicio);
                int longitud = indexFinal - indexInicio - 1;
                int tamanoArchivo = Convert.ToInt32(cabecera.Substring(indexInicio + 1,longitud));

                MessageBox.Show("Tamaño --> " + tamanoArchivo);

                byte[] archivoRecibido = new byte[puertoSerie.BytesToRead];
                puertoSerie.Read(archivoRecibido, 0, puertoSerie.BytesToRead);

                DialogResult opcionSel = MessageBox.Show("Ha recibido un archivo, pulse sí si desea guardarlo, no si desea visualizarlo solo", "Archivo recibido", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (opcionSel == DialogResult.Yes)
                {
                    try
                    {
                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        saveFileDialog.Filter = "Todos los archivos (*.*)|*.*";
                        saveFileDialog.FileName = "Sin título" + cabecera.Substring(cabecera.IndexOf('.'));
                        saveFileDialog.CreatePrompt = true;
                        saveFileDialog.OverwritePrompt = true;
                        saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                        DialogResult result = DialogResult.None;
                        if (InvokeRequired)
                        {
                            Invoke(new Action(() => result = saveFileDialog.ShowDialog()));
                        }

                        if (result == DialogResult.OK)
                        {
                            MessageBox.Show("Nombre: " + saveFileDialog.FileName);
                            File.WriteAllBytes(saveFileDialog.FileName, archivoRecibido);
                            MessageBox.Show("Se ha guardado correctamente el archivo", "Archivo guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    rtboxMensajesRecibidos.Text += archivoRecibido;
                }
            }
            else if (cabecera == "--- Texto ---")
            {
                string mensaje = puertoSerie.ReadExisting();
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
                    PruebaDLL pruebaDLL = new PruebaDLL();
                    pruebaDLL.escribirCabecera(puertoSerie, "--- Archivo --- " + "*" + fs.Length + " " + openFileDialog.FileName.Substring(openFileDialog.FileName.IndexOf(".")));
                    byte[] bytesArchivoEnviar = File.ReadAllBytes(openFileDialog.FileName);
                    puertoSerie.Write(bytesArchivoEnviar,0,bytesArchivoEnviar.Length);
                }
            }
        }

        private void btnEnviarMensaje_Click(object sender, EventArgs e)
        {
            PruebaDLL pruebaDLL = new PruebaDLL();
            pruebaDLL.escribirCabecera(puertoSerie, "--- Texto ---");
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
