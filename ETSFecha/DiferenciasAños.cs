using System;

namespace ETSFecha
{
    class DiferenciasAños
    {
        /// <summary>
        /// Estructura en donde guardar los datos de los años, meses, dias y si es antes de cristo.
        /// Si es antes de cristo(AC) = 0
        /// Si es después de cristo(DC) = 1
        /// </summary>
        public struct datos
        {
            public int anno;
            public int mes;
            public int dia;
            public int ACDC;
        }

        public static int ContadorAñosAC(datos[] allFechas)
        {
            int contador = 0;
            for (int posicion = 0; posicion < allFechas.Length; posicion++)
            {
                if (allFechas[posicion].ACDC == 0)
                {
                    contador++;
                }
            }
            return contador;
        }

        /// <summary>
        ///  Calcula la diferencia en años y en días y se muestra por pantalla.
        /// </summary>
        /// <param name="listaFechas">
        /// El parámetro contiene las dos fechas con las que se va a trabajar.
        /// </param>
        public static void DifferenceYear(datos[] alldata)
        {

            int numACDC = ContadorAñosAC(alldata);

            if (numACDC == 1)
            {

            }

            /*
            int difAños = 0;
            int difDias = 0;
            string fraseFinal;
            if (listaFechas.Length == 2)
            {
                if (listaFechas[0] > listaFechas[1])
                {
                    DifAñosDias(ref difDias, ref difAños, listaFechas[0], listaFechas[1]);
                    fraseFinal = "La diferencia en años es de: " + difAños + " y en dias es de: " + difDias + " dias.";
                }
                else
                {
                    if (listaFechas[0] < listaFechas[1])
                    {
                        DifAñosDias(ref difDias, ref difAños, listaFechas[1], listaFechas[0]);
                        fraseFinal = "La diferencia en años es de: " + difAños + " y en dias es de: " + difDias + " dias.";
                    }
                    else
                    {
                        fraseFinal = "No existe diferencia de años ni de días debido a que son fechas iguales.";
                    }
                }
                Console.WriteLine(fraseFinal);
            }
            else
            {
                Console.WriteLine("Deben de haber dos fechas. No pueden haber ni más ni menos.");
            }
            */
        }

        /// <summary>
        /// Enviadas como argumentos las fechas diferenciadas
        /// </summary>
        /// <param name="dias">
        /// Numero entero total de diferencias entre la fecha menor y mayor en dias
        /// </param>
        /// <param name="años">
        /// Numero entero total entre la fecha menor y mayor en años
        /// </param>
        /// <param name="añoMayor">
        /// Fecha más actual
        /// </param>
        /// <param name="añoMenor">
        /// Fecha más antigua
        /// </param>
        private static void DifAñosDias(ref int dias, ref int años, DateTime añoMayor, DateTime añoMenor)
        {
            años = añoMayor.Year - añoMenor.Year;
            dias = añoMayor.Subtract(añoMenor).Days;
        }
    }
}

/*

static void Main(string[] args)
        {
            var fecha1 = new DateTime(2003, 01, 01);
            var fecha2 = DateTime.Today;
            DateTime[] listaFechas = { fecha1, fecha2 };

            DiferenciasAños.datos[] allfechas = new DiferenciasAños.datos[2];

            allfechas[0].anno = 2000;
            allfechas[0].mes = 12;
            allfechas[0].dia = 30;
            allfechas[0].ACDC = 0;

            allfechas[1].anno = 1920;
            allfechas[1].mes = 6;
            allfechas[1].dia = 20;
            allfechas[1].ACDC = 1;

            DiferenciasAños.DifferenceYear(allfechas); 

*/

