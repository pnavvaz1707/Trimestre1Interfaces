using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
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
    }
}
