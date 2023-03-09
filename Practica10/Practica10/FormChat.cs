using System;
using System.IO;
using System.IO.Pipes;
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

            if (cabecera.Contains("--- Texto ---"))
            {
                string mensaje = puertoSerie.ReadExisting();
                rtboxMensajesRecibidos.Text += mensaje;

            }
            else
            {
                int indiceInicio = cabecera.IndexOf('*');
                int indiceFinal = cabecera.IndexOf(' ', indiceInicio);

                int longitud = indiceFinal - indiceInicio - 1;

                string nombreArchivo = cabecera.Substring(indiceInicio + 1, longitud);


                if (nombreArchivo.Substring(nombreArchivo.IndexOf('.')) == "txt")
                {
                    DialogResult opcionSel = MessageBox.Show("Ha recibido un archivo de texto, pulse sí si desea guardarlo, no si desea visualizarlo solo", "Archivo recibido", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (opcionSel == DialogResult.Yes)
                    {
                        guardarArchivoRecibido(nombreArchivo);
                    }
                    else
                    {
                        //rtboxMensajesRecibidos.Text += archivoRecibido;
                    }
                }
                else
                {
                    DialogResult opcionSel = MessageBox.Show("Ha recibido un archivo, ¿desea guardarlo?", "Archivo recibido", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (opcionSel == DialogResult.Yes)
                    {
                        guardarArchivoRecibido(nombreArchivo);
                    }
                }
            }
        }
        private void guardarArchivoRecibido(string nombreArchivo)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Todos los archivos (*.*)|*.*";
                saveFileDialog.FileName = nombreArchivo;
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

                    FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write);

                    byte[] buffer = new byte[puertoSerie.ReadBufferSize];
                    int bytesLeidos = 0;
                    while ((bytesLeidos = puertoSerie.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        fileStream.Write(buffer,0,bytesLeidos);
                    }

                    fileStream.Close();
                    MessageBox.Show("Se ha guardado correctamente el archivo", "Archivo guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEnviarFichero_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PruebaDLL pruebaDLL = new PruebaDLL();

                byte[] bytesArchivoEnviar = File.ReadAllBytes(openFileDialog.FileName);

                pruebaDLL.escribirCabecera(puertoSerie, "--- Archivo --- *" + openFileDialog.SafeFileName + " " + bytesArchivoEnviar.Length);
                puertoSerie.Write(bytesArchivoEnviar, 0, bytesArchivoEnviar.Length);
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
