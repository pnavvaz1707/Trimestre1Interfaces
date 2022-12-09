using System;
using System.Windows.Forms;

/*
* PRÁCTICA.............: Práctica 6.
* NOMBRE Y APELLIDOS...: Pablo Navarro Vázquez
* CURSO Y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO DE LA PRÁCTICA: Aplicaciones de Formulario. Controles Básicos.
* FECHA DE ENTREGA.....: 07 de diciembre de 2022
*/

namespace Practica6
{
    internal static class Programa
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormMain form = new FormMain();
            form.MaximizeBox = false;
            Application.Run(form);
        }
    }
}
