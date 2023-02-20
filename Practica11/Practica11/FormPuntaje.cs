using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica11
{
    public partial class FormPuntaje : Form
    {
        public FormPuntaje()
        {
            InitializeComponent();
            try
            {
                ArrayList usuarios = new ArrayList(Properties.Settings.Default.Usuarios.Cast<object>().ToArray());
                ArrayList puntajes = new ArrayList(Properties.Settings.Default.Puntaje.Cast<object>().ToArray());
                for (int i = 0; i < usuarios.Count; i++)
                {
                    Label usuario = new Label();
                    usuario.Text = usuarios[i].ToString();
                    usuario.Width = 150;
                    usuario.Location = new Point(40, 60 + (i * 40));

                    Label puntaje = new Label();
                    puntaje.Text = puntajes[i].ToString();
                    puntaje.Width = 20;
                    puntaje.Location = new Point(215, 60 + (i * 40));

                    this.Controls.Add(usuario);
                }
            }
            catch (Exception)
            {
                Label usuariop = new Label();
                usuariop.Text = "No se han encontrado usuarios";
                usuariop.Width = usuariop.Text.Length;
                usuariop.Location = new Point(50, 50 + 40);
                this.Controls.Add(usuariop);
            }

        }

        private void txtRegistrar_TextChanged(object sender, EventArgs e)
        {
            if (txtRegistrar.Text.Length > 25)
            {
                errorProvider.SetError(txtRegistrar, "El nombre debe ser menor que 25 carácteres");
            }
            else
            {
                errorProvider.SetError(txtRegistrar, "");
            }
            habilitarBoton();
        }
        private void habilitarBoton()
        {
            if (errorProvider.GetError(txtRegistrar) != "")
            {
                btnRegistrar.Enabled = false;
            }
            else
            {
                btnRegistrar.Enabled = true;
            }
        }
    }
}
