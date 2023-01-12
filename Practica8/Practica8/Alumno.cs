using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

/*
* PRÁCTICA.............: Práctica 8
* NOMBRE y APELLIDOS...: Pablo Navarro Vázquez
* CURSO y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO de la PRÁCTICA: Uso del IDE V.Studio
* FECHA de ENTREGA.....: 12 de Enero de 2023
*/


namespace Practica8
{
    internal class Alumno : IComparable<Alumno>
    {
        #region Campos

        private int matricula;
        private string nombre;
        private float[] notas;
        private static int contador = 0;

        #endregion

        #region Propiedades

        public int Matricula { get { return matricula; } }
        public string Nombre { get { return nombre; } }
        public float[] Notas { get { return notas; } }

        #endregion

        public Alumno(string nombre, float[] notas)
        {
            contador++;
            this.matricula = contador;
            this.nombre = nombre;
            this.notas = notas;

        }

        /**
         * Constructor usado para leer por fichero
         */
        public Alumno(int matricula, string nombre, float[] notas)
        {
            this.matricula = matricula;
            this.nombre = nombre;
            this.notas = notas;
            if (contador < matricula)
            {
                contador = matricula;
            }
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

        public string obtenerNotas()
        {
            string notas = "";
            for (int i = 0; i < Notas.Length; i++)
            {
                if (i != Notas.Length - 1)
                {
                    notas += Notas[i] + ",";
                }
                else
                {
                    notas += Notas[i];
                }
            }
            return notas;
        }

        public override string ToString()
        {
            return matricula + ";" + nombre + ";" + obtenerNotas();
        }
    }
}
