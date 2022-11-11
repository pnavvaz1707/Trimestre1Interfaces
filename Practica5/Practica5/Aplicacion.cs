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
            int opcion;
            Grupo g = crearGrupo();
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
            Colores.imprimirVerde("\n\t\t----- Grupo " + g.Nombre + " -----\n");
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
