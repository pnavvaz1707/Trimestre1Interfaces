using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    public class Colores
    {
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
