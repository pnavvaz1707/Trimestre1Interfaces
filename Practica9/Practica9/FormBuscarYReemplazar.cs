using System.Drawing;

namespace Practica9
{
    public partial class FormBuscarYReemplazar : Form
    {
        public FormBuscarYReemplazar()
        {
            InitializeComponent();
            Text = "Buscar";
        }

        public FormBuscarYReemplazar(string reemplazar)
        {
            InitializeComponent();
            Text = "Buscar y reemplazar";
            btnReemplazar.Enabled = true;
            btnReemplazarTodo.Enabled = true;
            txtBoxReemplazar.Enabled = true;
        }

        private void btnBuscarSiguiente_Click(object sender, EventArgs e)
        {
            if (txtBoxBuscar.Text == "")
            {
                MessageBox.Show("No puedes dejar el campo de búsqueda vacío");
            }
            else
            {
                int posicion = FormMain.editorTextBox.Find(txtBoxBuscar.Text);
                if (posicion != -1)
                {

                }
                else
                {
                    MessageBox.Show("No hay coincidencias con ese texto a buscar");
                }
            }
        }

        private void btnReemplazar_Click(object sender, EventArgs e)
        {

        }

        private void btnReemplazarTodo_Click(object sender, EventArgs e)
        {

        }
    }
}
