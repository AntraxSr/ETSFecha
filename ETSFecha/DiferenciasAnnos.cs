using System;

namespace ETSFecha
{
    public class DiferenciasAnnos
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

        /// <summary>
        /// Devuelve el numero de fechas antes de cristo que se envíen a través de la estructura(parámetro)
        /// </summary>
        /// <param name="allFechas">
        /// Todos los datos de las fechas pedidas
        /// </param>
        /// <returns></returns>
        private static int ContadorAñosAC(datos[] allFechas)
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
        public static string[] DifferenceYear(datos[] alldata)
        {

            int numACDC = ContadorAñosAC(alldata);

            string[] resultados = new string[2];
            int años = 0;
            int dias = 0;

            if (numACDC == 1)
            {
                DateTime fecha1 = new DateTime(1, alldata[0].mes, alldata[0].dia);
                DateTime fecha2 = new DateTime(alldata[0].anno + alldata[1].anno + 1, alldata[1].mes, alldata[1].dia);

                DifAñosDias(ref dias, ref años, fecha2, fecha1);

                resultados[0] = años.ToString();
                resultados[1] = dias.ToString();
            }
            else
            {
                DateTime fecha1 = new DateTime(alldata[0].anno, alldata[0].mes, alldata[0].dia);
                DateTime fecha2 = new DateTime(alldata[1].anno, alldata[1].mes, alldata[1].dia);

                if (fecha1 > fecha2)
                {
                    DifAñosDias(ref dias, ref años, fecha1, fecha2);
                }
                else
                {
                    if (fecha1 < fecha2)
                    {
                        DifAñosDias(ref dias, ref años, fecha2, fecha1);
                    }
                }
            }

            return resultados;
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