using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica6
{
    internal class Auxiliar
    {
        private bool comprobarEnteroEnUnRango(int num, int limiteInferior, int limiteSuperior)
        {
            return (num < limiteInferior || num > limiteSuperior);
        }
    }
}
