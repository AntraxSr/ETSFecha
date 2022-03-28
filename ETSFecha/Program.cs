using System;

namespace ETSFecha
{
    public class Program
    {
        /// <summary>
        /// Estructura en donde guardar los datos de los años, meses, dias y si es antes de cristo.
        /// Si es antes de cristo(AC) = 0
        /// Si es después de cristo(DC) = 1
        /// </summary>
        public struct Fecha
        {
            public int Anno;
            public int Mes;
            public int Dia;
            public int ACDC;
        }

        static void Main(string[] args)
        {
            Fecha[] allfechas = TomaDatos.UsoStruct();

            string[] resultado = DiferenciasAnnos.DifferenceYear(allfechas);

            Console.WriteLine("La diferencia en años es de: " + resultado[0] + " y en dias: " + resultado[1]);
            Console.ReadKey();

            Dates.ComprobarInformacion(allfechas);
        }
    }
}
