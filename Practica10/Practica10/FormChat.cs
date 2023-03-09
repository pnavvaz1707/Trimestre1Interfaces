using System;
using System.IO;
using System.IO.Pipes;
using System.IO.Ports;
using System.Linq;
using System.Text;
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
                string mensaje = puertoSerie.ReadLine();
                rtboxMensajesRecibidos.Text += mensaje + "\n";
            }
            else
            {
                int indiceInicio = cabecera.IndexOf('*');
                int indiceFinal = cabecera.IndexOf(' ', indiceInicio);

                int longitud = indiceFinal - indiceInicio - 1;

                string nombreArchivo = cabecera.Substring(indiceInicio + 1, longitud);

                int tamanoArchivo = Convert.ToInt32(cabecera.Substring(cabecera.LastIndexOf(' ') + 1));

                byte[] bytesRecibidos = new byte[tamanoArchivo];

                MessageBox.Show("Archivo recibido --> " + nombreArchivo);

                if (nombreArchivo.Substring(nombreArchivo.IndexOf('.') + 1) == "txt")
                {
                    DialogResult opcionSel = MessageBox.Show("Ha recibido un archivo de texto, pulse sí si desea guardarlo, no si desea visualizarlo solo", "Archivo recibido", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (opcionSel == DialogResult.Yes)
                    {
                        guardarArchivoRecibido(nombreArchivo, bytesRecibidos);
                    }
                    else
                    {
                        int tamanoBloque = 1024;
                        int bloquesTotales = (int)Math.Ceiling((double)bytesRecibidos.Length / tamanoBloque);

                        int bloquesRecibidos = 0;
                        while (bloquesRecibidos < bloquesTotales)
                        {
                            int bytesPorLeer = puertoSerie.BytesToRead;
                            if (bytesPorLeer > 0)
                            {
                                int bytesLeidos = puertoSerie.Read(bytesRecibidos, bloquesRecibidos * tamanoBloque, bytesPorLeer);
                                bloquesRecibidos += bytesLeidos / tamanoBloque;
                            }
                            else
                            {
                                bloquesRecibidos = bloquesTotales;
                            }
                        }

                        rtboxMensajesRecibidos.Text += Encoding.UTF8.GetString(bytesRecibidos);
                    }
                }
                else
                {
                    DialogResult opcionSel = MessageBox.Show("Ha recibido un archivo, ¿desea guardarlo?", "Archivo recibido", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (opcionSel == DialogResult.Yes)
                    {
                        guardarArchivoRecibido(nombreArchivo, bytesRecibidos);
                    }
                    else
                    {
                        MessageBox.Show("No se ha guardado el archivo recibido", "Archivo recibido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void guardarArchivoRecibido(string nombreArchivo, byte[] bytesRecibidos)
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
                    int tamanoBloque = 1024;
                    int bloquesTotales = (int)Math.Ceiling((double)bytesRecibidos.Length / tamanoBloque);

                    int bloquesRecibidos = 0;
                    while (bloquesRecibidos < bloquesTotales)
                    {
                        int bytesPorLeer = puertoSerie.BytesToRead;
                        if (bytesPorLeer > 0)
                        {
                            int bytesLeidos = puertoSerie.Read(bytesRecibidos, bloquesRecibidos * tamanoBloque, bytesPorLeer);
                            bloquesRecibidos += bytesLeidos / tamanoBloque;
                        }
                        else
                        {
                            bloquesRecibidos = bloquesTotales;
                        }
                    }

                    File.WriteAllBytes(saveFileDialog.FileName, bytesRecibidos);

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
                int tamanoBloque = 1024;
                int bloquesTotales = (int)Math.Ceiling((double)bytesArchivoEnviar.Length / tamanoBloque);

                pruebaDLL.escribirCabecera(puertoSerie, "--- Archivo --- *" + openFileDialog.SafeFileName + " " + bytesArchivoEnviar.Length);

                for (int i = 0; i < bloquesTotales; i++)
                {
                    int offset = i * tamanoBloque;
                    int longitud = Math.Min(tamanoBloque, bytesArchivoEnviar.Length - offset);
                    byte[] bytesBloque = new byte[longitud];
                    Array.Copy(bytesArchivoEnviar, offset, bytesBloque, 0, longitud);
                    puertoSerie.Write(bytesBloque, 0, longitud);
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
