using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

/*
* PRÁCTICA.............: Práctica 3.
* NOMBRE y APELLIDOS...: Pablo Navarro Vázquez
* CURSO y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO de la PRÁCTICA: Sentencias de Control. Excepciones.
* FECHA................: 3 de Noviembre de 2022
*/
namespace Practica3
{
    internal class PruebaJuego
    {

        #region Variables

        private static string[] MENU_OPCIONES =
        {
            "Establecer tiempo máximo para las respuestas",
            "Establecer el número de preguntas",
            "JUGAR",
            "Salir"
        };

        #endregion

        public static void Main(string[] args)
        {
            bool sigue = true;

            int opcion;
            int tiempoLimite = -1;
            int numeroPreguntas = -1;

            while (sigue)
            {
                opcion = menu();

                imprimirEncabezado(opcion);

                switch (opcion)
                {
                    case 1:
                        tiempoLimite = leerTiempoLimite();
                        break;

                    case 2:
                        numeroPreguntas = leerNumeroPreguntas();
                        break;

                    case 3:
                        if (tiempoLimite > 0 && numeroPreguntas > 0)
                        {
                            jugar(tiempoLimite, numeroPreguntas);
                        }
                        else
                        {
                            Colores.imprimirRojo("Debe ejecutar antes las opciones 1 y 2 del menú");
                            Console.WriteLine("Pulsa una tecla para continuar...");
                            Console.ReadKey();
                        }
                        break;

                    case 4:
                        sigue = false;
                        break;
                }
            }
        }

        public static int leerTiempoLimite()
        {
            return solicitarEnteroEnUnRango(3, 10, "Indique el tiempo máximo por pregunta");
        }

        public static int leerNumeroPreguntas()
        {
            return solicitarEnteroEnUnRango(1, 10, "Indique el número máximo de preguntas");
        }

        public static void jugar(int tiempoRespuesta, int numPreguntas)
        {
            JuegoMultiplicar juegoMultiplicar = new JuegoMultiplicar();

            juegoMultiplicar.TiempoRespuesta = tiempoRespuesta;

            for (int i = 0; i < numPreguntas; i++)
            {
                juegoMultiplicar.generarOperandos();
                Console.WriteLine(juegoMultiplicar.Operando1 + " x " + juegoMultiplicar.Operando2);

                if (juegoMultiplicar.comprobar(responderIntervalo(tiempoRespuesta)))
                {
                    Console.WriteLine("Bien");
                }
                else
                {
                    Console.WriteLine("Mal. El resultado era " + juegoMultiplicar.Resultado);
                }
            }

            Colores.imprimirVerde("Han habido " + juegoMultiplicar.Aciertos + " aciertos");
            Colores.imprimirRojo("Han habido " + juegoMultiplicar.Fallos + " errores");

            Console.WriteLine("La nota ha sido " + Convert.ToDouble(10 * juegoMultiplicar.Aciertos) / Convert.ToDouble((juegoMultiplicar.Aciertos + juegoMultiplicar.Fallos)) + " (" + juegoMultiplicar.Aciertos + "/" + (juegoMultiplicar.Aciertos + juegoMultiplicar.Fallos) + ")");
            Console.WriteLine("Pulsa una tecla para continuar...");
            Console.ReadKey();
        }

        public static int menu()
        {
            Console.Clear();
            Colores.imprimirVerde("\n\t\t----- Juego de multiplicar -----\n");
            crearMenu();
            return solicitarEnteroEnUnRango(0, MENU_OPCIONES.Length, "Seleccione una opción");
        }

        public static string responderIntervalo(int tiempoLimite)
        {
            string respuesta = "";
            DateTime tiempoInicio;
            TimeSpan tiempoTranscurrido;

            ConsoleKeyInfo tecla = new ConsoleKeyInfo((char)ConsoleKey.Backspace, ConsoleKey.Backspace, false, false, false);
            tiempoInicio = DateTime.Now;

            do
            {
                tiempoTranscurrido = DateTime.Now - tiempoInicio;
                if (Console.KeyAvailable)
                {
                    tecla = Console.ReadKey();
                    if (!(tecla.Key == ConsoleKey.Enter))
                    {
                        respuesta += tecla.Key;
                        respuesta = respuesta.Replace("D", ""); //Eliminamos la letra "D" que se añade a la respuesta automáticamente y no sé exactamente por qué
                    }
                }
            } while (tiempoTranscurrido.Seconds < tiempoLimite && !(tecla.Key == ConsoleKey.Enter));

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
                    Console.WriteLine(msg);
                    num = Convert.ToInt16(Console.ReadLine());
                    if (num < limiteInferior || num > limiteSuperior)
                    {
                        throw new Exception("El número debe estar comprendido en el siguiente rango [" + limiteInferior + "," + limiteSuperior + "]");
                    }
                    sigue = false;
                }
                catch (FormatException)
                {
                    Colores.imprimirRojo("Debe introducir un número entero");
                }
                catch (Exception e)
                {
                    Colores.imprimirRojo(e.Message);
                }
            }
            return num;
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
