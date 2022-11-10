using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    internal class JuegoMultiplicar
    {
        #region Campos
        private int tiempoRespuesta;

        private int operando1;
        private int operando2;

        private int aciertos;
        private int fallos;

        private double resultado;

        #endregion

        #region Propiedades

        public int TiempoRespuesta { get { return tiempoRespuesta; } set { tiempoRespuesta = value; } }

        public int Operando1 { get { return operando1; } }
        public int Operando2 { get { return operando2; } }

        public int Aciertos { get { return aciertos; } }
        public int Fallos { get { return fallos; } }

        public double Resultado { get { return resultado; } }

        #endregion

        public JuegoMultiplicar()
        {

        }

        public bool comprobar(string respuesta)
        {
            bool correcto;
            resultado = operando1 * operando2;

            if (respuesta == null)
            {
                correcto = false;
                fallos += 1;
            }
            else
            {

                if (respuesta.Equals(Convert.ToString(Resultado)))
                {
                    correcto = true;
                    aciertos += 1;
                }
                else
                {
                    correcto = false;
                    fallos += 1;
                }
            }
            return correcto;
        }

        public void generarOperandos()
        {
            Random r = new Random();
            operando1 = r.Next(1, 9);
            operando2 = r.Next(1, 9);
        }
    }
}
