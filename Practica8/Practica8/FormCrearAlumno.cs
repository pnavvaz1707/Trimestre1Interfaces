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
        GroupBox grpNotas;
        TextBoxSubrayado[] txtNotas;
        public FormCrearAlumno()
        {
            InitializeComponent();

            grpNotas = new GroupBox();
            txtNotas = new TextBoxSubrayado[FormMain.grupoSel.CodigosAsignaturas.Length];

            int posicionX = 10;
            int anchuraLbl = 40;
            int anchuraTxt = 40;

            for (int i = 0; i < FormMain.grupoSel.CodigosAsignaturas.Length; i++)
            {
                Label lblNota = new Label();

                lblNota.Text = FormMain.grupoSel.CodigosAsignaturas[i];
                lblNota.Location = new System.Drawing.Point(posicionX, 30);
                lblNota.Size = new System.Drawing.Size(anchuraLbl, 15);

                posicionX += anchuraLbl + 5;

                grpNotas.Controls.Add(lblNota);

                TextBoxSubrayado txtNota = new TextBoxSubrayado();
                txtNota.Location = new System.Drawing.Point(posicionX, 25);
                txtNota.Size = new System.Drawing.Size(anchuraTxt, 15);
                txtNota.KeyPress += txtBoxSoloDoubles;
                txtNotas[i] = txtNota;

                posicionX += anchuraTxt + 20;

                grpNotas.Controls.Add(txtNotas[i]);
            }
            grpNotas.Location = new System.Drawing.Point(42, 100);
            grpNotas.Size = new System.Drawing.Size(FormMain.grupoSel.CodigosAsignaturas.Length * anchuraTxt * 2 + 25 * FormMain.grupoSel.CodigosAsignaturas.Length, 70);
            grpNotas.Text = "Notas";
            this.Controls.Add(grpNotas);
        }

        private void btnCrearAlumno_Click(object sender, EventArgs e)
        {
            if (txtNombreAlumnoNuevo.Text != "")
            {
                double[] notas = new double[FormMain.grupoSel.CodigosAsignaturas.Length];

                for (int i = 0; i < notas.Length; i++)
                {
                    notas[i] = Convert.ToDouble(txtNotas[i].Text);
                }
                FormMain.grupoSel.anadirAlumno(new Alumno(txtNombreAlumnoNuevo.Text, notas));

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("El nombre de alumno no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBoxSoloDoubles(object sender, KeyPressEventArgs e)
        {
            TextBoxSubrayado tBox = (TextBoxSubrayado)sender;
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',')
            {
                e.Handled = true;
                //tBox.BorderColor = Color.Red;
            }
            else
            {
                //tBox.BorderColor = Color.Black;
            }
        }
    }
}
