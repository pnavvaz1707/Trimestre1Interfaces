using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

/*
* PRÁCTICA.............: Práctica 4
* NOMBRE y APELLIDOS...: Pablo Navarro Vázquez
* CURSO y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO de la PRÁCTICA: Uso del IDE V.Studio
* FECHA de ENTREGA.....: 10 de Noviembre de 2022
*/

namespace Practica4
{
    internal class PruebaFichas
    {
        private static string[] MENU_OPCIONES =
        {
            "Crear la ficha de un libro",
            "Crear la ficha de un libro con volumen",
            "Crear la ficha de una revista",
            "Crear la ficha de un DVD",
            "Consultar biblioteca",
            "Salir"
        };

        public static void Main(string[] args)
        {
            int opcion;
            ArrayList fichas = new ArrayList();
            Ficha ficha;
            do
            {
                opcion = menu();

                imprimirEncabezado(opcion);

                switch (opcion)
                {
                    case 1:
                        ficha = creaFichaLibro();
                        fichas.Add(ficha);

                        Console.Clear();

                        ficha.imprimir();

                        pulsarParaContinuar();
                        break;

                    case 2:
                        ficha = creaFichaLibroVol();
                        fichas.Add(ficha);

                        Console.Clear();

                        ficha.imprimir();

                        pulsarParaContinuar();
                        break;

                    case 3:
                        ficha = creaFichaRevista();

                        fichas.Add(ficha);

                        Console.Clear();

                        ficha.imprimir();

                        pulsarParaContinuar();
                        break;

                    case 4:
                        ficha = creaFichaDVD();
                        fichas.Add(ficha);

                        Console.Clear();

                        ficha.imprimir();

                        pulsarParaContinuar();
                        break;

                    case 5:
                        int contador = 1;
                        int i = 0;
                        bool sigue = true;
                        while (i < fichas.Count && sigue)
                        {
                            ((Ficha)fichas[i]).imprimir();
                            Console.WriteLine();
                            i++;
                            if (contador == 2 && i < fichas.Count)
                            {
                                sigue = Auxiliar.seguirBucle("¿Desea ver otras dos fichas más?");
                                contador = 0;
                            }
                            contador++;
                        }
                        pulsarParaContinuar();
                        break;
                }
            } while (opcion != 6);
        }

        private static FichaLibro creaFichaLibro()
        {
            string referencia, titulo, autor, editorial;
            int numEjemplares;

            referencia = Auxiliar.leerCadena("Introduce la referencia del libro: ");
            titulo = Auxiliar.leerCadena("Introduce el título del libro: ");
            numEjemplares = Auxiliar.solicitarEnteroEnUnRango(0, Int32.MaxValue, "Introduce el número de ejemplares: ");
            autor = Auxiliar.leerCadena("Introduce el autor del libro: ");
            editorial = Auxiliar.leerCadena("Introduce la editorial del libro: ");

            return new FichaLibro(referencia, titulo, numEjemplares, autor, editorial);
        }
        private static FichaLibroVol creaFichaLibroVol()
        {
            string referencia, titulo, autor, editorial;
            int numEjemplares, volumen;

            referencia = Auxiliar.leerCadena("Introduce la referencia del libro: ");
            titulo = Auxiliar.leerCadena("Introduce el título del libro: ");
            numEjemplares = Auxiliar.solicitarEnteroEnUnRango(0, Int32.MaxValue, "Introduce el número de ejemplares: ");
            autor = Auxiliar.leerCadena("Introduce el autor del libro: ");
            editorial = Auxiliar.leerCadena("Introduce la editorial del libro: ");
            volumen = Auxiliar.solicitarEnteroEnUnRango(0, Int32.MaxValue, "Introduce el volumen del libro: ");

            return new FichaLibroVol(referencia, titulo, numEjemplares, autor, editorial, volumen);
        }
        private static FichaRevista creaFichaRevista()
        {
            string referencia, titulo, fechaPublicacion;
            int numEjemplares, numRevista;

            referencia = Auxiliar.leerCadena("Introduce la referencia de la revista: ");
            titulo = Auxiliar.leerCadena("Introduce el título de la revista: ");
            numEjemplares = Auxiliar.solicitarEnteroEnUnRango(0, Int32.MaxValue, "Introduce el número de ejemplares: ");
            numRevista = Auxiliar.solicitarEnteroEnUnRango(0, Int32.MaxValue, "Introduce el número de la revista: ");
            fechaPublicacion = Convert.ToString(Auxiliar.solicitarEnteroEnUnRango(DateTime.Now.Year - 100, DateTime.Now.Year, "Introduce la fecha de publicación de la revista: "));

            return new FichaRevista(referencia, titulo, numEjemplares, numRevista, fechaPublicacion);
        }
        private static FichaDVD creaFichaDVD()
        {
            string referencia, titulo, director, fechaProduccion;
            int numEjemplares, numProtagonistas;

            referencia = Auxiliar.leerCadena("Introduce la referencia del DVD: ");
            numEjemplares = Auxiliar.solicitarEnteroEnUnRango(0, Int32.MaxValue, "Introduce el número de ejemplares de DVD: ");
            titulo = Auxiliar.leerCadena("Introduce el título del DVD: ");
            director = Auxiliar.leerCadena("Introduce el director del DVD: ");
            fechaProduccion = Convert.ToString(Auxiliar.solicitarEnteroEnUnRango(DateTime.Now.Year - 100, DateTime.Now.Year, "Introduce la fecha de producción del DVD: "));
            numProtagonistas = Auxiliar.solicitarEnteroEnUnRango(1, 20, "Nº de actores: ");
            ArrayList protagonistas = crearProtagonistas(numProtagonistas);

            return new FichaDVD(referencia, titulo, numEjemplares, director, fechaProduccion, protagonistas);
        }


        private static ArrayList crearProtagonistas(int numProtagonistas)
        {
            ArrayList protagonistas = new ArrayList();

            for (int i = 1; i <= numProtagonistas; i++)
            {
                protagonistas.Add(Auxiliar.leerCadena("\t- Actor " + i + "º: "));
            }


            return protagonistas;
        }

        private static int menu()
        {
            Console.Clear();
            Colores.imprimirVerde("\n\t\t----- GESTIÓN BIBLIOTECA -----\n");
            Console.WriteLine("Elija el tipo de Ficha a crear");
            crearMenu();
            return Auxiliar.solicitarEnteroEnUnRango(1, MENU_OPCIONES.Length, "Seleccione una opción\n");
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

        private static void pulsarParaContinuar()
        {
            Console.WriteLine("\nPulse una tecla para continuar...");
            Console.ReadKey();
        }
    }
}
