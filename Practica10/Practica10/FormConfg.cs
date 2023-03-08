using System;
using System.Collections.Generic;
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
    public partial class FormConfg : Form
    {
        public static SerialPort puertoSerieAux;
        private string msg;
        public FormConfg(string msg)
        {
            InitializeComponent();
            CenterToScreen();

            this.msg = msg;

            string[] nombresPuerto = SerialPort.GetPortNames();
            for (int i = 0; i < nombresPuerto.Length; i++)
            {
                cbPuerto.Items.Add(nombresPuerto[i]);
            }
            cbPuerto.SelectedIndex = 0;

            cbNumBits.Items.Add(5);
            cbNumBits.Items.Add(6);
            cbNumBits.Items.Add(7);
            cbNumBits.Items.Add(8);
            cbNumBits.SelectedIndex = 3;

            cbVelocidad.Items.Add(110);
            cbVelocidad.Items.Add(300);
            cbVelocidad.Items.Add(1200);
            cbVelocidad.Items.Add(2400);
            cbVelocidad.Items.Add(4800);
            cbVelocidad.Items.Add(9600);
            cbVelocidad.Items.Add(19200);
            cbVelocidad.Items.Add(38400);
            cbVelocidad.Items.Add(57600);
            cbVelocidad.Items.Add(115200);
            cbVelocidad.Items.Add(230400);
            cbVelocidad.Items.Add(460800);
            cbVelocidad.Items.Add(921600);
            cbVelocidad.SelectedIndex = 3;

            Dictionary<Parity, string> dicParity = new Dictionary<Parity, string>
            {
                { Parity.Even, "Par" },
                { Parity.Odd, "Impar" },
                { Parity.None, "Ninguno" },
                { Parity.Mark, "Marca" },
                { Parity.Space, "Espacio" }
            };

            cbParidad.DataSource = new BindingSource(dicParity, null);
            cbParidad.DisplayMember = "Value";
            cbParidad.ValueMember = "Key";
            cbParidad.SelectedIndex = 2;
            //Ninguno

            Dictionary<StopBits, string> dicStopBits = new Dictionary<StopBits, string>
            {
                { StopBits.One, "1" },
                { StopBits.OnePointFive, "1.5" },
                { StopBits.Two, "2" }
            };

            cbBitStop.DataSource = new BindingSource(dicStopBits, null);
            cbBitStop.DisplayMember = "Value";
            cbBitStop.ValueMember = "Key";
            cbBitStop.SelectedIndex = 0;

        }

        private void btnConfgPuerto_Click(object sender, EventArgs e)
        {
            try
            {
                puertoSerie.PortName = cbPuerto.Text;
                puertoSerie.DataBits = Convert.ToInt16(cbNumBits.Text);
                puertoSerie.StopBits = ((KeyValuePair<StopBits, string>)cbBitStop.SelectedItem).Key;
                puertoSerie.BaudRate = Convert.ToInt32(cbVelocidad.Text);
                puertoSerie.Parity = ((KeyValuePair<Parity, string>)cbParidad.SelectedItem).Key;
                puertoSerie.Open();
                this.Hide();
                if (msg == "Configurar")
                {
                    this.DialogResult = DialogResult.OK;
                    puertoSerieAux = puertoSerie;
                }
                else
                {
                    FormChat formChat = new FormChat(puertoSerie);
                    formChat.ShowDialog();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Ha habido un error al conectar el puerto","Error en el puerto",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void FormConfg_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}