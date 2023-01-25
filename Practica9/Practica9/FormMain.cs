using Practica9.Properties;

namespace Practica9
{
    public partial class FormMain : Form
    {
        ToolStrip subMenuActivo;
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
            subMenuInicio.ResumeLayout();
            subMenuActivo = subMenuInicio;
            subMenuActivo.Visible= true;
            
        }

        private void menuPrincipalInicioBtn_Click(object sender, EventArgs e)
        {
            subMenuActivo.Visible = false;
            subMenuActivo = subMenuInicio;
            subMenuActivo.Visible = true;
        }
        
        private void menuPrincipalVerBtn_Click(object sender, EventArgs e)
        {
            subMenuActivo.Visible = false;
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
                this.menuPrincipalOcultarBtn.Image = (Image)(resources.GetObject("flecha_abajo"));
            }
            else
            {
                subMenuActivo.Visible = true;
                menuPrincipalOcultarBtn.Text = "Ocultar";
                this.menuPrincipalOcultarBtn.Image = (Image)(resources.GetObject("flecha_arriba"));
            }
        }

    }
}