using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5
{
    internal class Grupo
    {
        private string nombre;
        private int numAsignaturas;
        private string[] codigosAsignaturas;
        private List<Alumno> alumnos;

        public string Nombre { get { return nombre; } }
        public int NumAsignaturas { get { return numAsignaturas; } }
        public List<Alumno> Alumnos { get { return alumnos; } }

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
            Console.WriteLine("Tamaño alumnos --> " + alumnos.Count);
            for (int i = 0; i < alumnos.Count; i++)
            {
                total += alumnos[i].Notas[posicionAsignatura];
            }
            return (total / alumnos.Count);
        }

        public void actaGrupo()
        {
            int numSuspensos = 0;
            int numSuspensos0 = 0;
            int numSuspensos1 = 0;
            int numSuspensos2 = 0;

            alumnos.Sort();
            for (int i = 0; i < alumnos.Count; i++)
            {
                alumnos[i].imprimeAlumno();
                Console.Write("Notas: " + alumnos[i].Notas.ToString());
                /*for (int j = 0; j < alumnos[i].Notas.Length; j++)
                {
                    Console.Write(alumnos[i].Notas[j]);
                }*/
                Console.WriteLine("\nNota media: " + alumnos[i].mediaAlumno());
                numSuspensos = alumnos[i].numSuspensosAlumno();
                Console.WriteLine("Número de suspensos: " + numSuspensos);
                switch (numSuspensos)
                {
                    case 0:
                        numSuspensos0++;
                        break;
                    case 1:
                        numSuspensos1++;
                        break;
                    case 2:
                        numSuspensos2++;
                        break;

                }
            }
            for (int i = 0; i < alumnos[0].Notas.Length; i++)
            {
                Console.WriteLine("Media del grupo (asignatura " + i + "): " + mediaAsignatura(i));
            }
            Console.WriteLine("Alumnos con 0 asignaturas suspensas: " + numSuspensos0);
            Console.WriteLine("Alumnos con 1 asignaturas suspensa: " + numSuspensos1);
            Console.WriteLine("Alumnos con 2 asignaturas suspensas: " + numSuspensos2);
            Console.WriteLine("Alumnos con 3 o más asignaturas suspensas: " + (alumnos.Count - numSuspensos0 - numSuspensos1 - numSuspensos2));
        }

    }
}
