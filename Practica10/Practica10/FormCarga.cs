using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica10
{
    public partial class FormCarga : Form
    {
        public FormCarga()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void contadorCarga_Tick(object sender, EventArgs e)
        {
            barraDeCarga.Increment(10);
            if (barraDeCarga.Maximum == barraDeCarga.Value)
            {
                contadorCarga.Stop();
                this.Hide();
                FormConfg formConfg = new FormConfg();
                formConfg.Show();
            }
        }
    }
}
