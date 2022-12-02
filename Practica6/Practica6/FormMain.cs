using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica6
{
    /*
    * PRÁCTICA.............: Práctica 6.
    * NOMBRE Y APELLIDOS...: Fulanito de los Palotes
    * CURSO Y GRUPO........: 2º Desarrollo de Interfaces
    * TÍTULO DE LA PRÁCTICA: Aplicaciones de Formulario. Controles Básicos.
    * FECHA DE ENTREGA.....: 7 de diciembre de 2022
    */
    public partial class FormMain : Form
    {

        Empleado empleado;

        public FormMain()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Console.WriteLine("NIF --> " + txtNif);

        }
    }
}
