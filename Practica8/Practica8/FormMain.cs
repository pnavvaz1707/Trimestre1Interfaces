/*
* PR�CTICA.............: Pr�ctica 8
* NOMBRE y APELLIDOS...: Pablo Navarro V�zquez
* CURSO y GRUPO........: 2� Desarrollo de Interfaces
* T�TULO de la PR�CTICA: Uso del IDE V.Studio
* FECHA de ENTREGA.....: 20 de Enero de 2023
*/

namespace Practica8
{
    partial class FormMain : Form
    {       

        public FormMain()
        {
            InitializeComponent();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormEditarGrupo form = new FormEditarGrupo();
            form.DtgvGrupos = dtgvGrupos;
            form.ShowDialog();
        }
    }
}