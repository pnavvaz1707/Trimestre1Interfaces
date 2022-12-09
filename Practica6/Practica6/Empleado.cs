/*
* PRÁCTICA.............: Práctica 6.
* NOMBRE Y APELLIDOS...: Pablo Navarro Vázquez
* CURSO Y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO DE LA PRÁCTICA: Aplicaciones de Formulario. Controles Básicos.
* FECHA DE ENTREGA.....: 07 de diciembre de 2022
*/

namespace Practica6
{
    class Empleado
    {
        #region Atributos
        private int categoria;
        private string nif;
        private string nombre;
        private int numHijos;
        private int numTrienios;
        #endregion

        #region Propiedades
        public string Nif { get { return nif; } set { nif = value; } }

        public string Nombre { get { return nombre; } set { nombre = value; } }

        public int Categoria { get { return categoria; } set { categoria = value; } }

        public int NumHijos { get { return numHijos; } set { numHijos = value; } }

        public int NumTrienios { get { return numTrienios; } set { numTrienios = value; } }
        #endregion

        public Empleado(string nif, string nombre, int categoria, int numHijos, int numTrienios)
        {
            this.nif = nif;
            this.nombre = nombre;
            this.categoria = categoria;
            this.numHijos = numHijos;
            this.numTrienios = numTrienios;
        }
    }
}