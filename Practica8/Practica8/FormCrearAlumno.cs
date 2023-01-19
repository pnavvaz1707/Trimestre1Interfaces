/*
* PRÁCTICA.............: Práctica 8
* NOMBRE y APELLIDOS...: Pablo Navarro Vázquez
* CURSO y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO de la PRÁCTICA: Uso del IDE V.Studio
* FECHA de ENTREGA.....: 20 de Enero de 2023
*/

namespace Practica8
{
    partial class FormCrearAlumno : Form
    {
        public FormCrearAlumno()
        {
            InitializeComponent();

            int numAsignatura = 0;

            for (int i = 0; i < grpNotas.Controls.Count; i++)
            {
                if (grpNotas.Controls[i] is TextBox)
                {
                    TextBox notas = grpNotas.Controls[i] as TextBox;
                    notas.Text = FormMain.grupoSel.CodigosAsignaturas[numAsignatura];
                    numAsignatura++;
                }
            }
        }

        private void btnCrearAlumno_Click(object sender, EventArgs e)
        {
            double[] notas = new double[4];
            int numAsignatura = 0;

            for (int i = 0; i < grpNotas.Controls.Count; i++)
            {
                if (grpNotas.Controls[i] is TextBox)
                {
                    TextBox notasTxt = grpNotas.Controls[i] as TextBox;
                    MessageBox.Show("Se va a añadir " + notasTxt.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    notas[numAsignatura] = Convert.ToDouble(notasTxt.Text);
                    MessageBox.Show("Se ha anadido " + notas[numAsignatura], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    numAsignatura++;
                }
            }
            FormMain.grupoSel.anadirAlumno(new Alumno(txtNombreAlumnoNuevo.Text,notas));

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
