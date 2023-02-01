using Practica9.Properties;
/*
* PRÁCTICA.............: Práctica 9
* NOMBRE y APELLIDOS...: Pablo Navarro Vázquez
* CURSO y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO de la PRÁCTICA: Uso del IDE V.Studio
* FECHA de ENTREGA.....: 31 de Enero de 2023
*/
namespace Practica9
{
    public partial class FormMain : Form
    {
        bool guardado = true;
        TableLayoutPanel subMenuActivo;
        string nombreArchivo;

        public static RichTextBox EditorTextBox { get { return editorTextBox; } }
        public FormMain()
        {
            InitializeComponent();
            CenterToParent();

            subMenuActivo = subMenuInicio;
            subMenuInicio.Visible = true;

            foreach (FontFamily font in FontFamily.Families)
            {
                fuentesComboBox.Items.Add(font.Name);
            }

            fuentesComboBox.Text = editorTextBox.Font.Name.ToString();
            tamanoFuenteComboBox.Text = editorTextBox.Font.Size.ToString();
        }

        private void menuPrincipalInicioBtn_Click(object sender, EventArgs e)
        {
            subMenuActivo.Visible = false;
            subMenuActivo = subMenuInicio;
            subMenuInicio.Visible = true;
        }

        private void menuPrincipalVerBtn_Click(object sender, EventArgs e)
        {
            subMenuInicio.Visible = false;
            subMenuActivo = subMenuVer;
            subMenuVer.Visible = true;
        }

        private void menuPrincipalOcultarBtn_Click(object sender, EventArgs e)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            if (menuPrincipalOcultarBtn.Text == "Ocultar")
            {
                subMenuActivo.Visible = false;
                menuPrincipalOcultarBtn.Text = "Mostrar";
                this.menuPrincipalOcultarBtn.Image = Resources.flecha_abajo;
            }
            else
            {
                subMenuActivo.Visible = true;
                menuPrincipalOcultarBtn.Text = "Ocultar";
                this.menuPrincipalOcultarBtn.Image = Resources.flecha_arriba;
            }
        }

        private void tamanoFuenteComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (editorTextBox.SelectionFont != null)
            {
                editorTextBox.SelectionFont = new Font(editorTextBox.SelectionFont.FontFamily, Convert.ToInt16(tamanoFuenteComboBox.Text));
            }
            else
            {
                MessageBox.Show("No se ha podido cambiar la fuente del texto seleccionado","Error al cambiar fuente",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void fuentesComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (editorTextBox.SelectionFont != null)
            {
                editorTextBox.SelectionFont = new Font(fuentesComboBox.Text, editorTextBox.SelectionFont.Size);
            }
            else
            {
                MessageBox.Show("No se ha podido cambiar la fuente del texto seleccionado", "Error al cambiar fuente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnNegrita_Click(object sender, EventArgs e)
        {
            editorTextBox.SelectionFont = new Font(editorTextBox.SelectionFont, FontStyle.Bold);
        }

        private void btnItalica_Click(object sender, EventArgs e)
        {
            editorTextBox.SelectionFont = new Font(editorTextBox.SelectionFont, FontStyle.Italic);

        }

        private void btnSubrayar_Click(object sender, EventArgs e)
        {
            editorTextBox.SelectionFont = new Font(editorTextBox.SelectionFont, FontStyle.Underline);

        }

        private void btnTachar_Click(object sender, EventArgs e)
        {
            editorTextBox.SelectionFont = new Font(editorTextBox.SelectionFont, FontStyle.Strikeout);

        }

        private void chckBoxNegrita_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBoxNegrita.Checked)
            {
                editorTextBox.SelectionFont = new Font(editorTextBox.SelectionFont, editorTextBox.SelectionFont.Style | FontStyle.Bold);
            }
            else
            {
                editorTextBox.SelectionFont = new Font(editorTextBox.SelectionFont, editorTextBox.SelectionFont.Style & ~FontStyle.Bold);
            }
        }

        private void chckBoxItalica_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBoxItalica.Checked)
            {
                editorTextBox.SelectionFont = new Font(editorTextBox.SelectionFont, editorTextBox.SelectionFont.Style | FontStyle.Italic);
            }
            else
            {
                editorTextBox.SelectionFont = new Font(editorTextBox.SelectionFont, editorTextBox.SelectionFont.Style & ~FontStyle.Italic);
            }
        }

