using System;

namespace ETSFecha
{
    public class DiferenciasAnnos
    {

        /// <summary>
        /// Devuelve el numero de fechas antes de cristo que se envíen a través de la estructura(parámetro)
        /// </summary>
        /// <param name="allFechas">
        /// Todos los datos de las fechas pedidas
        /// </param>
        /// <returns></returns>
        private static int ContadorAñosAC(Program.Fecha[] allFechas)
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
        public static string[] DifferenceYear(Program.Fecha[] alldata)
        {
            int numACDC = ContadorAñosAC(alldata);

            string[] resultados = new string[2];
            int años = 0;
            int dias = 0;

            if (numACDC == 1)
            {
                DateTime fecha1 = new DateTime(1, alldata[0].Mes, alldata[0].Dia);
                DateTime fecha2 = new DateTime(alldata[0].Anno + alldata[1].Anno + 1, alldata[1].Mes, alldata[1].Dia);

                DifAñosDias(ref dias, ref años, fecha2, fecha1);

                resultados[0] = años.ToString();
                resultados[1] = dias.ToString();
            }
            else
            {
                DateTime fecha1 = new DateTime(alldata[0].Anno, alldata[0].Mes, alldata[0].Dia);
                DateTime fecha2 = new DateTime(alldata[1].Anno, alldata[1].Mes, alldata[1].Dia);

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
            dias = CalcularDia(añoMayor, añoMenor);
        }
        private static int CalcularDia(DateTime fecha, DateTime fecha2)
        {
            int dia = 0;

            DateTime fechaProvisional = new DateTime(1, fecha.Month, fecha.Day);
            DateTime fechaProvisional2 = new DateTime(1, fecha2.Month, fecha2.Day);

            if (fechaProvisional < fechaProvisional2)
            {
                dia = (fechaProvisional2 - fechaProvisional).Days;
            }
            else
            {
                dia = (fechaProvisional - fechaProvisional2).Days;
            }
            return dia;
        }
    }
}