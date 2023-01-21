using Practica9.Properties;

namespace Practica9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            subMenuInicio.Visible = true;
        }

        private void menuPrincipalInicioBtn_Click(object sender, EventArgs e)
        {

        }

        private void menuPrincipalVerBtn_Click(object sender, EventArgs e)
        {

        }

        private void menuPrincipalOcultarBtn_Click(object sender, EventArgs e)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            if (menuPrincipalOcultarBtn.Text == "Ocultar")
            {
                subMenuInicio.Visible = false;
                subMenuVer.Visible = false;
                menuPrincipalOcultarBtn.Text = "Mostrar";
                this.menuPrincipalOcultarBtn.Image = (Image)(resources.GetObject("flecha_abajo"));
            }
            else
            {
                subMenuInicio.Visible = true;
                this.menuPrincipalOcultarBtn.Image = (Image)(resources.GetObject("flecha_arriba"));
                menuPrincipalOcultarBtn.Text = "Ocultar";
            }
        }
    }
}