        private void chckBoxSubrayado_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBoxSubrayado.Checked)
            {
                editorTextBox.SelectionFont = new Font(editorTextBox.SelectionFont, editorTextBox.SelectionFont.Style | FontStyle.Underline);
            }
            else
            {
                editorTextBox.SelectionFont = new Font(editorTextBox.SelectionFont, editorTextBox.SelectionFont.Style & ~FontStyle.Underline);
            }
        }

        private void chckBoxStrikeout_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBoxStrikeout.Checked)
            {
                editorTextBox.SelectionFont = new Font(editorTextBox.SelectionFont, editorTextBox.SelectionFont.Style | FontStyle.Strikeout);
            }
            else
            {
                editorTextBox.SelectionFont = new Font(editorTextBox.SelectionFont, editorTextBox.SelectionFont.Style & ~FontStyle.Strikeout);
            }
        }

        private void chckBoxSubIndice_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBoxSubIndice.Checked)
            {
                chckBoxSuperIndice.Checked = false;
                editorTextBox.SelectionCharOffset = -10;
            }
            else
            {
                editorTextBox.SelectionCharOffset = 0;
            }
        }

        private void chckBoxSuperIndice_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBoxSuperIndice.Checked)
            {

                chckBoxSubIndice.Checked = false;
                editorTextBox.SelectionCharOffset = 10;
            }
            else
            {
                editorTextBox.SelectionCharOffset = 0;
            }
        }

        private void btnAlinearIzquierda_Click(object sender, EventArgs e)
        {
            editorTextBox.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void btnAlinearCentro_Click(object sender, EventArgs e)
        {
            editorTextBox.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void btnAlinearDerecha_Click(object sender, EventArgs e)
        {
            editorTextBox.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void btnAlinearJustificado_Click(object sender, EventArgs e)
        {
            editorTextBox.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void btnColorearTexto_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialogColorearTexto = new ColorDialog();
            if (colorDialogColorearTexto.ShowDialog() == DialogResult.OK)
            {
                editorTextBox.SelectionColor = colorDialogColorearTexto.Color;
            }
        }

        private void btnResaltarTexto_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialogResaltarTexto = new ColorDialog();
            if (colorDialogResaltarTexto.ShowDialog() == DialogResult.OK)
            {
                editorTextBox.SelectionBackColor = colorDialogResaltarTexto.Color;
            }
        }

        private void btnSumarTamanoFuente_Click(object sender, EventArgs e)
        {
            editorTextBox.SelectionFont = new Font(editorTextBox.SelectionFont.FontFamily, editorTextBox.SelectionFont.Size + 1);
            tamanoFuenteComboBox.Text = editorTextBox.SelectionFont.Size.ToString();
        }

        private void btnRestarTamanoFuente_Click(object sender, EventArgs e)
        {
            editorTextBox.SelectionFont = new Font(editorTextBox.SelectionFont.FontFamily, editorTextBox.SelectionFont.Size - 1);
            tamanoFuenteComboBox.Text = editorTextBox.SelectionFont.Size.ToString();
        }

        private void btnPegar_Click(object sender, EventArgs e)
        {
            editorTextBox.Paste();
        }

        private void btnCortar_Click(object sender, EventArgs e)
        {
            editorTextBox.Cut();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            editorTextBox.Copy();
        }

        private void btnArchivoNuevo_Click(object sender, EventArgs e)
        {
            if (!guardado)
            {
                DialogResult opcionSel = MessageBox.Show("No ha guardado el archivo, ¿desea guardarlo?", "Guardar archivo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (opcionSel == DialogResult.Yes)
                {
                    btnGuardarArchivo_Click(sender, e);
                }
                else if (opcionSel == DialogResult.No)
                {
                    editorTextBox.Clear();
                    nombreArchivo = null;
                    guardado = true;
                }
            }
            else
            {
                editorTextBox.Clear();
                nombreArchivo = null;
                guardado = true;
            }
        }

        private void btnArchivoAbrir_Click(object sender, EventArgs e)
        {
            if (!guardado)
            {
                DialogResult opcionSel = MessageBox.Show("No ha guardado el archivo, ¿desea guardarlo?", "Guardar archivo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (opcionSel == DialogResult.Yes)
                {
                    btnGuardarArchivo_Click(sender, e);
                }
                else if (opcionSel == DialogResult.No)
                {
                    OpenFileDialog openFileDialog = new OpenFileDialog();
                    openFileDialog.Filter = "Formato de texto enriquecido (RTF)|*.rtf";
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        nombreArchivo = openFileDialog.FileName;
                        editorTextBox.LoadFile(nombreArchivo);
                        guardado = true;
                    }
                }
            }
            else
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Formato de texto enriquecido (RTF)|*.rtf";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    nombreArchivo = openFileDialog.FileName;
                    editorTextBox.LoadFile(nombreArchivo);
                    guardado = true;
                }
            }
        }

        private void btnGuardarArchivo_Click(object sender, EventArgs e)
        {
            if (nombreArchivo != null)
            {
                editorTextBox.SaveFile(nombreArchivo);
            }
            else
            {
                guardarComo();
            }
            guardado = true;
        }

        private void btnGuardarComoArchivo_Click(object sender, EventArgs e)
        {
            guardarComo();
            guardado = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void guardarComo()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de texto (*.rtf)|*.rtf";
            saveFileDialog.FileName = "Sin título";
            saveFileDialog.DefaultExt = "rtf";
            saveFileDialog.CreatePrompt = true;
            saveFileDialog.OverwritePrompt = true;
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                editorTextBox.SaveFile(saveFileDialog.FileName);
                nombreArchivo = saveFileDialog.FileName;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FormBuscarYReemplazar formBuscar = new FormBuscarYReemplazar();
            formBuscar.ShowDialog();
        }

        private void btnReemplazar_Click(object sender, EventArgs e)
        {
            FormBuscarYReemplazar formBuscarYReemplazar = new FormBuscarYReemplazar("e");
            formBuscarYReemplazar.ShowDialog();
        }

        private void btnSeleccionarTodo_Click(object sender, EventArgs e)
        {
            editorTextBox.SelectAll();
        }

        private void menuPrincipalAyudaBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programa hecho por Pablo Navarro Vázquez\n" +
                "Versión 1.0.0", "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnZoom100_Click(object sender, EventArgs e)
        {
            MessageBox.Show(editorTextBox.ZoomFactor.ToString());
            editorTextBox.ZoomFactor = 1;
        }

        private void btnAcercar_Click(object sender, EventArgs e)
        {
            if (editorTextBox.ZoomFactor < 63)
            {
                editorTextBox.ZoomFactor = editorTextBox.ZoomFactor + 1;
            }
        }

        private void btnAlejar_Click(object sender, EventArgs e)
        {
            if (editorTextBox.ZoomFactor > 1.515625)
            {
                editorTextBox.ZoomFactor = editorTextBox.ZoomFactor + -1;
            }
        }

        private void editorTextBox_TextChanged(object sender, EventArgs e)
        {
            guardado = false;
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!guardado)
            {
                DialogResult opcionSel = MessageBox.Show("No ha guardado el archivo, ¿desea guardarlo?", "Guardar archivo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (opcionSel == DialogResult.Yes)
                {
                    btnGuardarArchivo_Click(sender, e);
                }
                else if (opcionSel == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}