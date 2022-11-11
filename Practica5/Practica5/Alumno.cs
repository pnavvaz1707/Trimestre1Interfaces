using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Practica5
{
    internal class Alumno : IComparable<Alumno>
    {
        private int matricula;
        private string nombre;
        private float[] notas;
        private static int contador = 0;

        public int Matricula { get { return matricula; } }
        public string Nombre { get { return nombre; } }
        public float[] Notas { get { return notas; } }

        public Alumno(string nombre, float[] notas)
        {
            this.matricula = contador;
            this.nombre = nombre;
            this.notas = notas;
            contador++;
        }

        public void imprimeAlumno()
        {
            Console.Write("Matrícula: " + Matricula);
            Console.SetCursorPosition(Console.CursorLeft + 7, Console.CursorTop);
            Console.WriteLine("Nombre: " + Nombre);
        }

        public float mediaAlumno()
        {
            float total = 0;
            Console.WriteLine("Tamaño notas --> " + Notas.Length);
            for (int i = 0; i < Notas.Length; i++)
            {
                total += Notas[i];
            }
            return (total / Notas.Length);
        }

        public int numSuspensosAlumno()
        {
            int numSuspensos = 0;
            for (int i = 0; i < Notas.Length; i++)
            {
                if (Notas[i] < 5)
                {
                    numSuspensos++;
                }
            }
            return numSuspensos;
        }

        public int CompareTo(Alumno? other)
        {
            return this.Nombre.CompareTo(other.Nombre);
        }
    }
}
