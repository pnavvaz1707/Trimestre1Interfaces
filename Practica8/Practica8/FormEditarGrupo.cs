using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using CheckBox = System.Windows.Forms.VisualStyles.VisualStyleElement.Button.CheckBox;

/*
* PRÁCTICA.............: Práctica 8
* NOMBRE y APELLIDOS...: Pablo Navarro Vázquez
* CURSO y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO de la PRÁCTICA: Uso del IDE V.Studio
* FECHA de ENTREGA.....: 12 de Enero de 2023
*/

namespace Practica8
{
    public partial class FormEditarGrupo : Form
    {
        public FormEditarGrupo()
        {
            InitializeComponent();
        }

        private void btnCrearGrupo_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreNuevoGrupo.Text;
            bool allChecked = this.Controls.OfType<CheckBox>().All(c => c.Checked);

        }
    }
}
