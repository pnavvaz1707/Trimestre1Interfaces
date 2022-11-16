using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5
{
    internal class Auxiliar
    {
        public static string leerCadena(string mensaje)
        {
            bool sigue = true;
            string respuesta = null;
            while (sigue)
            {
                try
                {
                    Console.Write(mensaje);
                    respuesta = Console.ReadLine();
                    if (respuesta == "")
                    {
                        throw new Exception("La cadena no puede estar vacía");
                    }
                    sigue = false;
                }
                catch (Exception e)
                {
                    Console.SetCursorPosition(mensaje.Length, Console.CursorTop - 1);
                    Colores.imprimirRojo("--> " + e.Message);
                }
            }
            return respuesta;
        }
        public static string leerCadena(string mensaje, int longitudMaxima)
        {
            bool sigue = true;
            string respuesta = null;
            while (sigue)
            {
                try
                {
                    Console.Write(mensaje);
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
                    Console.SetCursorPosition(mensaje.Length, Console.CursorTop - 1);
                    Colores.imprimirRojo("--> " + e.Message);
                }
            }
            return respuesta;
        }

        public static int solicitarEnteroEnUnRango(int limiteInferior, int limiteSuperior, string msg)
        {
            bool sigue = true;
            int num = 0;

            while (sigue)
            {
                try
                {
                    Console.Write(msg);
                    num = Convert.ToInt32(Console.ReadLine());
                    if (num < limiteInferior || num > limiteSuperior)
                    {
                        throw new Exception("El número debe estar comprendido en el siguiente rango [" + limiteInferior + "," + limiteSuperior + "]");
                    }
                    sigue = false;
                }
                catch (FormatException)
                {
                    Console.SetCursorPosition(msg.Length, Console.CursorTop - 1);
                    Colores.imprimirRojo("--> Debe introducir un número entero");
                }
                catch (OverflowException)
                {
                    Console.SetCursorPosition(msg.Length, Console.CursorTop - 1);
                    Colores.imprimirRojo("--> El número introducido es demasiado alto");
                }
                catch (Exception e)
                {
                    Console.SetCursorPosition(msg.Length, Console.CursorTop - 1);
                    Colores.imprimirRojo("--> " + e.Message);
                }
            }
            return num;
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
            string cabecera = "";
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                cabecera += "─";
            }

            cabecera = "┌" + cabecera.Substring(1, cabecera.Length - 2) + "┐";

            Console.WriteLine(cabecera);
            Console.Write("│");
            Console.SetCursorPosition(((Console.WindowWidth - 1) / 2) + ((msg.Length - 1) / 2), Console.CursorTop);
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
    }
}
