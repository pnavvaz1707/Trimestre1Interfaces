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
        #region Campos

        private static string[] MENU_OPCIONES =
        {
            "Añadir un alumno al grupo",
            "Borrar un alumno del grupo",
            "Consultar datos de un alumno",
            "Acta del grupo",
            "Salir"
        };

        private static List<string> encabezado;
        private static List<int> posiciones;

        #endregion

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

                        imprimirEncabezadoTabla(encabezado.ToArray());

                        string[] subrayado = new string[encabezado.Count];

                        for (int i = 0; i < encabezado.Count; i++)
                        {
                            subrayado[i] = subrayar(encabezado[i]);
                        }

                        imprimirEncabezadoTabla(subrayado);

                        int numSuspensos;
                        int numSuspensos0 = 0;
                        int numSuspensos1 = 0;
                        int numSuspensos2 = 0;

                        if (g.Alumnos.Count == 0)
                        {
                            Colores.imprimirRojo("No hay alumnos registrados en el grupo");
                        }
                        else
                        {
                            g.Alumnos.Sort();

                            List<string> fila;
                            for (int i = 0; i < g.Alumnos.Count; i++)
                            {
                                fila = new List<string>();

                                fila.Add(Convert.ToString(g.Alumnos[i].Matricula));

                                if (g.Alumnos[i].Nombre.Length > 20)
                                {
                                    fila.Add(g.Alumnos[i].Nombre.Substring(0, 19) + "...");
                                }
                                else
                                {
                                    fila.Add(g.Alumnos[i].Nombre);
                                }

                                for (int j = 0; j < g.Alumnos[i].Notas.Length; j++)
                                {
                                    fila.Add(Convert.ToString(g.Alumnos[i].Notas[j]));
                                }
                                fila.Add(Convert.ToString(g.Alumnos[i].mediaAlumno()));

                                numSuspensos = g.Alumnos[i].numSuspensosAlumno();
                                fila.Add(Convert.ToString(numSuspensos));

                                imprimirFilaTabla(fila.ToArray());

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

                            fila = new List<string>();

                            Console.WriteLine();

                            fila.Add("MEDIA");
                            fila.Add("");

                            for (int i = 0; i < g.Alumnos[0].Notas.Length; i++)
                            {
                                fila.Add(Convert.ToString(g.mediaAsignatura(i)));
                            }

                            imprimirFilaTabla(fila.ToArray());

                            Console.WriteLine();

                            Console.WriteLine("Alumnos con 0 asignaturas suspensas: " + numSuspensos0);
                            Console.WriteLine("Alumnos con 1 asignaturas suspensa: " + numSuspensos1);
                            Console.WriteLine("Alumnos con 2 asignaturas suspensas: " + numSuspensos2);
                            Console.WriteLine("Alumnos con 3 o más asignaturas suspensas: " + (g.Alumnos.Count - numSuspensos0 - numSuspensos1 - numSuspensos2));
                        }

                        Auxiliar.pulsarParaContinuar();
                        break;
                }
            } while (opcion != 5);
        }

        private static Grupo crearGrupo()
        {
            encabezado = new List<string>();
            encabezado.Add("MATRÍCULA");
            encabezado.Add("NOMBRE");

            string nombre = Auxiliar.leerCadena("Indica el nombre del grupo: ");
            int numAsignaturas = Auxiliar.solicitarEnteroEnUnRango(5, 9, "Indica el número de asignaturas: ");

            string[] codigosAsignaturas = new string[numAsignaturas];

            Console.WriteLine("Escriba los códigos de las asignaturas (3 caracteres)");
            for (int i = 0; i < codigosAsignaturas.Length; i++)
            {
                string asignatura = null;
                do
                {
                    asignatura = Auxiliar.leerCadena("Asignatura " + (i + 1) + ": ", 3);
                    if (encabezado.Contains(asignatura))
                    {
                        Console.SetCursorPosition(14, Console.CursorTop - 1);
                        Colores.imprimirRojo("--> La asignatura " + asignatura + " ya existe");
                        asignatura = null;
                    }
                } while (asignatura == null);

                codigosAsignaturas[i] = asignatura;
                encabezado.Add(codigosAsignaturas[i]);
            }
            encabezado.Add("MEDIA");
            encabezado.Add("Nº SUS");
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

        private static void imprimirEncabezadoTabla(string[] fila)
        {
            posiciones = new List<int>();

            for (int i = 0; i < fila.Length - 1; i++)
            {
                posiciones.Add(Console.CursorLeft);
                Console.Write(fila[i]);
                if (i == 1)
                {
                    Console.SetCursorPosition(Console.CursorLeft + 22, Console.CursorTop);
                }
                else
                {
                    Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop);
                }
            }
            posiciones.Add(Console.CursorLeft);
            Console.WriteLine(fila[fila.Length - 1]);
        }
        private static void imprimirFilaTabla(string[] fila)
        {
            for (int i = 0; i < fila.Length; i++)
            {
                Console.SetCursorPosition(posiciones[i], Console.CursorTop);
                Console.Write(fila[i]);

            }
            Console.WriteLine();
        }

        private static string subrayar(string palabra)
        {
            string subrayado = "";
            for (int i = 0; i < palabra.Length; i++)
            {
                subrayado += "-";
            }
            return subrayado;
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
