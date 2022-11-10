using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal class FichaLibro : Ficha
    {
        private string autor;
        private string editorial;

        public string Autor { get { return autor; } }
        public string Editorial { get { return editorial; } }

        public FichaLibro(string referencia, string titulo, int numEjemplares, string autor, string editorial) : base(referencia, titulo, numEjemplares)
        {
            this.autor = autor;
            this.editorial = editorial;
        }

        public override void imprimir()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("------------ FICHA LIBRO ------------");

            Console.WriteLine("\tReferencia: " + Referencia);
            Console.WriteLine("\tTítulo....: " + Titulo);
            Console.WriteLine("\tEjemplares: " + NumEjemplares);
            Console.WriteLine("\tAutor.....: " + Autor);
            Console.WriteLine("\tEditorial.: " + Editorial);

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
