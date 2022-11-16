using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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
    internal class Aplicacion
    {
        private static string[] MENU_OPCIONES =
        {
            "Añadir un alumno al grupo",
            "Borrar un alumno del grupo",
            "Consultar datos de un alumno",
            "Acta del grupo",
            "Salir"
        };

        public static void Main(string[] args)
        {
            Grupo g = crearGrupo();
            int opcion;
            do
            {
                opcion = menu(g);

                imprimirEncabezado(opcion);

                switch (opcion)
                {
                    case 1:
                        g.anadirAlumno(crearAlumno(g));
                        Auxiliar.pulsarParaContinuar();
                        break;

                    case 2:

                        Auxiliar.pulsarParaContinuar();
                        break;

                    case 3:

                        Auxiliar.pulsarParaContinuar();
                        break;

                    case 4:
                        List<string> encabezado = new List<string>();

                        encabezado.Add("MATRÍCULA");
                        Console.Write(encabezado[0]);
                        Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop);

                        encabezado.Add("NOMBRE");
                        Console.Write(encabezado[1]);
                        Console.SetCursorPosition(Console.CursorLeft + 22, Console.CursorTop);
                        for (int i = 0; i < g.CodigosAsignaturas.Length; i++)
                        {
                            encabezado.Add(g.CodigosAsignaturas[i]);
                            Console.Write(g.CodigosAsignaturas[i]);
                            Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop);
                        }
                        encabezado.Add("MEDIA");
                        Console.Write(encabezado[g.CodigosAsignaturas.Length + 2]);
                        Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop);
                        encabezado.Add("Nº SUS");
                        Console.WriteLine(encabezado[g.CodigosAsignaturas.Length + 3]);

                        for (int i = 0; i < encabezado[0].Length; i++)
                        {
                            Console.Write("-");
                        }
                        Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop);

                        for (int i = 0; i < encabezado[1].Length; i++)
                        {
                            Console.Write("-");
                        }
                        Console.SetCursorPosition(Console.CursorLeft + 22, Console.CursorTop);

                        for (int i = 0; i < g.CodigosAsignaturas.Length; i++)
                        {
                            Console.Write("---");
                            Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop);
                        }

                        for (int i = 0; i < encabezado[g.CodigosAsignaturas.Length + 2].Length; i++)
                        {
                            Console.Write("-");
                        }
                        Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop);
                        for (int i = 0; i < encabezado[g.CodigosAsignaturas.Length + 3].Length; i++)
                        {
                            Console.Write("-");
                        }

                        int numSuspensos;
                        int numSuspensos0 = 0;
                        int numSuspensos1 = 0;
                        int numSuspensos2 = 0;

                        g.Alumnos.Sort();
                        for (int i = 0; i < g.Alumnos.Count; i++)
                        {



                            Console.WriteLine("\nNota media: " + g.Alumnos[i].mediaAlumno());

                            numSuspensos = g.Alumnos[i].numSuspensosAlumno();
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
                        Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop);
                        for (int i = 0; i < g.Alumnos[0].Notas.Length; i++)
                        {
                            Console.SetCursorPosition(Console.CursorLeft + 5, Console.CursorTop);
                            Console.WriteLine("Media del grupo (asignatura " + g.CodigosAsignaturas[i] + "): " + g.mediaAsignatura(i));
                        }
                        Console.WriteLine("Alumnos con 0 asignaturas suspensas: " + numSuspensos0);
                        Console.WriteLine("Alumnos con 1 asignaturas suspensa: " + numSuspensos1);
                        Console.WriteLine("Alumnos con 2 asignaturas suspensas: " + numSuspensos2);
                        Console.WriteLine("Alumnos con 3 o más asignaturas suspensas: " + (g.Alumnos.Count - numSuspensos0 - numSuspensos1 - numSuspensos2));
                        Auxiliar.pulsarParaContinuar();
                        break;
                }
            } while (opcion != 5);
        }

        private static Grupo crearGrupo()
        {
            string nombre = Auxiliar.leerCadena("Indica el nombre del grupo: ");
            int numAsignaturas = Auxiliar.solicitarEnteroEnUnRango(5, 9, "Indica el número de asignaturas: ");

            string[] codigosAsignaturas = new string[numAsignaturas];

            Console.WriteLine("Escriba los códigos de las asignaturas (3 caracteres)");
            for (int i = 0; i < codigosAsignaturas.Length; i++)
            {
                codigosAsignaturas[i] = Auxiliar.leerCadena("Asignatura " + (i + 1) + ": ", 3);
            }
            return new Grupo(nombre, numAsignaturas, codigosAsignaturas);
        }

        private static int menu(Grupo g)
        {
            Console.Clear();
            Auxiliar.imprimirCabecera("Grupo " + g.Nombre);
            crearMenu();
            return Auxiliar.solicitarEnteroEnUnRango(1, MENU_OPCIONES.Length, "Seleccione una opción\n");
        }

        private static Alumno crearAlumno(Grupo g)
        {
            string nombre = Auxiliar.leerCadena("Nombre de alumno: ");
            float[] notas = new float[g.NumAsignaturas];
            for (int i = 0; i < notas.Length; i++)
            {
                notas[i] = Auxiliar.solicitarEnteroEnUnRango(0, 10, "Nota de la asignatura " + i + ": ");
            }
            return new Alumno(nombre, notas);
        }
        private static void crearMenu()
        {
            for (int i = 0; i < MENU_OPCIONES.Length; i++)
            {
                Colores.imprimirAzul((i + 1) + ". " + MENU_OPCIONES[i]);
            }
        }

        private static void imprimirEncabezado(int respuesta)
        {
            Console.Clear();
            Colores.imprimirAzul("Has seleccionado " + MENU_OPCIONES[respuesta - 1]);
        }
    }
}
