using Practica9.Properties;
using System.Windows.Forms;

namespace Practica9
{
    public partial class FormMain : Form
    {
        TableLayoutPanel subMenuActivo;
        public FormMain()
        {
            InitializeComponent();



            /*ToolStripItemCollection prueba = subMenuInicio.Items;
            subMenuInicio.Items.Clear();
            int contador = 0;

            foreach (ToolStripItem item in prueba)
            {
                MessageBox.Show(item.Name);
                subMenuInicio.Items.Add(item);
                if (contador== 5)
                {
                    subMenuInicio.Items.Add(toolStripControlHostNumFuente);
                }
            }*/

            subMenuActivo = subMenuInicio;
            subMenuInicio.Visible = true;

            foreach (FontFamily font in System.Drawing.FontFamily.Families)
            {
                fuentesComboBox.Items.Add(font.Name);
            }

            fuentesComboBox.Text = this.richTextBox1.Font.Name.ToString();

        }

        private void menuPrincipalInicioBtn_Click(object sender, EventArgs e)
        {
            subMenuActivo.Visible = false;
            subMenuActivo = subMenuInicio;
            subMenuInicio.Visible = true;
        }
        
        private void menuPrincipalVerBtn_Click(object sender, EventArgs e)
        {
            subMenuActivo.Visible = false;
            subMenuActivo = subMenuInicio;
            subMenuInicio.Visible = true;
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
            MessageBox.Show(tamanoFuenteComboBox.Text);
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, Convert.ToInt16(tamanoFuenteComboBox.Text));
        }

        private void fuentesComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(fuentesComboBox.Text, richTextBox1.Font.Size);

        }

        private void btnNegrita_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
        }

        private void btnItalica_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Italic);

        }

        private void btnSubrayar_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Underline);

        }

        private void btnTachar_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Strikeout);

        }
    }
}