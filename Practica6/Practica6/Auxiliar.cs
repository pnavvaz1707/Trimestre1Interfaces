using System;
using System.Text.RegularExpressions;

/*
* PRÁCTICA.............: Práctica 6.
* NOMBRE Y APELLIDOS...: Pablo Navarro Vázquez
* CURSO Y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO DE LA PRÁCTICA: Aplicaciones de Formulario. Controles Básicos.
* FECHA DE ENTREGA.....: 07 de diciembre de 2022
*/

namespace Practica6
{
    internal class Auxiliar
    {
        public static bool comprobarEnteroEnUnRango(int num, int limiteInferior, int limiteSuperior)
        {
            return (limiteInferior <= num && num <= limiteSuperior);
        }

        public static bool comprobarCadenaTexto(string texto)
        {
            return texto != "";
        }

        public static bool comprobarNombre(string nombre)
        {
            bool correcto = false;
            if (comprobarCadenaTexto(nombre))
            {
                Regex regex = new Regex(@"^[A-Za-z]+((-| ){1}[A-Z])*$");
                correcto = regex.IsMatch(nombre);
            }
            return correcto;
        }

        public static bool comprobarNif(string nif)
        {
            bool correcto = false;

            if (comprobarCadenaTexto(nif))
            {
                Regex regex = new Regex(@"^[0-9]{8}[A-Z]$");

                if (regex.IsMatch(nif))
                {

                    int numDni = Convert.ToInt32(nif.Substring(0, nif.Length - 1));
                    int letra = numDni % 23;
                    char[] letras = new char[]
                    {
                            'T','R','W','A','G','M','Y','F',
                            'P','D','X','B','N','J','Z','S',
                            'Q','V','H','L','C','K','E'

                    };

                    if (nif[nif.Length - 1] == letras[letra])
                    {
                        correcto = true;
                    }
                }
            }
            return correcto;
        }
    }
}
