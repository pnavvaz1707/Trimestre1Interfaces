using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    internal class Nomina
    {
        #region Variables

        private Empleado empleadoNomina;
        private DateTime fechaNomina;
        private int numHorasExtras;

        #endregion

        #region Propiedades

        public Empleado EmpleadoNomina { get { return empleadoNomina; } set { empleadoNomina = value; } }
        public DateTime FechaNomina { get { return fechaNomina; } set { fechaNomina = value; } }
        public int NumHorasExtras { get { return numHorasExtras; } set { numHorasExtras = value; } }

        #endregion

        public Nomina()
        {

        }

        public Nomina(Empleado empleadoNomina, DateTime fechaNomina, int numHorasExtras)
        {
            this.empleadoNomina = empleadoNomina;
            this.fechaNomina = fechaNomina;
            this.numHorasExtras = numHorasExtras;
        }

        public void hojaSalarial()
        {
            Console.Clear();

            Console.WriteLine("HOJA SALARIAL");

            Console.WriteLine("\nLIQUIDACIÓN DE HABERES AL " + fechaNomina);

            Console.WriteLine("\nNombre........: " + empleadoNomina.Nombre);
            Console.WriteLine("NIF...........: " + empleadoNomina.Nif);
            Console.WriteLine("Categoría.....: " + empleadoNomina.Categoria);
            Console.WriteLine("Nº de Trienios: " + empleadoNomina.NumTrienios);
            Console.WriteLine("Nº de Hijos...: " + empleadoNomina.NumHijos);

            Console.WriteLine("\nDEVENGOS\t\t\t\t\tDESCUENTOS");
            Console.WriteLine("--------\t\t\t\t\t----------");

            //Escribo una línea en dos instrucciones porque si no no me capta bien la instrucción de tener 2 decimales en la segunda cadena
            Console.Write("Salario base\t\t{0:N2}", salarioBase());
            Console.WriteLine("\t\tCotización Seg.Soc.\t{0:N2}", cotizacionSegSoc());

            Console.Write("Antigüedad\t\t{0:N2}", importeAntiguedad());
            Console.WriteLine("\t\t\tCotización Seg.Des.\t{0:N2}", cotizacionSegDes());

            Console.Write("Importe Hor.Ext.\t{0:N2}", importeHorasExtras());
            Console.WriteLine("\t\t\tRetención IRPF\t\t{0:N2}", retencionIRPF());

            if (FechaNomina.Month == 6 || FechaNomina.Month == 12)
            {
                Console.WriteLine("Paga Extra\t\t{0:N2}", devengosPagaExtra());
                Console.Write("\nTotal Devengos\t\t{0:N2}", (totalDevengado() + devengosPagaExtra()));
            }
            else
            {
                Console.Write("\nTotal Devengos\t\t{0:N2}", (totalDevengado()));
            }

            Console.WriteLine("\t\tTotal Descuentos\t{0:N2}", totalDescuentos());

            Console.WriteLine("\n-----------------------------------------------");

            if (FechaNomina.Month == 6 || FechaNomina.Month == 12)
            {
                Console.WriteLine("LIQUIDO A PERCIBIR \t{0:N2}", (totalDevengado() + devengosPagaExtra() - totalDescuentos()));
            }
            else
            {
                Console.WriteLine("LIQUIDO A PERCIBIR \t{0:N2}", (totalDevengado() - totalDescuentos()));
            }

            Console.WriteLine("-----------------------------------------------");
        }

        public double salarioBase()
        {
            double salarioBase = 0;
            switch (empleadoNomina.Categoria)
            {
                case 1:
                    salarioBase = 2500;
                    break;

                case 2:
                    salarioBase = 2000;
                    break;

                case 3:
                    salarioBase = 1500;
                    break;
            }
            return salarioBase;
        }

        public double cotizacionSegDes()
        {
            return devengosPagaExtra() * 1.97 / 100;
        }
        public double cotizacionSegSoc()
        {
            return ((devengosPagaExtra() + devengosPagaExtra() / 6) * 4.51 / 100);
        }
        public double devengosPagaExtra()
        {
            return salarioBase() + importeAntiguedad();
        }

        public double importeAntiguedad()
        {
            return empleadoNomina.NumTrienios * salarioBase() * 4 / 100;
        }

        public double importeHorasExtras()
        {
            return NumHorasExtras * salarioBase() * 1 / 100;
        }

        public double retencionIRPF()
        {
            int porcentajeIRPF = 0;
            switch (EmpleadoNomina.Categoria)
            {
                case 1:
                    porcentajeIRPF = 18;
                    break;
                case 2:
                    porcentajeIRPF = 15;
                    break;
                case 3:
                    porcentajeIRPF = 12;
                    break;
            }
            porcentajeIRPF -= EmpleadoNomina.NumHijos;

            double retencionIRPF = 0;
            if (FechaNomina.Month == 6 || FechaNomina.Month == 12)
            {
                retencionIRPF = (totalDevengado() + devengosPagaExtra()) * porcentajeIRPF / 100;
            }
            else
            {
                retencionIRPF = totalDevengado() * porcentajeIRPF / 100;
            }
            return retencionIRPF;
        }

        public double totalDescuentos()
        {
            return cotizacionSegSoc() + cotizacionSegDes() + retencionIRPF();
        }

        public double totalDevengado()
        {
            return salarioBase() + importeAntiguedad() + importeHorasExtras();
        }
    }
}
