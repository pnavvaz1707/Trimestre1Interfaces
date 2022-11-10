using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    public abstract class Ficha
    {
        private string referencia;
        private string titulo;
        private int numEjemplares;
        private static int numOrden;

        public string Referencia { get { return referencia; } }
        public string Titulo { get { return titulo; } }
        public int NumEjemplares { get { return numEjemplares; } }
        public int NumOrden { get { return numOrden; } }

        public Ficha(string referencia, string titulo, int numEjemplares)
        {
            this.referencia = referencia + "/" + NumOrden;
            this.titulo = titulo;
            this.numEjemplares = numEjemplares;
            numOrden++;
        }

        public abstract void imprimir();
    }
}
