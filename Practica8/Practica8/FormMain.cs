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
        public static Grupo grupoSel;
        public FormMain()
        {
            InitializeComponent();

            crearColumnas(typeof(Grupo), dtgvGrupos);
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

        public void crearColumnasAlumno()
        {
            dtgvAlumnos.Columns.Clear();
            //Defino el objeto del que quiero crear las columnas
            Type tipo = typeof(Alumno);
            // Obtener las propiedades del tipo
            PropertyInfo[] properties = tipo.GetProperties();

            DataGridViewColumn column = new DataGridViewColumn();
            column.Name = properties[0].Name;
            column.HeaderText = properties[0].Name;
            column.ValueType = tipo;
            column.CellTemplate = new DataGridViewTextBoxCell();

            dtgvAlumnos.Columns.Add(column);

            // Recorrer las propiedades
            for (int i = 1; i < properties.Length; i++)
            {
                if (properties[i].PropertyType.Name.Contains("[]"))
                {

                    for (int j = 0; j < grupoSel.CodigosAsignaturas.Length; j++)
                    {
                        column = new DataGridViewColumn();
                        column.Name = grupoSel.CodigosAsignaturas[j];
                        column.HeaderText = grupoSel.CodigosAsignaturas[j];
                        column.ValueType = typeof(double);
                        column.CellTemplate = new DataGridViewTextBoxCell();

                        dtgvAlumnos.Columns.Add(column);
                    }
                }
                else
                {
                    column = new DataGridViewColumn();
                    column.Name = properties[i].Name;
                    column.HeaderText = properties[i].Name;
                    column.ValueType = properties[i].PropertyType;
                    column.CellTemplate = new DataGridViewTextBoxCell();

                    // Agregar la columna al DataGridView
                    dtgvAlumnos.Columns.Add(column);
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormCrearGrupo formCrearGrupo = new FormCrearGrupo();

            if (formCrearGrupo.ShowDialog() == DialogResult.OK)
            {
                Grupo grupoAgregado = formCrearGrupo.Grupo;
                insertarRegistro(grupoAgregado);
            }
        }
        private void btnImportar_Click(object sender, EventArgs e)
        {

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
                else if (!properties[i].PropertyType.Name.Contains("List"))
                {
                    row.Cells[i].Value = properties[i].GetValue(grupo);

                    /*List<Alumno> alumnos = (List<Alumno>)properties[i].GetValue(grupo);

                    alumnos.Add(new Alumno("Holaaa", new double[] { 411, 42 }));
                    alumnos.Add(new Alumno("Adisdf", new double[] { 411, 42 }));

                    row.Cells[i].Value = string.Join(",", alumnos);*/
                }
                /*else
                {
                }*/
            }
        }

        public void insertarRegistro(Alumno alumno)
        {
            // Obtener las propiedades del objeto
            PropertyInfo[] properties = alumno.GetType().GetProperties();

            // Crear una nueva fila
            int rowIndex = dtgvAlumnos.Rows.Add();
            DataGridViewRow row = dtgvAlumnos.Rows[rowIndex];

            int numCelda = 0;

            // Recorrer las propiedades
            for (int i = 0; i < properties.Length; i++)
            {


                if (numCelda == 1)
                {
                    row.Cells[numCelda].Value = alumno;
                    numCelda++;
                }
                else
                {
                    if (properties[i].PropertyType.Name.Contains("[]"))
                    {
                        double[] notas = (double[]) properties[i].GetValue(alumno);
                        MessageBox.Show("Se grupo " + row.Cells[numCelda].Value + "Notas --> " + string.Join(",", notas) + " Length --> " + notas.Length, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        for (int j = 0; i < notas.Length; i++)
                        {
                            
                            row.Cells[numCelda].Value = notas[j];
                            MessageBox.Show("Se grupo " + row.Cells[numCelda].Value + "Notas 0 --> " + notas[0] + " Length --> " + notas.Length + " j --> " + j, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            numCelda++;
                        }
                    }
                    else
                    {
                        row.Cells[numCelda].Value = properties[i].GetValue(alumno);
                        numCelda++;
                    }
                }
            }
        }

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            FormCrearAlumno formCrearAlumno = new FormCrearAlumno();
            if (formCrearAlumno.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < grupoSel.Alumnos.Count; i++)
                {
                    insertarRegistro(grupoSel.Alumnos[i]);
                }
            }
        }

        private void btnBorrarAlumno_Click(object sender, EventArgs e)
        {

        }

        private void dtgvGrupos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSel = dtgvGrupos.Rows[e.RowIndex];
            if (filaSel != null)
            {
                grupoSel = (Grupo)filaSel.Cells[0].Value;
                if (grupoSel != null)
                {
                    crearColumnasAlumno();
                    MessageBox.Show("Se ha creado con éxito el grupo " + filaSel.Cells[0].Value, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //insertarRegistro(grupoSel);
                }
            }
        }
    }
}