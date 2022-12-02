using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* PRÁCTICA.............: Práctica 5
* NOMBRE y APELLIDOS...: Pablo Navarro Vázquez
* CURSO y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO de la PRÁCTICA: Uso del IDE V.Studio
* FECHA de ENTREGA.....: 18 de Noviembre de 2022
*/

namespace Practica5
{
    internal class Auxiliar
    {
        public static string leerCadena(string msg)
        {
            int y = Console.CursorTop;

            bool sigue = true;
            string respuesta = null;
            while (sigue)
            {
                try
                {
                    Console.SetCursorPosition(0, y);
                    Console.Write(msg);
                    respuesta = Console.ReadLine();
                    if (respuesta == "")
                    {
                        throw new Exception("La cadena no puede estar vacía");
                    }
                    sigue = false;
                }
                catch (Exception e)
                {
                    limpiarUnaLinea(msg.Length, y);

                    Console.SetCursorPosition(msg.Length, y);
                    imprimirRojo("--> " + e.Message);

                    Console.Write("Pulsa una tecla para probar otra vez");
                    Console.ReadKey();

                    limpiarUnaLinea(msg.Length, y);
                    limpiarUnaLinea(msg.Length, y + 1);
                }
            }
            return respuesta;
        }
        public static string leerCadena(string msg, int longitudMaxima)
        {
            int y = Console.CursorTop;

            bool sigue = true;
            string respuesta = null;
            while (sigue)
            {
                try
                {
                    Console.SetCursorPosition(0, y);
                    Console.Write(msg);
                    respuesta = Console.ReadLine();
                    if (respuesta == "")
                    {
                        throw new Exception("La cadena no puede estar vacía");
                    }
                    if (respuesta.Length != longitudMaxima)
                    {
                        throw new Exception("Debe escribir " + longitudMaxima + " caracteres");
                    }
                    sigue = false;
                }
                catch (Exception e)
                {
                    limpiarUnaLinea(msg.Length, y);

                    Console.SetCursorPosition(msg.Length, y);
                    imprimirRojo("--> " + e.Message);

                    Console.Write("Pulsa una tecla para probar otra vez");
                    Console.ReadKey();

                    limpiarUnaLinea(msg.Length, y);
                    limpiarUnaLinea(msg.Length, y + 1);
                }
            }
            return respuesta;
        }

        public static int solicitarEnteroEnUnRango(int limiteInferior, int limiteSuperior, string msg, string error)
        {
            int y = Console.CursorTop;

            bool sigue = true;
            int num = 0;
            while (sigue)
            {
                try
                {
                    Console.SetCursorPosition(0, y);
                    Console.Write(msg);
                    num = Convert.ToInt32(Console.ReadLine());
                    if (num < limiteInferior || num > limiteSuperior)
                    {
                        throw new Exception();
                    }
                    sigue = false;
                }
                catch (Exception)
                {
                    limpiarUnaLinea(msg.Length, y);

                    Console.SetCursorPosition(msg.Length, y);
                    imprimirRojo("--> " + error);

                    Console.Write("Pulsa una tecla para probar otra vez");
                    Console.ReadKey();

                    limpiarUnaLinea(msg.Length, y);
                    limpiarUnaLinea(msg.Length, y + 1);
                }
            }
            return num;
        }
        public static void limpiarUnaLinea(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(new string(' ', Console.WindowWidth));
        }
        public static bool seguirBucle(string msg)
        {
            bool siguePreguntando;
            bool usuarioSigue = false;
            do
            {
                Console.WriteLine(msg);
                string respuesta = Console.ReadLine();
                if (respuesta.ToLower().Equals("si"))
                {
                    usuarioSigue = true;
                    siguePreguntando = false;
                    Console.Clear();
                }
                else if (respuesta.ToLower().Equals("no"))
                {
                    usuarioSigue = false;
                    siguePreguntando = false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Debe introducir la palabra 'si' o 'no'");
                    Console.ForegroundColor = ConsoleColor.White;
                    siguePreguntando = true;
                }
            } while (siguePreguntando);
            return usuarioSigue;
        }

        public static void imprimirCabecera(string msg)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            string cabecera = new string('─', Console.WindowWidth);
            cabecera = "┌" + cabecera.Substring(1, cabecera.Length - 2) + "┐";
            Console.WriteLine(cabecera);

            Console.Write("│");
            Console.SetCursorPosition(((Console.WindowWidth - 1) / 2) - ((msg.Length - 1) / 2), Console.CursorTop);

            Console.Write(msg);

            Console.SetCursorPosition(Console.WindowWidth - 1, Console.CursorTop);
            Console.WriteLine("│");

            cabecera = cabecera.Replace('┌', '└');
            cabecera = cabecera.Replace('┐', '┘');
            Console.WriteLine(cabecera);

            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void pulsarParaContinuar()
        {
            Console.WriteLine("\nPulse una tecla para continuar...");
            Console.ReadKey();
        }

        public static void imprimirAzul(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(msg);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void imprimirRojo(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msg);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void imprimirVerde(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(msg);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
