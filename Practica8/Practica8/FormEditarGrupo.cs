using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using CheckBox = System.Windows.Forms.CheckBox;

/*
* PRÁCTICA.............: Práctica 8
* NOMBRE y APELLIDOS...: Pablo Navarro Vázquez
* CURSO y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO de la PRÁCTICA: Uso del IDE V.Studio
* FECHA de ENTREGA.....: 12 de Enero de 2023
*/

namespace Practica8
{
    partial class FormEditarGrupo : Form
    {
        private DataGridView dtgvGrupos;

        public DataGridView DtgvGrupos { get { return dtgvGrupos; } set { dtgvGrupos = value; } }

        public FormEditarGrupo()
        {
            InitializeComponent();
        }

        private void btnCrearGrupo_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreNuevoGrupo.Text;
            List<string> asignaturasSel = (from Control c in Controls where c is CheckBox && ((CheckBox)c).Checked select c.Text).ToList();
            if (asignaturasSel.Count != 4)
            {
                MessageBox.Show("Debes seleccionar 4 asignaturas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { 
                Grupo grupo = new Grupo(nombre, asignaturasSel.ToArray());
                dtgvGrupos.Rows.Add(grupo);
                MessageBox.Show("Se ha creado con éxito el grupo " + grupo.Nombre, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
