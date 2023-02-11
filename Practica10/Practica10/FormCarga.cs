using System;
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
                FormConfg formConfg = new FormConfg("");
                formConfg.Show();
            }
        }
    }
}
