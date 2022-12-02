using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Practica2
{
    internal class Aplicacion
    {

        #region Variables

        private static string[] MENU_OPCIONES =
        {
            "Introducir empleado",
            "Calcular nómina de un empleado"
        };

        private static ArrayList empleados = new ArrayList();

        #endregion

        public static void Main(string[] args)
        {
            bool sigue = true;

            Colores.imprimirVerde("\n\t\t----- Programa para calcular la nómina de un empleado -----\n");

            while (sigue)
            {
                crearMenu();
                int respuesta = solicitarEnteroEnUnRango(0, MENU_OPCIONES.Length, "Seleccione una opción");
                switch (respuesta)
                {
                    case 1:
                        imprimirEncabezado(respuesta);

                        Empleado empleado = new Empleado();

                        empleado.Categoria = solicitarEnteroEnUnRango(1, 3, "Introduzca la categoría (1, 2 o 3)");

                        empleado.Nif = solicitarNif();

                        Console.WriteLine("Introduzca el nombre");
                        empleado.Nombre = Console.ReadLine();

                        empleado.NumTrienios = solicitarEnteroEnUnRango(0, 12, "Introduzca el número de trienios");

                        empleado.NumHijos = solicitarEnteroEnUnRango(0, 11, "Introduzca el número de hijos");

                        empleados.Add(empleado);

                        sigue = continuarPrograma(sigue);
                        break;

                    case 2:
                        if (empleados.Count == 0)
                        {
                            Console.Clear();
                            Colores.imprimirRojo("Primero deberías crear un empleado");
                        }
                        else
                        {
                            imprimirEncabezado(respuesta);

                            try
                            {
                                Nomina nomina = new Nomina();

                                nomina.EmpleadoNomina = solicitarEmpleado();

                                nomina.FechaNomina = solicitarFecha();

                                nomina.NumHorasExtras = solicitarEnteroEnUnRango(0, 80, "Introduce las horas extras");

                                nomina.hojaSalarial();

                            }
                            catch (Exception e)
                            {
                                Colores.imprimirRojo(e.Message);
                            }

                            sigue = continuarPrograma(sigue);
                        }
                        break;
                    case 0:
                        Colores.imprimirVerde("Has salido del programa con éxito");
                        sigue = false;
                        break;
                }
            }
        }

        private static int solicitarEnteroEnUnRango(int limiteInferior, int limiteSuperior, string msg)
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

        private static DateTime solicitarFecha()
        {
            bool sigue = true;
            DateTime fecha = new DateTime();
            string fechaString;

            while (sigue)
            {
                try
                {
                    fechaString = Convert.ToString(solicitarEnteroEnUnRango(1, 31, "Introduce el día"));

                    fechaString += "/" + solicitarEnteroEnUnRango(1, 12, "Introduce el mes");

                    fechaString += "/" + solicitarEnteroEnUnRango(DateTime.Now.Year - 50, DateTime.Now.Year, "Introduce el año");

                    fecha = Convert.ToDateTime(fechaString);

                    if (fecha > DateTime.Now)
                    {
                        throw new Exception("La fecha introducida es futura");
                    }

                    sigue = false;
                }
                catch (FormatException)
                {
                    Colores.imprimirRojo("El mes introducido no tiene tantos días");
                }
                catch (Exception e)
                {
                    Colores.imprimirRojo(e.Message);
                }
            }
            return fecha;
        }

        private static string solicitarNif()
        {
            bool sigue = true;
            string respuesta = null;

            while (sigue)
            {
                try
                {
                    Console.WriteLine("Introduzca el nif del empleado (p.ej: 12345678Z)");
                    respuesta = Console.ReadLine().ToUpper();

                    Regex regex = new Regex(@"\d{8}[A-Z]");

                    if (regex.IsMatch(respuesta) && respuesta.Length == 9)
                    {

                        int numDni = Convert.ToInt32(respuesta.Substring(0, respuesta.Length - 1));
                        int letra = numDni % 23;
                        char[] letras = new char[]
                        {
                            'T','R','W','A','G','M','Y','F',
                            'P','D','X','B','N','J','Z','S',
                            'Q','V','H','L','C','K','E'

                        };

                        if (!(respuesta[respuesta.Length - 1] == letras[letra]))
                        {
                            throw new Exception("La letra introducida no es correcta");

                        }
                        else
                        {
                            for (int i = 0; i < empleados.Count; i++)
                            {
                                if (((Empleado)empleados[i]).Nif == respuesta)
                                {
                                    throw new Exception("El NIF introducido ya está asociado a otro empleado");
                                }
                            }
                        }

                        sigue = false;
                    }
                    else
                    {
                        throw new Exception("Un NIF debe formarse por 8 números y una letra");
                    }
                }
                catch (Exception e)
                {
                    Colores.imprimirRojo(e.Message);
                }
            }
            return respuesta;
        }

        private static Empleado solicitarEmpleado()
        {
            bool sigue = true;
            Empleado empleado = null;

            while (sigue)
            {
                try
                {
                    Console.WriteLine("Introduce el NIF del empleado al que desea crear la nómina");
                    string respuesta = Console.ReadLine().ToUpper();

                    bool sigueBuscando = true;
                    int i = 0;
                    while (sigueBuscando && i < empleados.Count)
                    {
                        if (((Empleado)empleados[i]).Nif == respuesta)
                        {
                            empleado = (Empleado)empleados[i];
                            sigueBuscando = false;
                        }
                        i++;
                    }

                    if (empleado == null)
                    {
                        throw new Exception("No hay ningún empleado asociado a ese NIF");
                    }
                    sigue = false;
                }
                catch (Exception e)
                {
                    Colores.imprimirRojo(e.Message);
                }
            }
            return empleado;
        }

        private static bool continuarPrograma(bool siguePrograma)
        {
            bool siguePreguntando = true;
            string respuesta;
            while (siguePreguntando)
            {
                try
                {
                    Console.WriteLine("¿Deseas seguir con el programa?");
                    respuesta = Console.ReadLine().ToLower();
                    if (respuesta.Equals("si") || respuesta.Equals("sí"))
                    {
                        Console.Clear();
                        siguePreguntando = false;
                    }
                    else if (respuesta.Equals("no"))
                    {
                        Colores.imprimirVerde("Has salido del programa con éxito");
                        siguePreguntando = false;
                        siguePrograma = false;
                    }
                    else
                    {
                        Console.Clear();
                        throw new Exception("Debe introducir un si o un no");
                    }
                }
                catch (Exception e)
                {
                    Colores.imprimirRojo(e.Message);
                }
            }
            return siguePrograma;

        }

        private static void crearMenu()
        {
            for (int i = 0; i < MENU_OPCIONES.Length; i++)
            {
                Colores.imprimirAzul((i + 1) + ". " + MENU_OPCIONES[i]);
            }
            Colores.imprimirRojo("0. Salir");
        }
        private static void imprimirEncabezado(int respuesta)
        {
            Console.Clear();
            Colores.imprimirAzul("Has seleccionado " + MENU_OPCIONES[respuesta - 1]);
        }
    }
}
