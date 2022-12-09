using System;

/*
* PRÁCTICA.............: Práctica 6.
* NOMBRE Y APELLIDOS...: Pablo Navarro Vázquez
* CURSO Y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO DE LA PRÁCTICA: Aplicaciones de Formulario. Controles Básicos.
* FECHA DE ENTREGA.....: 07 de diciembre de 2022
*/

namespace Practica6
{
    internal class Nomina
    {
        #region Variables

        private Empleado empleadoNomina;
        private DateTime fechaNomina;
        private int numHorasExtras;
        private double salarioBase;
        private double importeAntiguedad;
        private double importeHorasExtras;
        private double devengosPagaExtra;
        private double totalDevengos;

        private double cotizacionSegSoc;
        private double cotizacionSegDes;
        private double retencionIRPF;
        private double totalDescuentos;

        #endregion

        #region Propiedades

        public Empleado EmpleadoNomina { get { return empleadoNomina; } set { empleadoNomina = value; } }
        public DateTime FechaNomina { get { return fechaNomina; } set { fechaNomina = value; } }
        public int NumHorasExtras { get { return numHorasExtras; } set { numHorasExtras = value; } }

        public double SalarioBase { get { return salarioBase; } }
        public double ImporteAntiguedad { get { return importeAntiguedad; } }
        public double ImporteHorasExtras { get { return importeHorasExtras; } }
        public double DevengosPagaExtra { get { return devengosPagaExtra; } }
        public double TotalDevengos { get { return totalDevengos; } }
        public double CotizacionSegSoc{ get { return cotizacionSegSoc; } }
        public double CotizacionSegDes{ get { return cotizacionSegDes; } }
        public double RetencionIRPF{ get { return retencionIRPF; } }
        public double TotalDescuentos{ get { return totalDescuentos; } }

        #endregion

        public Nomina()
        {

        }

        public Nomina(Empleado empleadoNomina, DateTime fechaNomina, int numHorasExtras)
        {
            this.empleadoNomina = empleadoNomina;
            this.fechaNomina = fechaNomina;
            this.numHorasExtras = numHorasExtras;
            this.salarioBase = calcularSalarioBase();
            this.importeAntiguedad = calcularImporteAntiguedad();
            this.importeHorasExtras = calcularImporteHorasExtras();
            this.devengosPagaExtra = calcularDevengosPagaExtra();
            this.totalDevengos = calcularTotalDevengado();

            this.cotizacionSegSoc = calcularCotizacionSegSoc();
            this.cotizacionSegDes = calcularCotizacionSegDes();
            this.retencionIRPF = calcularRetencionIRPF();
            this.totalDescuentos = calcularTotalDescuentos();
        }
        public double calcularSalarioBase()
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

        public double calcularImporteAntiguedad()
        {
            return empleadoNomina.NumTrienios * salarioBase * 4 / 100;
        }

        public double calcularImporteHorasExtras()
        {
            return NumHorasExtras * salarioBase * 1 / 100;
        }

        public double calcularDevengosPagaExtra()
        {
            return salarioBase + importeAntiguedad;
        }

        public double calcularTotalDevengado()
        {
            double totalDevengado = salarioBase + importeAntiguedad + importeHorasExtras;
            if (FechaNomina.Month == 6 || FechaNomina.Month == 12)
            {
                totalDevengado += devengosPagaExtra;
            }

            return totalDevengado;
        }

        public double calcularCotizacionSegSoc()
        {
            return (devengosPagaExtra + devengosPagaExtra / 6) * 4.51 / 100;
        }

        public double calcularCotizacionSegDes()
        {
            return devengosPagaExtra * 1.97 / 100;
        }     

        public double calcularRetencionIRPF()
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

            double retencionIRPF;
            if (FechaNomina.Month == 6 || FechaNomina.Month == 12)
            {
                retencionIRPF = (totalDevengos + devengosPagaExtra) * porcentajeIRPF / 100;
            }
            else
            {
                retencionIRPF = totalDevengos * porcentajeIRPF / 100;
            }
            return retencionIRPF;
        }

        public double calcularTotalDescuentos()
        {
            return cotizacionSegSoc + cotizacionSegDes + retencionIRPF;
        }


    }
}
