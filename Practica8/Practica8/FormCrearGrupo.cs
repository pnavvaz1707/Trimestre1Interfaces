﻿/*
* PRÁCTICA.............: Práctica 8
* NOMBRE y APELLIDOS...: Pablo Navarro Vázquez
* CURSO y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO de la PRÁCTICA: Uso del IDE V.Studio
* FECHA de ENTREGA.....: 20 de Enero de 2023
*/

namespace Practica8
{
    partial class FormCrearGrupo : Form
    {
        #region Campos
        private Grupo grupo;
        #endregion

        #region Propiedades
        public Grupo Grupo { get { return grupo; } }
        #endregion

        public FormCrearGrupo()
        {
            InitializeComponent();
        }

        private void btnCrearGrupo_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreNuevoGrupo.Text;


            if (lstAsignaturasCrearGrupo.CheckedItems.Count < 4)
            {
                MessageBox.Show("Debes seleccionar al menos 4 asignaturas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string[] asignaturasSel = new string[lstAsignaturasCrearGrupo.CheckedItems.Count];

                for (int i = 0; i < lstAsignaturasCrearGrupo.CheckedItems.Count; i++)
                {
                    asignaturasSel[i] = lstAsignaturasCrearGrupo.CheckedItems[i].ToString();
                }
                grupo = new Grupo(nombre, asignaturasSel.ToArray());
                MessageBox.Show("Se ha creado con éxito el grupo " + grupo.Nombre, "Grupo creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}