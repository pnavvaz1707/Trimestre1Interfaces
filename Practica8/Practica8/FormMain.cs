/*
* PRÁCTICA.............: Práctica 8
* NOMBRE y APELLIDOS...: Pablo Navarro Vázquez
* CURSO y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO de la PRÁCTICA: Uso del IDE V.Studio
* FECHA de ENTREGA.....: 20 de Enero de 2023
*/

using System.Reflection;

namespace Practica8
{
    partial class FormMain : Form
    {
        private static List<Grupo> grupos = new List<Grupo>();

        public static List<Grupo> Grupos { get { return grupos; } set { grupos = value; } }
        public FormMain()
        {
            InitializeComponent();

            crearColumnas(typeof(Grupo), dtgvGrupos);
            crearColumnas(typeof(Alumno), dtgvAlumnos);
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormCrearGrupo formCrearGrupo = new FormCrearGrupo();



            if (formCrearGrupo.ShowDialog() == DialogResult.OK)
            {
                // Añadir el objeto creado a la lista
                Grupo grupoAgregado = formCrearGrupo.Grupo;
                grupos.Add(grupoAgregado);
                insertarRegistro(grupoAgregado);
            }


            /*
            FormEditarGrupo form = new FormEditarGrupo();
            form.ShowDialog();
            dtgvGrupos.Refresh();
            MessageBox.Show("Se ha creado con éxito el grupo " + Grupos[0].Nombre, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            */
        }

        public void crearColumnas(Type tipo, DataGridView dtgv)
        {
            //Defino el objeto del que quiero crear las columnas

            // Obtener las propiedades del tipo
            PropertyInfo[] properties = tipo.GetProperties();

            DataGridViewColumn column = new DataGridViewColumn();
            column.Name = properties[0].Name;
            column.HeaderText = properties[0].Name;
            column.ValueType = tipo;
            column.CellTemplate = new DataGridViewTextBoxCell();

            dtgv.Columns.Add(column);

            // Recorrer las propiedades
            for (int i = 1; i < properties.Length; i++)
            {
                column = new DataGridViewColumn();
                column.Name = properties[i].Name;
                column.HeaderText = properties[i].Name;
                column.ValueType = properties[i].PropertyType;
                column.CellTemplate = new DataGridViewTextBoxCell();

                // Agregar la columna al DataGridView
                dtgv.Columns.Add(column);
            }
        }

        public void insertarRegistro(Grupo grupo)
        {
            // Obtener las propiedades del objeto
            PropertyInfo[] properties = grupo.GetType().GetProperties();

            // Crear una nueva fila
            int rowIndex = dtgvGrupos.Rows.Add();
            DataGridViewRow row = dtgvGrupos.Rows[rowIndex];

            row.Cells[0].Value = grupo;

            // Recorrer las propiedades
            for (int i = 1; i < properties.Length; i++)
            {
                if (properties[i].PropertyType.Name.Contains("[]"))
                {
                    string[] asignaturas = (string[])properties[i].GetValue(grupo);

                    row.Cells[i].Value = string.Join(",", asignaturas);
                }
                else if (properties[i].PropertyType.Name.Contains("List"))
                {
                    List<Alumno> alumnos = (List<Alumno>)properties[i].GetValue(grupo);

                    alumnos.Add(new Alumno("Holaaa", new float[] { 411, 42 }));
                    alumnos.Add(new Alumno("Adisdf", new float[] { 411, 42 }));

                    row.Cells[i].Value = string.Join(",", alumnos);
                }
                else
                {
                    row.Cells[i].Value = properties[i].GetValue(grupo);
                }
            }
        }

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {


            //FormCrearAlumno formCrearAlumno = new FormCrearAlumno(grupoSel);
        }

        private void btnBorrarAlumno_Click(object sender, EventArgs e)
        {

        }

        private void dtgvGrupos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSel = dtgvGrupos.Rows[e.RowIndex];
            if (filaSel != null)
            {
                Grupo grupoSel = (Grupo)filaSel.Cells[0].Value;
                if (grupoSel != null)
                {
                    MessageBox.Show("Se ha creado con éxito el grupo " + filaSel.Cells[0].Value, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    List<string> asignaturas = grupoSel.CodigosAsignaturas.ToList();

                    txtNombreEditarGrupo.Text = grupoSel.Nombre;
                    for (int i = 0; i < lstAsignaturasEditarGrupo.Items.Count; i++)
                    {
                        if (asignaturas.Contains(lstAsignaturasEditarGrupo.Items[i].ToString()))
                        {
                            lstAsignaturasEditarGrupo.SetItemChecked(i, true);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Errorel grupo " + filaSel.Cells[0].Value, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}