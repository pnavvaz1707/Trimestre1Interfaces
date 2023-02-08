using System.IO.Ports;
using System.Windows.Forms;

namespace Practica10
{
    public partial class FormConfg : Form
    {
        /*
         * Puerto : Portnames
         * Bits por segundo: 110, 300, 1200, 2400, 4800, 9600, 19200, 38400, 57600, 115200, 230400, 460800, 921600
         * Bits de datos: 5, 6, 7, 8
         * Paridad: Par, Impar, Ninguno, Marca, Espacio
         * Bits de parada: 1, 1.5, 2
         */
        public FormConfg()
        {
            InitializeComponent();
            string[] nombresPuerto = SerialPort.GetPortNames();
            for (int i = 0; i < nombresPuerto.Length; i++)
            {
                cbPuerto.Items.Add(nombresPuerto[i]);
            }
        }

        private void FormConfg_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
