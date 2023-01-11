using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
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
    internal class Aplicacion
    {
        #region Campos

        private static string rutaPredeterminadaFichero = "../../../RutaPredeterminada.txt";
        private static string rutaFichero;

        private static string[] SUBMENU_OPCIONES =
        {
            "Añadir un alumno al grupo",
            "Borrar un alumno del grupo",
            "Consultar datos de un alumno",
            "Acta del grupo",
            "Guardar información",
            "Recuperar información",
            "Salir"
        };


        private static List<string> encabezado; //Lista tipo String que define una serie de cadenas para imprimir luego como encabezado de la tabla

        /**Lista tipo entero que guarda las posiciones donde empieza a escribir el cursor de la consola
         * para cada posición del encabezado para así alinear en columnas los datos
         */
        private static List<int> posiciones;

        private static bool datosRecuperados = false;
        private static List<Grupo> grupos = new List<Grupo>();

        #endregion

        public static void Main(string[] args)
        {
            int opcion;
            do
            {
                rutaFichero = obtenerRutaPorDefecto();

                string[] MENU_PRINCIPAL = new string[] {"Crear grupo",
                                                        "Usar grupo existente",
                                                        "Establecer ruta para recuperar información (Ruta actual: " + rutaFichero +")",
                                                        "Salir"};

                opcion = menu("Gestíon de grupos", MENU_PRINCIPAL);

                imprimirOpcionSel(opcion, MENU_PRINCIPAL);

                switch (opcion)
                {
                    case 1:
                        grupos.Add(crearGrupo());
                        break;

                    case 2:
                        if (grupos.Count > 0)
                        {


                            for (int i = 0; i < grupos.Count; i++)
                            {
                                Console.WriteLine(i + 1 + ". " + grupos[i].ToString());
                            }

                            int grupoSel = Auxiliar.solicitarEnteroEnUnRango(1, grupos.Count(), "Selecciona un grupo: ", "El número seleccionado no referencia ningún grupo");
                            Grupo g = grupos[grupoSel - 1];
                            inicializarEncabezado(g);

                            do
                            {
                                opcion = menu("Grupo '" + g.Nombre + "'", SUBMENU_OPCIONES);
                                imprimirOpcionSel(opcion, SUBMENU_OPCIONES);

                                switch (opcion)
                                {
                                    case 1:
                                        g.anadirAlumno(crearAlumno(g));
                                        Auxiliar.pulsarParaContinuar();
                                        break;

                                    case 2:
                                        mostrarAlumnos(g);

                                        int matricula = Auxiliar.solicitarEnteroEnUnRango(0, Int32.MaxValue, "Indica la matricula del alumno que desee borrar: ", "Matrícula no válida");

                                        try
                                        {
                                            if (g.borrarAlumno(matricula))
                                            {
                                                Auxiliar.imprimirVerde("Se ha borrado el alumno con matrícula " + matricula);
                                            }
                                            else
                                            {
                                                Auxiliar.imprimirRojo("No se ha borrado el alumno con matrícula " + matricula);
                                            }
                                        }
                                        catch (ArgumentOutOfRangeException)
                                        {
                                            Auxiliar.imprimirRojo("No existe el alumno con matrícula " + matricula);
                                        }
                                        Auxiliar.pulsarParaContinuar();
                                        break;

                                    case 3:
                                        try
                                        {
                                            Alumno alumnoConsultado = g.buscarAlumno(Auxiliar.solicitarEnteroEnUnRango(0, Int32.MaxValue, "Indica la matricula del alumno que desee consultar: ", "Matrícula no válida"));
                                            alumnoConsultado.imprimeAlumno();
                                        }
                                        catch (ArgumentOutOfRangeException)
                                        {
                                            Auxiliar.imprimirRojo("No existe el alumno con esa matrícula");
                                        }
                                        Auxiliar.pulsarParaContinuar();
                                        break;

                                    case 4:

                                        imprimirEncabezadoTabla(encabezado.ToArray());

                                        string[] subrayado = new string[encabezado.Count];

                                        for (int i = 0; i < encabezado.Count; i++)
                                        {
                                            subrayado[i] = new string('-', encabezado[i].Length);
                                        }

                                        imprimirEncabezadoTabla(subrayado);

                                        int numSuspensos;
                                        int numSuspensos0 = 0;
                                        int numSuspensos1 = 0;
                                        int numSuspensos2 = 0;

                                        if (g.Alumnos.Count == 0)
                                        {
                                            Auxiliar.imprimirRojo("No hay alumnos registrados en el grupo");
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
                                                fila.Add(g.Alumnos[i].mediaAlumno().ToString("0.00"));

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

                                    case 5:
                                        StreamWriter ficheroEscribir = File.CreateText(rutaFichero);

                                        for (int i = 0; i < g.Alumnos.Count; i++)
                                        {
                                            ficheroEscribir.WriteLine(g.Alumnos[i].ToString());
                                        }

                                        ficheroEscribir.Close();
                                        Auxiliar.imprimirVerde("Los datos se han guardado en el fichero " + Path.GetFullPath(rutaFichero));
                                        Auxiliar.pulsarParaContinuar();
                                        break;

                                    case 6:

                                        if (!datosRecuperados)
                                        {
                                            try
                                            {
                                                StreamReader ficheroLeer = File.OpenText(rutaFichero);

                                                recuperarDatos(ficheroLeer, g);

                                                ficheroLeer.Close();
                                            }
                                            catch (Exception)
                                            {
                                                Auxiliar.imprimirRojo("El fichero no existe o no se ha guardado ningún dato todavía");
                                            }
                                        }
                                        else
                                        {
                                            Auxiliar.imprimirRojo("Ya has recuperado los datos anteriormente");
                                        }
                                        Auxiliar.pulsarParaContinuar();
                                        break;
                                }
                            } while (opcion != 7);
                            datosRecuperados = false;
                        }
                        else
                        {
                            Auxiliar.imprimirRojo("No se ha creado ningún grupo todavía");
                            Auxiliar.pulsarParaContinuar();
                        }
                        break;

                    case 3:
                        StreamWriter ficheroPredeterminado = File.CreateText(rutaPredeterminadaFichero);

                        Console.WriteLine("Introduce la ruta en la que desea guardar o recuperar los datos del grupo");
                        string ruta = Console.ReadLine();

                        ficheroPredeterminado.Write(ruta);

                        ficheroPredeterminado.Close();

                        rutaFichero = obtenerRutaPorDefecto();

                        Auxiliar.imprimirVerde("La ruta se ha introducido correctamente");
                        Auxiliar.pulsarParaContinuar();
                        break;

                    default:
                        break;
                }
            } while (opcion != 4);
        }

        private static void mostrarAlumnos(Grupo g)
        {
            for (int i = 0; i < g.Alumnos.Count; i++)
            {
                Console.WriteLine(g.Alumnos[i].Matricula + " --> Nombre: " + g.Alumnos[i].Nombre);
            }
        }

        private static void recuperarDatos(StreamReader ficheroLeer, Grupo g)
        {
            string linea;
            int contador = 0; //Contador para saber si al menos ha leido una línea y así saber si estaba vacío o no
            bool grupoCorrecto = true;

            while ((linea = ficheroLeer.ReadLine()) != null && grupoCorrecto)
            {

                string[] datos = linea.Split(';');

                string[] notasPrueba = datos[2].Split(',');
                if (g.CodigosAsignaturas.Length == notasPrueba.Length)
                {
                    float[] notasRecuperadas = new float[notasPrueba.Length];



                    for (int i = 0; i < notasPrueba.Length; i++)
                    {
                        notasRecuperadas[i] = float.Parse(notasPrueba[i].Trim());
                    }

                    g.anadirAlumno(new Alumno(int.Parse(datos[0]), datos[1], notasRecuperadas));
                    contador++;
                }
                else
                {
                    contador++;
                    grupoCorrecto = false;
                    Auxiliar.imprimirRojo("Este fichero contiene más asignaturas de las que tiene el grupo. Prueba con otro fichero");
                }
            }
            if (contador == 0)
            {
                Auxiliar.imprimirRojo("Lo datos no se han recuperado, el fichero estaba vacío");
            }
            else if (grupoCorrecto)
            {
                Auxiliar.imprimirVerde("Se han recuperado los datos correctamente");
                datosRecuperados = true;
            }
        }

        private static string obtenerRutaPorDefecto()
        {
            string ruta = "";

            try
            {
                StreamReader ficheroLeer = File.OpenText(rutaPredeterminadaFichero);
                ruta = ficheroLeer.ReadLine();
                ficheroLeer.Close();
            }
            catch (FileNotFoundException)
            {
                File.Create(rutaPredeterminadaFichero);
            }
            return ruta;

        }

        private static void inicializarEncabezado(Grupo g)
        {
            encabezado = new List<string>();
            encabezado.Add("MATRÍCULA");
            encabezado.Add("NOMBRE");
            for (int i = 0; i < g.CodigosAsignaturas.Length; i++)
            {
                encabezado.Add(g.CodigosAsignaturas[i]);
            }
            encabezado.Add("MEDIA");
            encabezado.Add("Nº SUS");
        }

        private static Grupo crearGrupo()
        {
            string nombre = Auxiliar.leerCadena("Indica el nombre del grupo: ");
            int minAsignaturas = 4;
            int maxAsignaturas = 7;
            int numAsignaturas = Auxiliar.solicitarEnteroEnUnRango(minAsignaturas, maxAsignaturas, "Indica el número de asignaturas [" + minAsignaturas + " - " + maxAsignaturas + "]: ", "El número de asignaturas debe estar comprendido entre " + minAsignaturas + " y " + maxAsignaturas);

            string[] codigosAsignaturas = new string[numAsignaturas];

            Console.WriteLine("Escriba los códigos de las asignaturas (3 caracteres)");

            for (int i = 0; i < codigosAsignaturas.Length; i++)
            {
                string msg = "Asignatura " + (i + 1) + ": ";
                codigosAsignaturas[i] = leerAsignatura(msg, codigosAsignaturas);
            }

            return new Grupo(nombre, numAsignaturas, codigosAsignaturas);
        }

        private static string leerAsignatura(string msg, string[] codigosAsignaturas)
        {
            int y = Console.CursorTop;
            string asignatura = "";

            do
            {
                Console.SetCursorPosition(0, y);
                asignatura = Auxiliar.leerCadena(msg, 3).ToUpper();

                Regex regex = new Regex(@"[A-Z]{3}");
                if (!regex.IsMatch(asignatura))
                {
                    Console.SetCursorPosition(msg.Length, y);
                    Auxiliar.imprimirRojo("--> La asignatura solo puede contener letras");

                    Console.Write("Pulsa una tecla para probar otra vez");
                    Console.ReadKey();

                    Auxiliar.limpiarUnaLinea(msg.Length, y);
                    Auxiliar.limpiarUnaLinea(msg.Length, y + 1);

                    asignatura = null;
                }
                else
                {
                    if (codigosAsignaturas.Contains(asignatura))
                    {
                        Console.SetCursorPosition(msg.Length, y);
                        Auxiliar.imprimirRojo("--> La asignatura " + asignatura + " ya existe");

                        Console.Write("Pulsa una tecla para probar otra vez");
                        Console.ReadKey();

                        Auxiliar.limpiarUnaLinea(msg.Length, y);
                        Auxiliar.limpiarUnaLinea(msg.Length, y + 1);

                        asignatura = null;
                    }
                }
            } while (asignatura == null);
            return asignatura;
        }

        private static int menu(string encabezado, string[] menu)
        {
            Console.Clear();
            Auxiliar.imprimirCabecera(encabezado);
            crearMenu(menu);
            return Auxiliar.solicitarEnteroEnUnRango(1, menu.Length, "Seleccione una opción: ", "Opción incorrecta");
        }

        private static Alumno crearAlumno(Grupo g)
        {
            string nombre = Auxiliar.leerCadena("Nombre de alumno: ");
            float[] notas = new float[g.NumAsignaturas];
            for (int i = 0; i < notas.Length; i++)
            {
                notas[i] = Auxiliar.solicitarEnteroEnUnRango(0, 10, "Nota de la asignatura " + g.CodigosAsignaturas[i] + ": ", "La nota debe ser un número sin decimales entre 0 y 10");
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

        private static void crearMenu(string[] menu)
        {
            for (int i = 0; i < menu.Length; i++)
            {
                Auxiliar.imprimirAzul((i + 1) + ". " + menu[i]);
            }
        }

        private static void imprimirOpcionSel(int respuesta, string[] menu)
        {
            Console.Clear();
            Auxiliar.imprimirAzul("Has seleccionado " + menu[respuesta - 1]);
        }
    }
}
