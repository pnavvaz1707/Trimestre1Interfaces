/*
* PRÁCTICA.............: Práctica 9
* NOMBRE y APELLIDOS...: Pablo Navarro Vázquez
* CURSO y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO de la PRÁCTICA: Uso del IDE V.Studio
* FECHA de ENTREGA.....: 31 de Enero de 2023
*/
namespace Practica9
{
    public partial class FormBuscarYReemplazar : Form
    {
        private int posicionInicioGlobal = 0;
        private int indiceTextoEncontrado = 0;
        public FormBuscarYReemplazar()
        {
            InitializeComponent();
            CenterToParent();
            Text = "Buscar";
        }

        public FormBuscarYReemplazar(string reemplazar)
        {
            InitializeComponent();
            CenterToParent();
            txtBoxReemplazar.Enabled = true;
            Text = "Buscar y reemplazar";
        }

        private void btnBuscarSiguiente_Click(object sender, EventArgs e)
        {
            int posicionTextoEntrada = 0;

            //Comprobamos que haya texto en el textBox de la palabra a buscar y la buscamos
            if (txtBoxBuscar.Text.Length > 0)
                posicionTextoEntrada = encontrarTexto(txtBoxBuscar.Text.Trim(), posicionInicioGlobal, FormMain.EditorTextBox.Text.Length);

            // Si la encontramos continuamos la resaltamos con fondo azul y seguimos buscando
            if (posicionTextoEntrada >= 0)
            {
                FormMain.EditorTextBox.SelectionBackColor = Color.DeepSkyBlue;

                int longitudTextoABuscar = txtBoxBuscar.Text.Length;
                FormMain.EditorTextBox.Select(posicionTextoEntrada, longitudTextoABuscar);

                posicionInicioGlobal = posicionTextoEntrada + longitudTextoABuscar;
            }
            else
            {
                posicionInicioGlobal = -1;
                MessageBox.Show("No se encuentran más coincidencias en el editor");
            }
        }

        public int encontrarTexto(string textoABuscar, int posicionInicio, int posicionFinal)
        {
            if (posicionInicio > 0 && posicionFinal > 0 && indiceTextoEncontrado >= 0)
            {
                FormMain.EditorTextBox.Undo();
            }

            int retVal = -1;

            if (posicionInicio >= 0 && indiceTextoEncontrado >= 0)
            {
                if (posicionFinal > posicionInicio || posicionFinal == -1)
                {
                    indiceTextoEncontrado = FormMain.EditorTextBox.Find(textoABuscar, posicionInicio, posicionFinal, RichTextBoxFinds.None);
                    if (indiceTextoEncontrado != -1)
                    {
                        retVal = indiceTextoEncontrado;
                    }
                }
            }
            return retVal;
        }

        private void txtBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            posicionInicioGlobal = 0;
            indiceTextoEncontrado = 0;

            if (txtBoxBuscar.Text.Length > 0)
            {
                btnBuscarSiguiente.Enabled = true;
            }
            else
            {
                btnBuscarSiguiente.Enabled = false;
            }
        }

        private void btnReemplazar_Click(object sender, EventArgs e)
        {
            FormMain.EditorTextBox.SelectionBackColor = Color.Red;

            int longitudTextoABuscar = txtBoxBuscar.Text.Length;
            FormMain.EditorTextBox.Select(posicionInicioGlobal - longitudTextoABuscar, longitudTextoABuscar);
            FormMain.EditorTextBox.SelectedText = FormMain.EditorTextBox.SelectedText.Replace(txtBoxBuscar.Text, txtBoxReemplazar.Text);
        }

        private void btnReemplazarTodo_Click(object sender, EventArgs e)
        {
            FormMain.EditorTextBox.Text = FormMain.EditorTextBox.Text.Replace(txtBoxBuscar.Text, txtBoxReemplazar.Text);
        }

        private void txtBoxReemplazar_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxReemplazar.Text.Length > 0)
            {
                btnReemplazar.Enabled = true;
                btnReemplazarTodo.Enabled = true;
            }
            else
            {
                btnReemplazar.Enabled = false;
                btnReemplazarTodo.Enabled = false;
            }
        }
    }
}
