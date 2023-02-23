using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLLPractica10
{
    public class PruebaDLL
    {
        public void escribirCabecera(SerialPort puertoSerie, string cabecera)
        {
            puertoSerie.WriteLine(cabecera);
        }
    }
}
