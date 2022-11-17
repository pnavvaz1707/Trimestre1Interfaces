using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* PRÁCTICA.............: Práctica 5
* NOMBRE y APELLIDOS...: Pablo Navarro Vázquez
* CURSO y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO de la PRÁCTICA: Uso del IDE V.Studio
* FECHA de ENTREGA.....: 17 de Noviembre de 2022
*/


namespace Practica5
{
    internal class Grupo
    {
        #region Campos

        private string nombre;
        private int numAsignaturas;
        private string[] codigosAsignaturas;
        private List<Alumno> alumnos;

        #endregion

        #region Propiedades

        public string Nombre { get { return nombre; } }
        public int NumAsignaturas { get { return numAsignaturas; } }
        public string[] CodigosAsignaturas { get { return codigosAsignaturas; } }
        public List<Alumno> Alumnos { get { return alumnos; } }

        #endregion

        public Grupo(string nombre, int numAsignaturas, string[] codigosAsignaturas)
        {
            this.nombre = nombre;
            this.numAsignaturas = numAsignaturas;
            this.codigosAsignaturas = codigosAsignaturas;
            this.alumnos = new List<Alumno>();
        }

        public void anadirAlumno(Alumno alumno)
        {
            alumnos.Add(alumno);
        }

        private int localizarAlumno(int matricula)
        {
            int posicion = -1;
            for (int i = 0; i < alumnos.Count; i++)
            {
                if (alumnos[i].Matricula == matricula)
                {
                    posicion = i;
                }
            }
            return posicion;
        }

        public Alumno buscarAlumno(int matricula)
        {
            int posicion = localizarAlumno(matricula);
            Alumno alumnoEncontrado = null;
            if (posicion != -1)
            {
                alumnoEncontrado = alumnos[posicion];
            }
            return alumnoEncontrado;
        }

        public bool borrarAlumno(int matricula)
        {
            int posicion = localizarAlumno(matricula);
            bool borrar = false;
            if (posicion != -1)
            {
                alumnos.RemoveAt(posicion);
                borrar = true;
            }
            return borrar;
        }

        public float mediaAsignatura(int posicionAsignatura)
        {
            float total = 0;
            for (int i = 0; i < alumnos.Count; i++)
            {
                total += alumnos[i].Notas[posicionAsignatura];
            }
            return (total / alumnos.Count);
        }
    }
}
