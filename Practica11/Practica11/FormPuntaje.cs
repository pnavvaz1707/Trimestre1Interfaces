﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
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
        string nivel;
        public FormPuntaje(string nivel)
        {
            InitializeComponent();
            this.nivel = nivel;
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            StringCollection usuarios = Properties.Settings.Default.Usuarios;
            StringCollection puntajes = Properties.Settings.Default.Puntajes;

            if (usuarios == null)
            {
                usuarios = new StringCollection();
            }

            if (puntajes == null)
            {
                puntajes = new StringCollection();
            }

            usuarios.Add(txtRegistrar.Text);
            puntajes.Add(nivel);

            Properties.Settings.Default.Usuarios = usuarios;
            Properties.Settings.Default.Puntajes = puntajes;

            Properties.Settings.Default.Save();

            mostrarUsuarios();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            mostrarUsuarios();
        }

        private void mostrarUsuarios()
        {
            StringCollection usuarios = Properties.Settings.Default.Usuarios;
            StringCollection puntajes = Properties.Settings.Default.Puntajes;
            if (usuarios == null || puntajes == null)
            {
                Label noUsuarios = new Label();
                noUsuarios.Text = "No se han encontrado usuarios";
                noUsuarios.Width = 180;
                noUsuarios.Location = new Point(50, 50 + 40);
                this.Controls.Add(noUsuarios);
            }
            else
            {
                Label usuarioTitulo = new Label();
                usuarioTitulo.Text = "Usuarios";
                usuarioTitulo.Width = 100;
                usuarioTitulo.Location = new Point(40, 40);

                Label puntajeTitulo = new Label();
                puntajeTitulo.Text = "Puntajes";
                puntajeTitulo.Width = 100;
                puntajeTitulo.Location = new Point(200, 40);

                this.Controls.Add(usuarioTitulo);
                this.Controls.Add(puntajeTitulo);

                for (int i = 0; i < usuarios.Count && i < 5; i++)
                {
                    Label usuario = new Label();

                    usuario.Text = usuarios[i].ToString();
                    usuario.Width = 150;
                    usuario.Location = new Point(40, 60 + (i * 40));

                    Label puntaje = new Label();
                    puntaje.Text = puntajes[i].ToString();
                    puntaje.Width = 70;
                    puntaje.Location = new Point(200, 60 + (i * 40));

                    this.Controls.Add(usuario);
                    this.Controls.Add(puntaje);
                }
            }
            txtRegistrar.Visible = false;
            btnCancelar.Visible = false;
            btnRegistrar.Visible = false;
        }
    }
}