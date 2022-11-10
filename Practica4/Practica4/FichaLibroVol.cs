using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal class FichaLibroVol : FichaLibro
    {
        private int volumen;
        public int Volumen { get { return volumen; } }

        public FichaLibroVol(string referencia, string titulo, int numEjemplares, string autor, string editorial, int volumen) : base(referencia, titulo, numEjemplares, autor, editorial)
        {
            this.volumen = volumen;
        }

        public override void imprimir()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("------------ FICHA LIBRO CON VOLUMEN ------------");

            Console.WriteLine("\tReferencia: " + Referencia);
            Console.WriteLine("\tTítulo....: " + Titulo);
            Console.WriteLine("\tEjemplares: " + NumEjemplares);
            Console.WriteLine("\tAutor.....: " + Autor);
            Console.WriteLine("\tEditorial.: " + Editorial);
            Console.WriteLine("\tVolumen...: " + Volumen);

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
