using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* PRÁCTICA.............: Práctica 8
* NOMBRE y APELLIDOS...: Pablo Navarro Vázquez
* CURSO y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO de la PRÁCTICA: Uso del IDE V.Studio
* FECHA de ENTREGA.....: 20 de Enero de 2023
*/


namespace Practica8
{
    internal class Grupo
    {
        #region Campos

        private string nombre;
        private string[] codigosAsignaturas;
        private List<Alumno> alumnos;

        #endregion

        #region Propiedades

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string[] CodigosAsignaturas { get { return codigosAsignaturas; } set { codigosAsignaturas = value; } }
        public List<Alumno> Alumnos { get { return alumnos; } set { alumnos = value; } }

        #endregion

        public Grupo(string nombre, string[] codigosAsignaturas)
        {
            this.nombre = nombre;
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
            if (posicion == -1)
            {
                throw new ArgumentOutOfRangeException();
            }

            return alumnos[posicion];
        }

        public bool borrarAlumno(int matricula)
        {
            int posicion = localizarAlumno(matricula);
            bool borrar = false;
            if (posicion == -1)
            {
                throw new ArgumentOutOfRangeException();
            }
            Console.WriteLine("Introduce 1 si está seguro de borrar a " + alumnos[posicion].Nombre);
            string respuesta = Console.ReadLine();
            if (respuesta.Equals("1"))
            {
                alumnos.RemoveAt(posicion);
                borrar = true;
            }
            else
            {
                borrar = false;
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

        private string obtenerAsignaturas()
        {
            string asignaturas = "";
            for (int i = 0; i < CodigosAsignaturas.Length; i++)
            {
                if (i == CodigosAsignaturas.Length - 1)
                {
                    asignaturas += CodigosAsignaturas[i];
                }
                else if (i == CodigosAsignaturas.Length - 2)
                {
                    asignaturas += CodigosAsignaturas[i] + " y ";
                }
                else
                {
                    asignaturas += CodigosAsignaturas[i] + ", ";
                }
            }
            return asignaturas;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
