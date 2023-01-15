/*
* PRÁCTICA.............: Práctica 8
* NOMBRE y APELLIDOS...: Pablo Navarro Vázquez
* CURSO y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO de la PRÁCTICA: Uso del IDE V.Studio
* FECHA de ENTREGA.....: 20 de Enero de 2023
*/

using System.Collections.ObjectModel;
using System.Data.Common;
using System.DirectoryServices.ActiveDirectory;
using System.Reflection;
using System.Windows.Forms;

namespace Practica8
{
    partial class FormMain : Form
    {
        private static List<Grupo> grupos = new List<Grupo>();

        public static List<Grupo> Grupos { get { return grupos; } set { grupos = value; } }
        public FormMain()
        {
            InitializeComponent();

            crearColumnas();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            dtgvGrupos.SelectedRows
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormCrearGrupo formCrearGrupo = new FormCrearGrupo();



            if (formCrearGrupo.ShowDialog() == DialogResult.OK)
            {
                // Añadir el objeto creado a la lista
                Grupo grupoAgregado = formCrearGrupo.Grupo;
                grupos.Add(grupoAgregado);
                iinsertarRegistro(grupoAgregado);

                MessageBox.Show("Se ha creado con éxito el grupo " + Grupos[0].Nombre, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            /*
            FormEditarGrupo form = new FormEditarGrupo();
            form.ShowDialog();
            dtgvGrupos.Refresh();
            MessageBox.Show("Se ha creado con éxito el grupo " + Grupos[0].Nombre, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            */
        }

        public void crearColumnas()
        {
            //Defino el objeto del que quiero crear las columnas
            Type tipo = typeof(Grupo);

            // Obtener las propiedades del tipo
            PropertyInfo[] properties = tipo.GetProperties();

            // Recorrer las propiedades
            foreach (PropertyInfo property in properties)
            {
                // Crear una nueva columna
                DataGridViewColumn column = new DataGridViewColumn();
                column.Name = property.Name;
                column.HeaderText = property.Name;
                column.ValueType = property.PropertyType;
                column.CellTemplate = new DataGridViewTextBoxCell();



                // Agregar la columna al DataGridView
                dtgvGrupos.Columns.Add(column);
            }
        }

        public void iinsertarRegistro(Grupo grupo)
        {
            // Obtener las propiedades del objeto
            PropertyInfo[] properties = grupo.GetType().GetProperties();

            // Crear una nueva fila
            int rowIndex = dtgvGrupos.Rows.Add();
            DataGridViewRow row = dtgvGrupos.Rows[rowIndex];

            // Recorrer las propiedades
            for (int i = 0; i < properties.Length; i++)
            {
                if (properties[i].PropertyType.Name.Contains("[]"))
                {
                    string[] asignaturas = (string[])properties[i].GetValue(grupo);

                    row.Cells[i].Value = string.Join(",", asignaturas);
                }
                else if (properties[i].PropertyType.Name.Contains("List"))
                {
                    List<Alumno> alumnos = (List<Alumno>)properties[i].GetValue(grupo);
                    alumnos.Add(new Alumno("Holaaa", new float[] {411,42}));
                    alumnos.Add(new Alumno("Adisdf", new float[] {411,42}));
                    MessageBox.Show("Se ha creado con éxito el grupo " + row.Cells[i].ValueType, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    row.Cells[i].Value = string.Join(",", alumnos);
                }
                else
                {
                    row.Cells[i].Value = properties[i].GetValue(grupo);
                }
            }
        }
    }
}